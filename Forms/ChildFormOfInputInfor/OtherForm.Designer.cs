namespace ScholarshipManagement.Forms.ChildFormOfInputInfor
{
    partial class OtherForm
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
            this.OtherPhoneTextBox = new System.Windows.Forms.TextBox();
            this.OtherNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OtherPhoneTextBox
            // 
            this.OtherPhoneTextBox.Font = new System.Drawing.Font("Fira Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OtherPhoneTextBox.Location = new System.Drawing.Point(369, 37);
            this.OtherPhoneTextBox.Name = "OtherPhoneTextBox";
            this.OtherPhoneTextBox.Size = new System.Drawing.Size(335, 31);
            this.OtherPhoneTextBox.TabIndex = 12;
            // 
            // OtherNameTextBox
            // 
            this.OtherNameTextBox.Font = new System.Drawing.Font("Fira Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OtherNameTextBox.Location = new System.Drawing.Point(14, 37);
            this.OtherNameTextBox.Name = "OtherNameTextBox";
            this.OtherNameTextBox.Size = new System.Drawing.Size(335, 31);
            this.OtherNameTextBox.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Fira Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(365, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Số điện thoại người giám hộ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Fira Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Họ và tên người giám hộ";
            // 
            // OtherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(714, 154);
            this.Controls.Add(this.OtherPhoneTextBox);
            this.Controls.Add(this.OtherNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OtherForm";
            this.Text = "OtherForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox OtherPhoneTextBox;
        private System.Windows.Forms.TextBox OtherNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}