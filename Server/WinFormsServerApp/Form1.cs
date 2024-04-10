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
                }
            }
            else if (startStopButton.Text == "Stop")
            {
                server.Stop();
                logTextBox.Text += DateTime.Now.ToString("HH:mm") + " | Shutting down current connection.\r\n";
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
                logTextBox.Text += DateTime.Now.ToString("HH:mm") + " | Listening for incomming connections...\r\n";
                logTextBox.Text += DateTime.Now.ToString("HH:mm") + " | " + address.ToString() +
                    ", Port: " + port.ToString() + "\r\n";
                return true;
            }
            catch (Exception ex)
            {
                logTextBox.Text += DateTime.Now.ToString("HH:mm") + " | " + ex.Message.ToString() + "\r\n";
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
                while(running)
                {
                    TcpClient clinet = server.AcceptTcpClient();
                    StreamReader reader = new StreamReader(clinet.GetStream());
                    string? mess = reader.ReadLine();
                    if (mess == null) { continue; }
                    Messages.Authorization? auth = JsonSerializer.Deserialize<Messages.Authorization>(mess);
                    if(auth != null)
                    {
                        StreamWriter writer = new StreamWriter(clinet.GetStream());
                        Messages.Message ret_mess;
                        if (auth.Key == key || key == string.Empty)
                        {
                            ret_mess = new Messages.Message("server", "Authorized", DateTime.Now);
                        }
                        else
                        {
                            ret_mess = new Messages.Message("server", "Unauthorized", DateTime.Now);
                        }
                        string ret_mess_json = JsonSerializer.Serialize(ret_mess) + "\n";
                        writer.WriteLine(ret_mess_json);
                    }
                }
            }
            catch(Exception ex) 
            { 
                
            }
        }
    }
}
