using System.Collections.Concurrent;
using System.Net;
using System.Net.Sockets;
using System.Text.Json;
using System.Windows.Forms;

namespace WinFormsServerApp
{
    public partial class Form1 : Form
    {
        TcpListener server;
        string key;
        int port;
        bool running;
        int ID_counter;

        BlockingCollection<(int, string, TcpClient, StreamWriter, StreamReader)> blocking =
            new BlockingCollection<(int, string, TcpClient, StreamWriter, StreamReader)>();

        public Form1()
        {
            InitializeComponent();
            keyCheckBox.Checked = false;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            logTextBox.Text = string.Empty;
        }

        private void startStopButton_Click(object sender, EventArgs e)
        {
            if (startStopButton.Text == "Start" && addressTextBox.Text.Length > 0 && usernameTextBox.Text.Length > 0
                && portTextBox.Text.Length > 0)
            {
                if (!int.TryParse(portTextBox.Text, out port))
                {
                    logTextBox.Text += DateTime.Now.ToString("HH:mm") + " | Invalid port\n";
                    return;
                }
                if (startServer(addressTextBox.Text, port))
                {
                    if (keyTextBox.Text.Length > 0)
                    {
                        key = keyTextBox.Text;
                        keyTextBox.Text = string.Empty;
                    }
                    addressTextBox.Text = string.Empty;
                    usernameTextBox.Text = string.Empty;
                    portTextBox.Text = string.Empty;
                    startStopButton.Text = "Stop";
                    running = true;
                    Thread listen = new Thread(Listen);
                    listen.Start();
                }
            }
            else if (startStopButton.Text == "Stop")
            {
                server.Stop();
                running = false;
                disconnectAllButton.Select();
                Log("Shutting down current connection.");
                startStopButton.Text = "Start";
            }
        }

        private bool startServer(string IP, int port)
        {
            try
            {
                if (IP == "localhost")
                {
                    IP = "127.0.0.1";
                }
                IPAddress address = IPAddress.Parse(IP);
                server = new TcpListener(address, port);
                server.Start();
                Log("Listening for incomming connections...");
                    logTextBox.Text += DateTime.Now.ToString("HH:mm") + " | " + address.ToString() +
                    ", Port: " + port.ToString() + "\r\n";
                return true;
            }
            catch (Exception ex)
            {
                Log(ex.Message.ToString());
                return false;
            }
        }

        private void keyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (keyCheckBox.Checked)
            {
                keyTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                keyTextBox.UseSystemPasswordChar = true;
            }
        }

        private void Listen()
        {
            try
            {
                while (running)
                {
                    TcpClient clinet = server.AcceptTcpClient();
                    logTextBox.Invoke(Log, "New client... Authorizing");
                    StreamReader reader = new StreamReader(clinet.GetStream());
                    StreamWriter writer = new StreamWriter(clinet.GetStream());
                    string? mess = reader.ReadLine();
                    if (mess == null) { continue; }
                    Messages.Authorization? auth = JsonSerializer.Deserialize<Messages.Authorization>(mess);
                    if (auth != null)
                    {
                        Messages.Message ret_mess;
                        if (auth.Key == key || key == string.Empty || key == null)
                        {
                            ret_mess = new Messages.Message("server", "Authorized", DateTime.Now);
                            logTextBox.Invoke(Log, auth.Sender + " has connected");
                            dataGridView.Invoke(new Action(() =>
                            {
                                dataGridView.Rows.Add(ID_counter, auth.Sender);
                            }));
                            blocking.Add((ID_counter++, auth.Sender, clinet, writer, reader));
                        }
                        else
                        {
                            logTextBox.Invoke(Log, auth.Sender + " authorization failed");
                            ret_mess = new Messages.Message("server", "Unauthorized", DateTime.Now);
                        }
                        string ret_mess_json = JsonSerializer.Serialize(ret_mess);
                        writer.WriteLine(ret_mess_json);
                        writer.Flush();
                    }
                }
            }
            catch (Exception ex)
            {
                logTextBox.Invoke(Log, ex.Message);
            }
        }

        private void Log(string message)
        {
            logTextBox.Text += DateTime.Now.ToString("HH:mm") + " | " + message + "\r\n";
        }

        private void disconnectAllButton_Click(object sender, EventArgs e)
        {
            while (blocking.Count > 0)
            {
                var client = blocking.Take();
                var tcp = client.Item3;
                var writer = client.Item4;
                var reader = client.Item5;
                try
                {
                    tcp.Close();
                    writer.Close();
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Log(ex.Message);
                }
                Log($"{client.Item2} has disconnected");
            }
            dataGridView.Rows.Clear();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == dataGridView.Columns["disconnectDGV"].Index && e.RowIndex >= 0) 
            {
                int id = (int)dataGridView.Rows[e.RowIndex].Cells[0].Value;
                var blocking_help = new BlockingCollection<(int, string, TcpClient, StreamWriter, StreamReader)>();
                while(blocking.Count > 0)
                {
                    var client = blocking.Take();
                    if(client.Item1 != id)
                    {
                        blocking_help.Add(client);
                        continue;
                    }
                    var tcp = client.Item3;
                    var writer = client.Item4;
                    var reader = client.Item5;
                    try
                    {
                        tcp.Close();
                        writer.Close();
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        Log(ex.Message);
                    }
                    Log($"{client.Item2} has disconnected");
                }
                blocking.Dispose();
                blocking = blocking_help;
                dataGridView.Rows.RemoveAt(e.RowIndex);
            }
        }
    }
}
