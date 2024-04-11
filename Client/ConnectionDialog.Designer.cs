namespace WinFormsLab
{
    partial class ConnectionDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            addressLabel = new Label();
            usernameLabel = new Label();
            portLabel = new Label();
            keyLabel = new Label();
            portTextBox = new TextBox();
            keyTextBox = new TextBox();
            addressTextBox = new TextBox();
            usernameTextBox = new TextBox();
            showKeyCheckBox = new CheckBox();
            progressBar = new ProgressBar();
            connectButton = new Button();
            SuspendLayout();
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new Point(12, 18);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(52, 15);
            addressLabel.TabIndex = 0;
            addressLabel.Text = "Address:";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(1, 61);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(63, 15);
            usernameLabel.TabIndex = 1;
            usernameLabel.Text = "Username:";
            // 
            // portLabel
            // 
            portLabel.AutoSize = true;
            portLabel.Location = new Point(160, 18);
            portLabel.Name = "portLabel";
            portLabel.Size = new Size(32, 15);
            portLabel.TabIndex = 2;
            portLabel.Text = "Port:";
            // 
            // keyLabel
            // 
            keyLabel.AutoSize = true;
            keyLabel.Location = new Point(166, 61);
            keyLabel.Name = "keyLabel";
            keyLabel.Size = new Size(26, 15);
            keyLabel.TabIndex = 3;
            keyLabel.Text = "Key";
            // 
            // portTextBox
            // 
            portTextBox.Location = new Point(192, 10);
            portTextBox.Name = "portTextBox";
            portTextBox.Size = new Size(80, 23);
            portTextBox.TabIndex = 4;
            portTextBox.Text = "9000";
            // 
            // keyTextBox
            // 
            keyTextBox.Location = new Point(195, 58);
            keyTextBox.Name = "keyTextBox";
            keyTextBox.Size = new Size(77, 23);
            keyTextBox.TabIndex = 5;
            // 
            // addressTextBox
            // 
            addressTextBox.Location = new Point(68, 10);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(80, 23);
            addressTextBox.TabIndex = 6;
            addressTextBox.Text = "127.0.0.1";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(68, 58);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(80, 23);
            usernameTextBox.TabIndex = 7;
            usernameTextBox.Text = "user_mine";
            // 
            // showKeyCheckBox
            // 
            showKeyCheckBox.AutoSize = true;
            showKeyCheckBox.Location = new Point(189, 99);
            showKeyCheckBox.Name = "showKeyCheckBox";
            showKeyCheckBox.Size = new Size(76, 19);
            showKeyCheckBox.TabIndex = 8;
            showKeyCheckBox.Text = "Show key";
            showKeyCheckBox.UseVisualStyleBackColor = true;
            showKeyCheckBox.CheckedChanged += showKeyCheckBox_CheckedChanged;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(9, 134);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(188, 22);
            progressBar.TabIndex = 9;
            // 
            // connectButton
            // 
            connectButton.Location = new Point(206, 131);
            connectButton.Name = "connectButton";
            connectButton.Size = new Size(75, 28);
            connectButton.TabIndex = 10;
            connectButton.Text = "Connect";
            connectButton.UseVisualStyleBackColor = true;
            connectButton.Click += connectButton_Click;
            // 
            // ConnectionDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 161);
            Controls.Add(connectButton);
            Controls.Add(progressBar);
            Controls.Add(showKeyCheckBox);
            Controls.Add(usernameTextBox);
            Controls.Add(addressTextBox);
            Controls.Add(keyTextBox);
            Controls.Add(portTextBox);
            Controls.Add(keyLabel);
            Controls.Add(portLabel);
            Controls.Add(usernameLabel);
            Controls.Add(addressLabel);
            MaximumSize = new Size(300, 200);
            MinimumSize = new Size(300, 200);
            Name = "ConnectionDialog";
            ShowIcon = false;
            Text = "Connect";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label addressLabel;
        private Label usernameLabel;
        private Label portLabel;
        private Label keyLabel;
        private TextBox portTextBox;
        private TextBox keyTextBox;
        private TextBox addressTextBox;
        private TextBox usernameTextBox;
        private CheckBox showKeyCheckBox;
        private ProgressBar progressBar;
        private Button connectButton;
    }
}