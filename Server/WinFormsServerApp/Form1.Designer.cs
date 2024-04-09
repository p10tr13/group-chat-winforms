namespace WinFormsServerApp
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
            mainTableLayoutPanel = new TableLayoutPanel();
            splitContainer1 = new SplitContainer();
            usernameLabel = new Label();
            adressLabel = new Label();
            keyLabel = new Label();
            portLabel = new Label();
            usernameTextBox = new TextBox();
            addressTextBox = new TextBox();
            keyTextBox = new TextBox();
            portTextBox = new TextBox();
            logLabel = new Label();
            disconnectAllButton = new Button();
            clearButton = new Button();
            startStopButton = new Button();
            sendButton = new Button();
            sendTextBox = new TextBox();
            logTextBox = new TextBox();
            dataGridView = new DataGridView();
            IDDGV = new DataGridViewTextBoxColumn();
            nameDGV = new DataGridViewTextBoxColumn();
            disconnectDGV = new DataGridViewTextBoxColumn();
            mainTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            mainTableLayoutPanel.ColumnCount = 2;
            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            mainTableLayoutPanel.Controls.Add(splitContainer1, 0, 0);
            mainTableLayoutPanel.Controls.Add(dataGridView, 1, 0);
            mainTableLayoutPanel.Dock = DockStyle.Fill;
            mainTableLayoutPanel.Location = new Point(0, 0);
            mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            mainTableLayoutPanel.RowCount = 1;
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            mainTableLayoutPanel.Size = new Size(684, 361);
            mainTableLayoutPanel.TabIndex = 0;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(usernameLabel);
            splitContainer1.Panel1.Controls.Add(adressLabel);
            splitContainer1.Panel1.Controls.Add(keyLabel);
            splitContainer1.Panel1.Controls.Add(portLabel);
            splitContainer1.Panel1.Controls.Add(usernameTextBox);
            splitContainer1.Panel1.Controls.Add(addressTextBox);
            splitContainer1.Panel1.Controls.Add(keyTextBox);
            splitContainer1.Panel1.Controls.Add(portTextBox);
            splitContainer1.Panel1.Controls.Add(logLabel);
            splitContainer1.Panel1.Controls.Add(disconnectAllButton);
            splitContainer1.Panel1.Controls.Add(clearButton);
            splitContainer1.Panel1.Controls.Add(startStopButton);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(sendButton);
            splitContainer1.Panel2.Controls.Add(sendTextBox);
            splitContainer1.Panel2.Controls.Add(logTextBox);
            splitContainer1.Size = new Size(404, 355);
            splitContainer1.SplitterDistance = 134;
            splitContainer1.TabIndex = 1;
            // 
            // usernameLabel
            // 
            usernameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(160, 37);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(63, 15);
            usernameLabel.TabIndex = 11;
            usernameLabel.Text = "Username:";
            // 
            // adressLabel
            // 
            adressLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            adressLabel.AutoSize = true;
            adressLabel.Location = new Point(176, 8);
            adressLabel.Name = "adressLabel";
            adressLabel.Size = new Size(45, 15);
            adressLabel.TabIndex = 10;
            adressLabel.Text = "Adress:";
            // 
            // keyLabel
            // 
            keyLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            keyLabel.AutoSize = true;
            keyLabel.Location = new Point(300, 37);
            keyLabel.Name = "keyLabel";
            keyLabel.Size = new Size(29, 15);
            keyLabel.TabIndex = 9;
            keyLabel.Text = "Key:";
            // 
            // portLabel
            // 
            portLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            portLabel.AutoSize = true;
            portLabel.Location = new Point(297, 8);
            portLabel.Name = "portLabel";
            portLabel.Size = new Size(32, 15);
            portLabel.TabIndex = 8;
            portLabel.Text = "Port:";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            usernameTextBox.Location = new Point(229, 34);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(62, 23);
            usernameTextBox.TabIndex = 7;
            usernameTextBox.Text = "user";
            // 
            // addressTextBox
            // 
            addressTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addressTextBox.Location = new Point(229, 5);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(62, 23);
            addressTextBox.TabIndex = 6;
            addressTextBox.Text = "localhost";
            // 
            // keyTextBox
            // 
            keyTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            keyTextBox.Location = new Point(335, 34);
            keyTextBox.Name = "keyTextBox";
            keyTextBox.Size = new Size(62, 23);
            keyTextBox.TabIndex = 5;
            // 
            // portTextBox
            // 
            portTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            portTextBox.Location = new Point(335, 5);
            portTextBox.Name = "portTextBox";
            portTextBox.Size = new Size(62, 23);
            portTextBox.TabIndex = 4;
            portTextBox.Text = "9000";
            // 
            // logLabel
            // 
            logLabel.Anchor = AnchorStyles.Bottom;
            logLabel.AutoSize = true;
            logLabel.Location = new Point(187, 113);
            logLabel.Name = "logLabel";
            logLabel.Size = new Size(27, 15);
            logLabel.TabIndex = 3;
            logLabel.Text = "Log";
            // 
            // disconnectAllButton
            // 
            disconnectAllButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            disconnectAllButton.Location = new Point(301, 104);
            disconnectAllButton.Name = "disconnectAllButton";
            disconnectAllButton.Size = new Size(96, 24);
            disconnectAllButton.TabIndex = 2;
            disconnectAllButton.Text = "Disconnect All";
            disconnectAllButton.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            clearButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            clearButton.Location = new Point(7, 105);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(76, 24);
            clearButton.TabIndex = 1;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // startStopButton
            // 
            startStopButton.Location = new Point(3, 3);
            startStopButton.Name = "startStopButton";
            startStopButton.Size = new Size(74, 25);
            startStopButton.TabIndex = 0;
            startStopButton.Text = "Start";
            startStopButton.UseVisualStyleBackColor = true;
            startStopButton.Click += startStopButton_Click;
            // 
            // sendButton
            // 
            sendButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            sendButton.Location = new Point(321, 190);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(80, 23);
            sendButton.TabIndex = 2;
            sendButton.Text = "Send";
            sendButton.UseVisualStyleBackColor = true;
            // 
            // sendTextBox
            // 
            sendTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            sendTextBox.Location = new Point(3, 191);
            sendTextBox.Name = "sendTextBox";
            sendTextBox.Size = new Size(312, 23);
            sendTextBox.TabIndex = 1;
            // 
            // logTextBox
            // 
            logTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            logTextBox.Location = new Point(0, 0);
            logTextBox.Multiline = true;
            logTextBox.Name = "logTextBox";
            logTextBox.ScrollBars = ScrollBars.Vertical;
            logTextBox.Size = new Size(404, 185);
            logTextBox.TabIndex = 0;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.BackgroundColor = SystemColors.Window;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { IDDGV, nameDGV, disconnectDGV });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(413, 3);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersVisible = false;
            dataGridView.Size = new Size(268, 355);
            dataGridView.TabIndex = 2;
            // 
            // IDDGV
            // 
            IDDGV.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            IDDGV.HeaderText = "ID";
            IDDGV.Name = "IDDGV";
            IDDGV.ReadOnly = true;
            // 
            // nameDGV
            // 
            nameDGV.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nameDGV.HeaderText = "Name";
            nameDGV.Name = "nameDGV";
            nameDGV.ReadOnly = true;
            // 
            // disconnectDGV
            // 
            disconnectDGV.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            disconnectDGV.HeaderText = "Disconnect";
            disconnectDGV.Name = "disconnectDGV";
            disconnectDGV.Width = 91;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 361);
            Controls.Add(mainTableLayoutPanel);
            MinimumSize = new Size(700, 400);
            Name = "Form1";
            Text = "Server";
            mainTableLayoutPanel.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel mainTableLayoutPanel;
        private SplitContainer splitContainer1;
        private Button sendButton;
        private TextBox sendTextBox;
        private TextBox logTextBox;
        private Button startStopButton;
        private Button clearButton;
        private Button disconnectAllButton;
        private Label logLabel;
        private TextBox portTextBox;
        private TextBox usernameTextBox;
        private TextBox addressTextBox;
        private TextBox keyTextBox;
        private Label keyLabel;
        private Label portLabel;
        private Label adressLabel;
        private Label usernameLabel;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn IDDGV;
        private DataGridViewTextBoxColumn nameDGV;
        private DataGridViewTextBoxColumn disconnectDGV;
    }
}
