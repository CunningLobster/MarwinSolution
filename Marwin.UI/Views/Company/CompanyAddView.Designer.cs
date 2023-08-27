namespace Marwin.UI.Views.Company
{
    partial class CompanyAddView
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
            this.CompanyNameLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.NoteLabel = new System.Windows.Forms.Label();
            this.BINLabel = new System.Windows.Forms.Label();
            this.CompanyNameText = new System.Windows.Forms.TextBox();
            this.AddressText = new System.Windows.Forms.TextBox();
            this.BINText = new System.Windows.Forms.TextBox();
            this.NoteText = new System.Windows.Forms.TextBox();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CompanyNameLabel
            // 
            this.CompanyNameLabel.AutoSize = true;
            this.CompanyNameLabel.Location = new System.Drawing.Point(12, 69);
            this.CompanyNameLabel.Name = "CompanyNameLabel";
            this.CompanyNameLabel.Size = new System.Drawing.Size(173, 16);
            this.CompanyNameLabel.TabIndex = 0;
            this.CompanyNameLabel.Text = "Наименование компании";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(12, 128);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(47, 16);
            this.AddressLabel.TabIndex = 1;
            this.AddressLabel.Text = "Адрес";
            // 
            // NoteLabel
            // 
            this.NoteLabel.AutoSize = true;
            this.NoteLabel.Location = new System.Drawing.Point(12, 253);
            this.NoteLabel.Name = "NoteLabel";
            this.NoteLabel.Size = new System.Drawing.Size(90, 16);
            this.NoteLabel.TabIndex = 2;
            this.NoteLabel.Text = "Примечание";
            // 
            // BINLabel
            // 
            this.BINLabel.AutoSize = true;
            this.BINLabel.Location = new System.Drawing.Point(12, 186);
            this.BINLabel.Name = "BINLabel";
            this.BINLabel.Size = new System.Drawing.Size(36, 16);
            this.BINLabel.TabIndex = 3;
            this.BINLabel.Text = "БИН";
            // 
            // CompanyNameText
            // 
            this.CompanyNameText.Location = new System.Drawing.Point(245, 69);
            this.CompanyNameText.Name = "CompanyNameText";
            this.CompanyNameText.Size = new System.Drawing.Size(284, 22);
            this.CompanyNameText.TabIndex = 4;
            // 
            // AddressText
            // 
            this.AddressText.Location = new System.Drawing.Point(245, 122);
            this.AddressText.Name = "AddressText";
            this.AddressText.Size = new System.Drawing.Size(284, 22);
            this.AddressText.TabIndex = 5;
            // 
            // BINText
            // 
            this.BINText.Location = new System.Drawing.Point(245, 180);
            this.BINText.Name = "BINText";
            this.BINText.Size = new System.Drawing.Size(284, 22);
            this.BINText.TabIndex = 6;
            // 
            // NoteText
            // 
            this.NoteText.Location = new System.Drawing.Point(245, 250);
            this.NoteText.Multiline = true;
            this.NoteText.Name = "NoteText";
            this.NoteText.Size = new System.Drawing.Size(284, 96);
            this.NoteText.TabIndex = 7;
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeaderLabel.Location = new System.Drawing.Point(11, 18);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(546, 30);
            this.HeaderLabel.TabIndex = 8;
            this.HeaderLabel.Text = "Добавить новую компанию";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(117, 369);
            this.AddButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(102, 57);
            this.AddButton.TabIndex = 9;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(304, 369);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(102, 57);
            this.CancelButton.TabIndex = 10;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // CompanyAddView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(551, 450);
            this.ControlBox = false;
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.HeaderLabel);
            this.Controls.Add(this.NoteText);
            this.Controls.Add(this.BINText);
            this.Controls.Add(this.AddressText);
            this.Controls.Add(this.CompanyNameText);
            this.Controls.Add(this.BINLabel);
            this.Controls.Add(this.NoteLabel);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.CompanyNameLabel);
            this.Name = "CompanyAddView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавить компанию";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CompanyAddView_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CompanyNameLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label NoteLabel;
        private System.Windows.Forms.Label BINLabel;
        private System.Windows.Forms.TextBox CompanyNameText;
        private System.Windows.Forms.TextBox AddressText;
        private System.Windows.Forms.TextBox BINText;
        private System.Windows.Forms.TextBox NoteText;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button CancelButton;
    }
}