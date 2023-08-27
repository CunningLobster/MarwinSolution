namespace Marwin.UI.Views.Company
{
    partial class CompanyUpdateView
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
            this.CancelButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.NoteText = new System.Windows.Forms.TextBox();
            this.BINText = new System.Windows.Forms.TextBox();
            this.AddressText = new System.Windows.Forms.TextBox();
            this.CompanyNameText = new System.Windows.Forms.TextBox();
            this.BINLabel = new System.Windows.Forms.Label();
            this.NoteLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.CompanyNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(305, 372);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(102, 57);
            this.CancelButton.TabIndex = 21;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(118, 372);
            this.UpdateButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(102, 57);
            this.UpdateButton.TabIndex = 20;
            this.UpdateButton.Text = "Обновить";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeaderLabel.Location = new System.Drawing.Point(12, 9);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(546, 48);
            this.HeaderLabel.TabIndex = 19;
            this.HeaderLabel.Text = "Обновить компанию";
            // 
            // NoteText
            // 
            this.NoteText.Location = new System.Drawing.Point(246, 253);
            this.NoteText.Multiline = true;
            this.NoteText.Name = "NoteText";
            this.NoteText.Size = new System.Drawing.Size(284, 96);
            this.NoteText.TabIndex = 18;
            // 
            // BINText
            // 
            this.BINText.Location = new System.Drawing.Point(246, 183);
            this.BINText.Name = "BINText";
            this.BINText.Size = new System.Drawing.Size(284, 22);
            this.BINText.TabIndex = 17;
            // 
            // AddressText
            // 
            this.AddressText.Location = new System.Drawing.Point(246, 125);
            this.AddressText.Name = "AddressText";
            this.AddressText.Size = new System.Drawing.Size(284, 22);
            this.AddressText.TabIndex = 16;
            // 
            // CompanyNameText
            // 
            this.CompanyNameText.Location = new System.Drawing.Point(246, 72);
            this.CompanyNameText.Name = "CompanyNameText";
            this.CompanyNameText.Size = new System.Drawing.Size(284, 22);
            this.CompanyNameText.TabIndex = 15;
            // 
            // BINLabel
            // 
            this.BINLabel.AutoSize = true;
            this.BINLabel.Location = new System.Drawing.Point(13, 189);
            this.BINLabel.Name = "BINLabel";
            this.BINLabel.Size = new System.Drawing.Size(36, 16);
            this.BINLabel.TabIndex = 14;
            this.BINLabel.Text = "БИН";
            // 
            // NoteLabel
            // 
            this.NoteLabel.AutoSize = true;
            this.NoteLabel.Location = new System.Drawing.Point(13, 256);
            this.NoteLabel.Name = "NoteLabel";
            this.NoteLabel.Size = new System.Drawing.Size(90, 16);
            this.NoteLabel.TabIndex = 13;
            this.NoteLabel.Text = "Примечание";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(13, 131);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(47, 16);
            this.AddressLabel.TabIndex = 12;
            this.AddressLabel.Text = "Адрес";
            // 
            // CompanyNameLabel
            // 
            this.CompanyNameLabel.AutoSize = true;
            this.CompanyNameLabel.Location = new System.Drawing.Point(13, 72);
            this.CompanyNameLabel.Name = "CompanyNameLabel";
            this.CompanyNameLabel.Size = new System.Drawing.Size(173, 16);
            this.CompanyNameLabel.TabIndex = 11;
            this.CompanyNameLabel.Text = "Наименование компании";
            // 
            // CompanyUpdateView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(558, 450);
            this.ControlBox = false;
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.HeaderLabel);
            this.Controls.Add(this.NoteText);
            this.Controls.Add(this.BINText);
            this.Controls.Add(this.AddressText);
            this.Controls.Add(this.CompanyNameText);
            this.Controls.Add(this.BINLabel);
            this.Controls.Add(this.NoteLabel);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.CompanyNameLabel);
            this.Name = "CompanyUpdateView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Обновить Компанию";
            this.Load += new System.EventHandler(this.CompanyUpdateView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.TextBox NoteText;
        private System.Windows.Forms.TextBox BINText;
        private System.Windows.Forms.TextBox AddressText;
        private System.Windows.Forms.TextBox CompanyNameText;
        private System.Windows.Forms.Label BINLabel;
        private System.Windows.Forms.Label NoteLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label CompanyNameLabel;
    }
}