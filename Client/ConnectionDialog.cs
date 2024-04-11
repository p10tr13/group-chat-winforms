using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsLab
{
    public partial class ConnectionDialog : Form
    {
        Form1 parent;

        public ConnectionDialog(Form1 parent)
        {
            InitializeComponent();
            showKeyCheckBox.Checked = true;
            this.parent = parent;
        }

        private void showKeyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showKeyCheckBox.Checked)
            {
                keyTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                keyTextBox.UseSystemPasswordChar = true;
            }
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            connectButton.Enabled = false;
            if (addressTextBox.Text.Length == 0 || usernameTextBox.Text.Length == 0 || portTextBox.Text.Length == 0)
            { connectButton.Enabled = true; return; }
            try
            {
                TcpClient Client = new TcpClient(addressTextBox.Text, int.Parse(portTextBox.Text));
                progressBar.Value = 25;
                StreamWriter writer = new StreamWriter(Client.GetStream());
                StreamReader reader = new StreamReader(Client.GetStream());
                Messages.Authorization auth;
                if (keyTextBox.Text.Length == 0) { auth = new Messages.Authorization(usernameTextBox.Text, string.Empty); }
                else { auth = new Messages.Authorization(usernameTextBox.Text, keyTextBox.Text); }
                string json_auth = JsonSerializer.Serialize(auth);
                writer.WriteLine(json_auth);
                writer.Flush();
                progressBar.Value = 50;
                string? received_msg_json = reader.ReadLine();
                if (received_msg_json == string.Empty)
                {
                    progressBar.Value = 0;
                    MessageBox.Show("Błąd połączenia (brak odpowiedzi od serwera)");
                    connectButton.Enabled = true;
                    writer.Close();
                    reader.Close();
                    return;
                }
                progressBar.Value = 75;
                Messages.Message? received_msg = JsonSerializer.Deserialize<Messages.Message>(received_msg_json);
                if (received_msg != null && received_msg.Text == "Unauthorized")
                {
                    writer.Close();
                    reader.Close();
                    throw new Exception("Unauthorized");
                }
                progressBar.Value = 100;
                parent.Update_Client(Client, reader, writer, usernameTextBox.Text);
                MessageBox.Show("Udało się połączyć z serwerem", "Success");
                Close();
            }
            catch (Exception ex)
            {
                progressBar.Value = 0;
                MessageBox.Show(ex.Message, "Error");
                connectButton.Enabled = true;
                return;
            }
        }
    }
}
