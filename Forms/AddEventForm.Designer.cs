namespace ScholarshipManagement.Forms
{
    partial class AddEventForm
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
            this.DektopPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CancelButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.SaveButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.IdProgramTextBox = new System.Windows.Forms.TextBox();
            this.ReleaseDateDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.DateOfReceiptdateTime = new System.Windows.Forms.DateTimePicker();
            this.DektopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DektopPanel
            // 
            this.DektopPanel.Controls.Add(this.label1);
            this.DektopPanel.Controls.Add(this.label10);
            this.DektopPanel.Controls.Add(this.label9);
            this.DektopPanel.Controls.Add(this.label8);
            this.DektopPanel.Controls.Add(this.CancelButton);
            this.DektopPanel.Controls.Add(this.SaveButton);
            this.DektopPanel.Controls.Add(this.IdProgramTextBox);
            this.DektopPanel.Controls.Add(this.ReleaseDateDateTimePicker1);
            this.DektopPanel.Controls.Add(this.DateOfReceiptdateTime);
            this.DektopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DektopPanel.Location = new System.Drawing.Point(0, 0);
            this.DektopPanel.Name = "DektopPanel";
            this.DektopPanel.Size = new System.Drawing.Size(1008, 595);
            this.DektopPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Fira Sans", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(59)))));
            this.label1.Location = new System.Drawing.Point(276, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(529, 56);
            this.label1.TabIndex = 35;
            this.label1.Text = "Thông Tin Chương Trình";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Fira Sans", 13.8F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(44, 345);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(170, 28);
            this.label10.TabIndex = 32;
            this.label10.Text = "Ngày phát tiền:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Fira Sans", 13.8F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(44, 266);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(173, 28);
            this.label9.TabIndex = 33;
            this.label9.Text = "Ngày nhận tiền:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Fira Sans", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(44, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(217, 28);
            this.label8.TabIndex = 34;
            this.label8.Text = "Mã số chương trình:";
            // 
            // CancelButton
            // 
            this.CancelButton.AutoSize = true;
            this.CancelButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton.Depth = 0;
            this.CancelButton.Icon = null;
            this.CancelButton.Location = new System.Drawing.Point(851, 478);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CancelButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Primary = false;
            this.CancelButton.Size = new System.Drawing.Size(83, 36);
            this.CancelButton.TabIndex = 30;
            this.CancelButton.Text = "Hủy Bỏ";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.AutoSize = true;
            this.SaveButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SaveButton.Depth = 0;
            this.SaveButton.Font = new System.Drawing.Font("Fira Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Icon = null;
            this.SaveButton.Location = new System.Drawing.Point(731, 478);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SaveButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Primary = false;
            this.SaveButton.Size = new System.Drawing.Size(55, 36);
            this.SaveButton.TabIndex = 31;
            this.SaveButton.Text = "Lưu";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // IdProgramTextBox
            // 
            this.IdProgramTextBox.Font = new System.Drawing.Font("Fira Sans", 14.25F);
            this.IdProgramTextBox.Location = new System.Drawing.Point(318, 190);
            this.IdProgramTextBox.Name = "IdProgramTextBox";
            this.IdProgramTextBox.Size = new System.Drawing.Size(663, 36);
            this.IdProgramTextBox.TabIndex = 29;
            // 
            // ReleaseDateDateTimePicker1
            // 
            this.ReleaseDateDateTimePicker1.CustomFormat = "  dd/MM/yyyy";
            this.ReleaseDateDateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReleaseDateDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ReleaseDateDateTimePicker1.Location = new System.Drawing.Point(318, 266);
            this.ReleaseDateDateTimePicker1.Name = "ReleaseDateDateTimePicker1";
            this.ReleaseDateDateTimePicker1.Size = new System.Drawing.Size(663, 39);
            this.ReleaseDateDateTimePicker1.TabIndex = 27;
            // 
            // DateOfReceiptdateTime
            // 
            this.DateOfReceiptdateTime.CustomFormat = "  dd/MM/yyyy";
            this.DateOfReceiptdateTime.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateOfReceiptdateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateOfReceiptdateTime.Location = new System.Drawing.Point(318, 345);
            this.DateOfReceiptdateTime.Name = "DateOfReceiptdateTime";
            this.DateOfReceiptdateTime.Size = new System.Drawing.Size(663, 39);
            this.DateOfReceiptdateTime.TabIndex = 28;
            // 
            // AddEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 595);
            this.Controls.Add(this.DektopPanel);
            this.Name = "AddEventForm";
            this.Text = "AddEventForm";
            this.DektopPanel.ResumeLayout(false);
            this.DektopPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DektopPanel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private MaterialSkin.Controls.MaterialFlatButton CancelButton;
        private MaterialSkin.Controls.MaterialFlatButton SaveButton;
        private System.Windows.Forms.TextBox IdProgramTextBox;
        private System.Windows.Forms.DateTimePicker ReleaseDateDateTimePicker1;
        private System.Windows.Forms.DateTimePicker DateOfReceiptdateTime;
        private System.Windows.Forms.Label label1;
    }
}