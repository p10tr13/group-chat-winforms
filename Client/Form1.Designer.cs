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
            menuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            disconectToolStripMenuItem = new ToolStripMenuItem();
            connectToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel1.SuspendLayout();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // messagetextBox
            // 
            messagetextBox.Dock = DockStyle.Fill;
            messagetextBox.Location = new Point(2, 2);
            messagetextBox.Margin = new Padding(2);
            messagetextBox.Name = "messagetextBox";
            messagetextBox.Size = new Size(191, 23);
            messagetextBox.TabIndex = 1;
            messagetextBox.KeyDown += messagetextBox_KeyDown;
            // 
            // sendButton
            // 
            sendButton.Dock = DockStyle.Fill;
            sendButton.Location = new Point(197, 2);
            sendButton.Margin = new Padding(2);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(66, 25);
            sendButton.TabIndex = 0;
            sendButton.Text = "Send";
            sendButton.UseVisualStyleBackColor = true;
            sendButton.Click += sendButton_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70F));
            tableLayoutPanel1.Controls.Add(sendButton, 1, 0);
            tableLayoutPanel1.Controls.Add(messagetextBox, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 297);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(265, 29);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // messagesPanel
            // 
            messagesPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            messagesPanel.AutoScroll = true;
            messagesPanel.Location = new Point(0, 26);
            messagesPanel.Margin = new Padding(2);
            messagesPanel.Name = "messagesPanel";
            messagesPanel.Size = new Size(265, 271);
            messagesPanel.TabIndex = 2;
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(265, 24);
            menuStrip.TabIndex = 3;
            menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { disconectToolStripMenuItem, connectToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // disconectToolStripMenuItem
            // 
            disconectToolStripMenuItem.Enabled = false;
            disconectToolStripMenuItem.Name = "disconectToolStripMenuItem";
            disconectToolStripMenuItem.Size = new Size(180, 22);
            disconectToolStripMenuItem.Text = "Disconect...";
            disconectToolStripMenuItem.Click += disconectToolStripMenuItem_Click;
            // 
            // connectToolStripMenuItem
            // 
            connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            connectToolStripMenuItem.Size = new Size(180, 22);
            connectToolStripMenuItem.Text = "Connect";
            connectToolStripMenuItem.Click += connectToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(180, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(265, 326);
            Controls.Add(messagesPanel);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip);
            Margin = new Padding(2);
            MinimumSize = new Size(229, 304);
            Name = "Form1";
            ShowIcon = false;
            Text = "Group Chat";
            KeyDown += Form1_KeyDown;
            Resize += Form1_Resize;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox messagetextBox;
        private Button sendButton;
        private TableLayoutPanel tableLayoutPanel1;
        private messageControl messageControl1;
        private Panel messagesPanel;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem disconectToolStripMenuItem;
        private ToolStripMenuItem connectToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}
