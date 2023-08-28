namespace Marwin.UI.Views.Employee
{
    partial class EmployeeUpdateView
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
            this.ThirdNameText = new System.Windows.Forms.TextBox();
            this.ThirdName = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.TINText = new System.Windows.Forms.TextBox();
            this.FirstNameText = new System.Windows.Forms.TextBox();
            this.LastNameText = new System.Windows.Forms.TextBox();
            this.TINLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ThirdNameText
            // 
            this.ThirdNameText.Location = new System.Drawing.Point(245, 162);
            this.ThirdNameText.Name = "ThirdNameText";
            this.ThirdNameText.Size = new System.Drawing.Size(284, 22);
            this.ThirdNameText.TabIndex = 34;
            // 
            // ThirdName
            // 
            this.ThirdName.AutoSize = true;
            this.ThirdName.Location = new System.Drawing.Point(12, 168);
            this.ThirdName.Name = "ThirdName";
            this.ThirdName.Size = new System.Drawing.Size(70, 16);
            this.ThirdName.TabIndex = 33;
            this.ThirdName.Text = "Отчество";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(296, 284);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(102, 57);
            this.CancelButton.TabIndex = 32;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(109, 284);
            this.UpdateButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(102, 57);
            this.UpdateButton.TabIndex = 31;
            this.UpdateButton.Text = "Обновить";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeaderLabel.Location = new System.Drawing.Point(12, 9);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(546, 30);
            this.HeaderLabel.TabIndex = 30;
            this.HeaderLabel.Text = "Обновить сотрудника";
            // 
            // TINText
            // 
            this.TINText.Location = new System.Drawing.Point(246, 213);
            this.TINText.Name = "TINText";
            this.TINText.Size = new System.Drawing.Size(284, 22);
            this.TINText.TabIndex = 29;
            this.TINText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TINText_KeyPress);
            // 
            // FirstNameText
            // 
            this.FirstNameText.Location = new System.Drawing.Point(246, 113);
            this.FirstNameText.Name = "FirstNameText";
            this.FirstNameText.Size = new System.Drawing.Size(284, 22);
            this.FirstNameText.TabIndex = 28;
            // 
            // LastNameText
            // 
            this.LastNameText.Location = new System.Drawing.Point(246, 60);
            this.LastNameText.Name = "LastNameText";
            this.LastNameText.Size = new System.Drawing.Size(284, 22);
            this.LastNameText.TabIndex = 27;
            // 
            // TINLabel
            // 
            this.TINLabel.AutoSize = true;
            this.TINLabel.Location = new System.Drawing.Point(13, 219);
            this.TINLabel.Name = "TINLabel";
            this.TINLabel.Size = new System.Drawing.Size(37, 16);
            this.TINLabel.TabIndex = 26;
            this.TINLabel.Text = "ИИН";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(13, 119);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(33, 16);
            this.FirstNameLabel.TabIndex = 25;
            this.FirstNameLabel.Text = "Имя";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(13, 60);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(66, 16);
            this.LastNameLabel.TabIndex = 24;
            this.LastNameLabel.Text = "Фамилия";
            // 
            // EmployeeUpdateView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(548, 365);
            this.ControlBox = false;
            this.Controls.Add(this.ThirdNameText);
            this.Controls.Add(this.ThirdName);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.HeaderLabel);
            this.Controls.Add(this.TINText);
            this.Controls.Add(this.FirstNameText);
            this.Controls.Add(this.LastNameText);
            this.Controls.Add(this.TINLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.LastNameLabel);
            this.Name = "EmployeeUpdateView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Обновить сотрудника";
            this.Load += new System.EventHandler(this.EmployeeUpdateView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ThirdNameText;
        private System.Windows.Forms.Label ThirdName;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.TextBox TINText;
        private System.Windows.Forms.TextBox FirstNameText;
        private System.Windows.Forms.TextBox LastNameText;
        private System.Windows.Forms.Label TINLabel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label LastNameLabel;
    }
}