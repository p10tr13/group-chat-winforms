using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Messages;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsLab
{
    public partial class messageControl : UserControl
    {
        //https://stackoverflow.com/questions/32987649/how-to-create-a-user-control-with-rounded-corners

        private int radius = 20;

        public Messages.Message mess;

        public int Radius
        {
            get { return radius; }
            set
            {
                radius = value;
                this.RecreateRegion();
            }
        }

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect,
            int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        private GraphicsPath GetRoundRectagle(Rectangle bounds, int radius)
        {
            float r = radius;
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(bounds.Left, bounds.Top, r, r, 180, 90);
            path.AddArc(bounds.Right - r, bounds.Top, r, r, 270, 90);
            path.AddArc(bounds.Right - r, bounds.Bottom - r, r, r, 0, 90);
            path.AddArc(bounds.Left, bounds.Bottom - r, r, r, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void RecreateRegion()
        {
            var bounds = ClientRectangle;

            this.Region = Region.FromHrgn(CreateRoundRectRgn(bounds.Left, bounds.Top,
                bounds.Right, bounds.Bottom, Radius, radius));
            this.Invalidate();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            this.RecreateRegion();
        }

        public messageControl(string sender, string text, DateTime time)
        {
            InitializeComponent();
            mess = new Messages.Message(sender, text, time);
            nameLabel.Text = mess.Sender;
            dateLabel.Text = mess.Time.ToString("HH:mm");
            messageTextBox.Text = text;
            nameLabel.Location = new Point(5, 5);
            dateLabel.Location = new Point(this.Width - dateLabel.Width - 5, this.Height - dateLabel.Height - 5);
            Anchor = AnchorStyles.Left | AnchorStyles.Top;
            Set_Preferred_Height();
        }

        private void messageTextBox_TextChanged(object sender, EventArgs e)
        {
            int lines = messageTextBox.GetLineFromCharIndex(messageTextBox.TextLength) + 1;
            messageTextBox.Height = messageTextBox.Font.Height * lines + messageTextBox.Height - messageTextBox.ClientSize.Height;
        }

        public int Set_Preferred_Height()
        {
            messageTextBox_TextChanged(null, null);
            int cos = tableLayoutPanel1.GetRowHeights()[2];
            Height = messageTextBox.Height + tableLayoutPanel1.GetRowHeights()[0] + tableLayoutPanel1.GetRowHeights()[2];
            return messageTextBox.Height + tableLayoutPanel1.GetRowHeights()[0] + tableLayoutPanel1.GetRowHeights()[2];
        }
    }
}
