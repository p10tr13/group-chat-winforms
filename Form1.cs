namespace WinFormsLab
{
    public partial class Form1 : Form
    {
        int you_not_you_counter = 0;

        public Form1()
        {
            InitializeComponent();
            messagesPanel.AutoScrollMargin = new System.Drawing.Size(0, 0);
            messagesPanel.AutoScrollMinSize = new System.Drawing.Size(0, messagesPanel.Height + 1);
            messagesPanel.HorizontalScroll.Enabled = false;

        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            if (messagetextBox.Text.Length == 0)
                return;
            messageControl MC;
            int height = 0, width = 0;
            if (you_not_you_counter % 2 == 0)
            {
                MC = new messageControl("You", messagetextBox.Text, DateTime.Now);
            }
            else
            {
                MC = new messageControl("NotYou", messagetextBox.Text, DateTime.Now);
            }

            if (messagesPanel.Controls.Count > 0)
            {
                Control lastMessage = messagesPanel.Controls[messagesPanel.Controls.Count - 1];
                height = lastMessage.Bottom + 5;
            }
            if (you_not_you_counter % 2 == 0)
            {
                width = 50;
            }
            MC.Location = new Point(width, height);
            messagetextBox.Clear();
            messagesPanel.Controls.Add(MC);
            MC.Width = messagesPanel.Width - 50 - (messagesPanel.VerticalScroll.Visible ? SystemInformation.VerticalScrollBarWidth : 0); ;
            messagesPanel.ScrollControlIntoView(MC);
            you_not_you_counter++;
        }

        private void messagesPanel_SizeChanged(object sender, EventArgs e)
        {
            foreach (Control control in messagesPanel.Controls)
            {
                if (control is messageControl MC)
                {
                    if (MC.mess.Sender == "You")
                    {
                        MC.Width = messagesPanel.Width - 50 - (messagesPanel.VerticalScroll.Visible ? SystemInformation.VerticalScrollBarWidth : 0);
                        MC.Location = new Point(50, MC.Location.Y);
                    }
                    else
                    {
                        MC.Width = messagesPanel.Width - 50 - (messagesPanel.VerticalScroll.Visible ? SystemInformation.VerticalScrollBarWidth : 0); ;
                        MC.Location = new Point(0, MC.Location.Y);
                    }
                }
            }
            messagesPanel.AutoScrollMinSize = new System.Drawing.Size(0, messagesPanel.Height + 1);
            messagesPanel.HorizontalScroll.Visible = false;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) 
            {
                sendButton_Click(sender, e);
            }
        }
    }
}