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
            nameLabel = new Label();
            messageTextBox = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            dateLabel = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            nameLabel.ForeColor = Color.White;
            nameLabel.Location = new Point(2, 0);
            nameLabel.Margin = new Padding(2, 0, 2, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(38, 15);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "name";
            // 
            // messageTextBox
            // 
            messageTextBox.BackColor = Color.FromArgb(255, 128, 0);
            messageTextBox.BorderStyle = BorderStyle.None;
            messageTextBox.Dock = DockStyle.Fill;
            messageTextBox.ForeColor = Color.White;
            messageTextBox.Location = new Point(2, 17);
            messageTextBox.Margin = new Padding(2);
            messageTextBox.MinimumSize = new Size(0, 15);
            messageTextBox.Multiline = true;
            messageTextBox.Name = "messageTextBox";
            messageTextBox.ReadOnly = true;
            messageTextBox.Size = new Size(206, 18);
            messageTextBox.TabIndex = 2;
            messageTextBox.TextChanged += messageTextBox_TextChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(nameLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(messageTextBox, 0, 1);
            tableLayoutPanel1.Controls.Add(dateLabel, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(210, 54);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // dateLabel
            // 
            dateLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            dateLabel.Font = new Font("Segoe UI", 7F);
            dateLabel.ForeColor = Color.LightGray;
            dateLabel.Location = new Point(175, 37);
            dateLabel.Margin = new Padding(2, 0, 2, 0);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(33, 20);
            dateLabel.TabIndex = 0;
            dateLabel.Text = "date";
            // 
            // messageControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(2);
            MinimumSize = new Size(140, 54);
            Name = "messageControl";
            Size = new Size(210, 54);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label nameLabel;
        private TextBox messageTextBox;
        private TableLayoutPanel tableLayoutPanel1;
        private Label dateLabel;
    }
}
