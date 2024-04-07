namespace WinFormsLab
{
    partial class messageControl
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            dateLabel = new Label();
            nameLabel = new Label();
            messageTextBox = new TextBox();
            SuspendLayout();
            // 
            // dateLabel
            // 
            dateLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            dateLabel.AutoSize = true;
            dateLabel.Font = new Font("Segoe UI", 7F);
            dateLabel.ForeColor = Color.LightGray;
            dateLabel.Location = new Point(241, 65);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(36, 19);
            dateLabel.TabIndex = 0;
            dateLabel.Text = "date";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            nameLabel.ForeColor = Color.White;
            nameLabel.Location = new Point(0, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(59, 25);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "name";
            // 
            // messageTextBox
            // 
            messageTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            messageTextBox.BackColor = Color.FromArgb(255, 128, 0);
            messageTextBox.BorderStyle = BorderStyle.None;
            messageTextBox.ForeColor = Color.White;
            messageTextBox.Location = new Point(10, 28);
            messageTextBox.Multiline = true;
            messageTextBox.Name = "messageTextBox";
            messageTextBox.ReadOnly = true;
            messageTextBox.Size = new Size(225, 59);
            messageTextBox.TabIndex = 2;
            // 
            // messageControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            Controls.Add(messageTextBox);
            Controls.Add(nameLabel);
            Controls.Add(dateLabel);
            MinimumSize = new Size(200, 90);
            Name = "messageControl";
            Size = new Size(300, 90);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label dateLabel;
        private Label nameLabel;
        private TextBox messageTextBox;
    }
}
