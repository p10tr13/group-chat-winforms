using System.Net.Sockets;

namespace WinFormsServerApp
{
    public partial class Form1 : Form
    {
        TcpListener server;
        int key;
        int port;


        public Form1()
        {
            InitializeComponent();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            logTextBox.Text = string.Empty;
        }

        private void startStopButton_Click(object sender, EventArgs e)
        {
            if(startStopButton.Text == "Start" && addressTextBox.Text.Length > 0 && usernameTextBox.Text.Length > 0
                && portTextBox.Text.Length > 0) 
            {
                port = int.Parse(portTextBox.Text);
                server = new TcpListener(System.Net.IPAddress.Any,port);
                server.Start();
            }
        }
    }
}
