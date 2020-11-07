namespace ScholarshipManagement.Forms
{
    partial class AddEventDetailsForm
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
            this.EventDetailPanel = new System.Windows.Forms.Panel();
            this.DetailedInformationPanel = new System.Windows.Forms.Panel();
            this.SignatureInsteadPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UploadButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.LoadButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ClassTextBox = new System.Windows.Forms.TextBox();
            this.CancelButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.SaveButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.EventDetailPanel.SuspendLayout();
            this.DetailedInformationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SignatureInsteadPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // EventDetailPanel
            // 
            this.EventDetailPanel.Controls.Add(this.DetailedInformationPanel);
            this.EventDetailPanel.Controls.Add(this.CancelButton);
            this.EventDetailPanel.Controls.Add(this.SaveButton);
            this.EventDetailPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EventDetailPanel.Location = new System.Drawing.Point(0, 0);
            this.EventDetailPanel.Name = "EventDetailPanel";
            this.EventDetailPanel.Size = new System.Drawing.Size(1008, 595);
            this.EventDetailPanel.TabIndex = 0;
            // 
            // DetailedInformationPanel
            // 
            this.DetailedInformationPanel.BackColor = System.Drawing.Color.White;
            this.DetailedInformationPanel.Controls.Add(this.SignatureInsteadPictureBox);
            this.DetailedInformationPanel.Controls.Add(this.pictureBox1);
            this.DetailedInformationPanel.Controls.Add(this.panel3);
            this.DetailedInformationPanel.Controls.Add(this.label6);
            this.DetailedInformationPanel.Controls.Add(this.label5);
            this.DetailedInformationPanel.Controls.Add(this.label4);
            this.DetailedInformationPanel.Controls.Add(this.label3);
            this.DetailedInformationPanel.Controls.Add(this.UploadButton);
            this.DetailedInformationPanel.Controls.Add(this.LoadButton);
            this.DetailedInformationPanel.Controls.Add(this.textBox2);
            this.DetailedInformationPanel.Controls.Add(this.ClassTextBox);
            this.DetailedInformationPanel.Location = new System.Drawing.Point(17, 29);
            this.DetailedInformationPanel.Name = "DetailedInformationPanel";
            this.DetailedInformationPanel.Size = new System.Drawing.Size(974, 450);
            this.DetailedInformationPanel.TabIndex = 31;
            // 
            // SignatureInsteadPictureBox
            // 
            this.SignatureInsteadPictureBox.Location = new System.Drawing.Point(235, 238);
            this.SignatureInsteadPictureBox.Name = "SignatureInsteadPictureBox";
            this.SignatureInsteadPictureBox.Size = new System.Drawing.Size(147, 130);
            this.SignatureInsteadPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SignatureInsteadPictureBox.TabIndex = 39;
            this.SignatureInsteadPictureBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(27, 238);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(181)))), ((int)(((byte)(189)))));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(974, 40);
            this.panel3.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Fira Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "Chi Tiết Thông Tin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Fira Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 24);
            this.label6.TabIndex = 31;
            this.label6.Text = "Lớp:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Fira Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 24);
            this.label5.TabIndex = 32;
            this.label5.Text = "Tiền nhận 3 tháng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Fira Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 24);
            this.label4.TabIndex = 33;
            this.label4.Text = "Chữ ký xác nhận:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Fira Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(231, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 24);
            this.label3.TabIndex = 34;
            this.label3.Text = "Chữ ký thay:";
            // 
            // UploadButton
            // 
            this.UploadButton.AutoSize = true;
            this.UploadButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UploadButton.Depth = 0;
            this.UploadButton.Icon = null;
            this.UploadButton.Location = new System.Drawing.Point(30, 377);
            this.UploadButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.UploadButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.UploadButton.Name = "UploadButton";
            this.UploadButton.Primary = false;
            this.UploadButton.Size = new System.Drawing.Size(100, 36);
            this.UploadButton.TabIndex = 29;
            this.UploadButton.Text = "Đăng Tải";
            this.UploadButton.UseVisualStyleBackColor = true;
            this.UploadButton.Click += new System.EventHandler(this.UploadButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.AutoSize = true;
            this.LoadButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LoadButton.Depth = 0;
            this.LoadButton.Icon = null;
            this.LoadButton.Location = new System.Drawing.Point(235, 377);
            this.LoadButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.LoadButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Primary = false;
            this.LoadButton.Size = new System.Drawing.Size(100, 36);
            this.LoadButton.TabIndex = 28;
            this.LoadButton.Text = "Đăng Tải";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Fira Sans", 14.25F);
            this.textBox2.Location = new System.Drawing.Point(249, 129);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(658, 36);
            this.textBox2.TabIndex = 27;
            // 
            // ClassTextBox
            // 
            this.ClassTextBox.Font = new System.Drawing.Font("Fira Sans", 14.25F);
            this.ClassTextBox.Location = new System.Drawing.Point(249, 77);
            this.ClassTextBox.Name = "ClassTextBox";
            this.ClassTextBox.Size = new System.Drawing.Size(658, 36);
            this.ClassTextBox.TabIndex = 26;
            // 
            // CancelButton
            // 
            this.CancelButton.AutoSize = true;
            this.CancelButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton.Depth = 0;
            this.CancelButton.Icon = null;
            this.CancelButton.Location = new System.Drawing.Point(908, 529);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CancelButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Primary = false;
            this.CancelButton.Size = new System.Drawing.Size(83, 36);
            this.CancelButton.TabIndex = 30;
            this.CancelButton.Text = "Hủy Bỏ";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click_1);
            // 
            // SaveButton
            // 
            this.SaveButton.AutoSize = true;
            this.SaveButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SaveButton.Depth = 0;
            this.SaveButton.Font = new System.Drawing.Font("Fira Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Icon = null;
            this.SaveButton.Location = new System.Drawing.Point(813, 529);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SaveButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Primary = false;
            this.SaveButton.Size = new System.Drawing.Size(55, 36);
            this.SaveButton.TabIndex = 29;
            this.SaveButton.Text = "Lưu";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // AddEventDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 595);
            this.Controls.Add(this.EventDetailPanel);
            this.Name = "AddEventDetailsForm";
            this.Text = "AddEventDetailsForm";
            this.EventDetailPanel.ResumeLayout(false);
            this.EventDetailPanel.PerformLayout();
            this.DetailedInformationPanel.ResumeLayout(false);
            this.DetailedInformationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SignatureInsteadPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel EventDetailPanel;
        private System.Windows.Forms.Panel DetailedInformationPanel;
        private System.Windows.Forms.PictureBox SignatureInsteadPictureBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialFlatButton UploadButton;
        private MaterialSkin.Controls.MaterialFlatButton LoadButton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox ClassTextBox;
        private MaterialSkin.Controls.MaterialFlatButton CancelButton;
        private MaterialSkin.Controls.MaterialFlatButton SaveButton;
    }
}