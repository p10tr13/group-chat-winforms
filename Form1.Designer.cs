namespace WinFormsLab
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            messagetextBox = new TextBox();
            sendButton = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            messagesPanel = new Panel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // messagetextBox
            // 
            messagetextBox.Dock = DockStyle.Fill;
            messagetextBox.Location = new Point(3, 3);
            messagetextBox.MaximumSize = new Size(0, 30);
            messagetextBox.MinimumSize = new Size(0, 30);
            messagetextBox.Name = "messagetextBox";
            messagetextBox.Size = new Size(272, 30);
            messagetextBox.TabIndex = 1;
            // 
            // sendButton
            // 
            sendButton.Dock = DockStyle.Fill;
            sendButton.Location = new Point(281, 3);
            sendButton.MaximumSize = new Size(90, 30);
            sendButton.MinimumSize = new Size(90, 30);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(90, 30);
            sendButton.TabIndex = 0;
            sendButton.Text = "Send";
            sendButton.UseVisualStyleBackColor = true;
            sendButton.Click += sendButton_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.Controls.Add(sendButton, 1, 0);
            tableLayoutPanel1.Controls.Add(messagetextBox, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 508);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(378, 36);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // messagesPanel
            // 
            messagesPanel.AutoScroll = true;
            messagesPanel.Dock = DockStyle.Fill;
            messagesPanel.Location = new Point(0, 0);
            messagesPanel.Name = "messagesPanel";
            messagesPanel.Size = new Size(378, 508);
            messagesPanel.TabIndex = 2;
            messagesPanel.SizeChanged += messagesPanel_SizeChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 544);
            Controls.Add(messagesPanel);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(320, 480);
            Name = "Form1";
            Text = "Group Chat";
            KeyDown += Form1_KeyDown;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox messagetextBox;
        private Button sendButton;
        private TableLayoutPanel tableLayoutPanel1;
        private messageControl messageControl1;
        private Panel messagesPanel;
    }
}
