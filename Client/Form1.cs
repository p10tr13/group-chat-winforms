using System.Net.Sockets;
using System.Text.Json;

namespace WinFormsLab
{
    public partial class Form1 : Form
    {
        public bool connected;

        TcpClient? tcpClient;

        StreamWriter writer;

        StreamReader reader;

        string sender = " ";

        public Form1()
        {
            InitializeComponent();
            messagesPanel.AutoScrollMargin = new System.Drawing.Size(0, 0);
            messagesPanel.AutoScrollMinSize = new System.Drawing.Size(0, messagesPanel.Height + 1);
            messagesPanel.HorizontalScroll.Enabled = false;
            connected = false;
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            if (messagetextBox.Text.Length == 0)
                return;
            messageControl MC;
            Messages.Message mess = new Messages.Message(this.sender, messagetextBox.Text, DateTime.Now);
            MC = new messageControl("You",messagetextBox.Text, DateTime.Now);
            Add_Message(MC);
            if(connected)
            {
                string mess_json = JsonSerializer.Serialize<Messages.Message>(mess) + '\n';
                writer.Write(mess_json);
                writer.Flush();
            }
            messagetextBox.Clear();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                sendButton_Click(sender, e);
            }
        }

        private void messagetextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                sendButton_Click(sender, e);
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            int LocationY = 0;
            foreach (Control control in messagesPanel.Controls)
            {
                if (control is messageControl MC)
                {
                    if (MC.mess.Sender == "You")
                    {
                        MC.Width = messagesPanel.Width - 50 - (messagesPanel.VerticalScroll.Visible ? SystemInformation.VerticalScrollBarWidth : 0) - 5;
                        MC.Location = new Point(50, LocationY);
                    }
                    else
                    {
                        MC.Width = messagesPanel.Width - 50 - (messagesPanel.VerticalScroll.Visible ? SystemInformation.VerticalScrollBarWidth : 0) - 5;
                        MC.Location = new Point(0, LocationY);
                    }
                    MC.Set_Preferred_Height();
                    LocationY = LocationY + MC.Height + 5;
                }
                else if (control is Label LB)
                {
                    LB.Location = new Point((messagesPanel.Width - LB.Width) / 2, LocationY);
                    LocationY = LocationY + LB.Height + 5;
                }
            }
            messagesPanel.AutoScrollPosition = new Point(0, 0);
            messagesPanel.VerticalScroll.Value = 0;
            messagesPanel.AutoScrollMinSize = new System.Drawing.Size(0, messagesPanel.Height + 1);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (connected)
            {
                connected = false;
                tcpClient.Close();
                tcpClient.Dispose();
            }
            Close();
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConnectionDialog connectionDialog = new ConnectionDialog(this);
            connectionDialog.ShowDialog();
        }

        public void Update_Client(TcpClient client, StreamReader rd, StreamWriter wr, string sender)
        {
            tcpClient = client;
            connected = true;
            connectToolStripMenuItem.Enabled = false;
            disconectToolStripMenuItem.Enabled = true;
            reader = rd;
            writer = wr;
            this.sender = sender;
            Add_Label("Connected");
            Thread receiver = new Thread(Receive_Messages);
            receiver.Start();
        }

        private void Add_Label(string text)
        {
            int height = 0;
            if (messagesPanel.Controls.Count > 0)
            {
                Control lastMessage = messagesPanel.Controls[messagesPanel.Controls.Count - 1];
                height = lastMessage.Bottom + 5;
            }
            Label connectLabel = new Label();
            connectLabel.ForeColor = Color.LightGray;
            connectLabel.Text = text;
            int middle = (messagesPanel.Width - connectLabel.Width) / 2;
            messagesPanel.Controls.Add(connectLabel);
            connectLabel.Location = new Point(middle, height);
            messagesPanel.ScrollControlIntoView(connectLabel);
        }

        private void Add_Message(messageControl MC)
        {
            int height = 0, width = 0;
            if (messagesPanel.Controls.Count > 0)
            {
                Control lastMessage = messagesPanel.Controls[messagesPanel.Controls.Count - 1];
                height = lastMessage.Bottom + 5;
            }
            if (MC.mess.Sender == "You")
            {
                width = 50;
            }
            MC.Location = new Point(width, height);
            messagesPanel.Controls.Add(MC);
            MC.Width = messagesPanel.Width - 50 - (messagesPanel.VerticalScroll.Visible ? SystemInformation.VerticalScrollBarWidth : 0);
            messagesPanel.ScrollControlIntoView(MC);
        }

        private void Add_Message2(Messages.Message message) 
        {
            int height = 0, width = 0;
            messageControl MC = new messageControl(message);
            if (messagesPanel.Controls.Count > 0)
            {
                Control lastMessage = messagesPanel.Controls[messagesPanel.Controls.Count - 1];
                height = lastMessage.Bottom + 5;
            }
            if (MC.mess.Sender == "You")
            {
                width = 50;
            }
            MC.Location = new Point(width, height);
            messagesPanel.Controls.Add(MC);
            MC.Width = messagesPanel.Width - 50 - (messagesPanel.VerticalScroll.Visible ? SystemInformation.VerticalScrollBarWidth : 0);
            messagesPanel.ScrollControlIntoView(MC);
        }

        private void Receive_Messages()
        {
            if(tcpClient != null) 
            {
                while(connected)
                {
                    string? received_msg_json;
                    try
                    {
                        received_msg_json = reader.ReadLine();
                    }
                    catch(Exception ex) 
                    {
                        sendButton.Invoke(Disconnect);
                        reader.Close(); return;
                    }
                    
                    if (received_msg_json != string.Empty && received_msg_json != null)
                    {
                        Messages.Message message = JsonSerializer.Deserialize<Messages.Message>(received_msg_json);
                        messagesPanel.Invoke(Add_Message2, message);
                    }
                    if(received_msg_json != string.Empty || received_msg_json != null)
                    {
                        sendButton.Invoke(Disconnect);
                        return;
                    }
                }
            }
        }

        private void disconectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(connected && tcpClient != null) 
            { 
                tcpClient.Dispose();
                tcpClient.Close();
                connected = false;
                Add_Label("Disconnected");
                disconectToolStripMenuItem.Enabled = false;
                connectToolStripMenuItem.Enabled = true;
            }
        }

        private void Disconnect()
        {
            if (connected && tcpClient != null)
            {
                tcpClient.Dispose();
                tcpClient.Close();
                connected = false;
                Add_Label("Disconnected");
                disconectToolStripMenuItem.Enabled = false;
                connectToolStripMenuItem.Enabled = true;
            }
        }
    }
}