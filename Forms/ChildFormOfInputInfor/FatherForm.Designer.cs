namespace ScholarshipManagement.Forms.ChildFormOfInputInfor
{
    partial class FatherForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.FatherNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FatherPhoneTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Fira Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ và tên bố";
            // 
            // FatherNameTextBox
            // 
            this.FatherNameTextBox.Font = new System.Drawing.Font("Fira Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FatherNameTextBox.Location = new System.Drawing.Point(14, 37);
            this.FatherNameTextBox.Name = "FatherNameTextBox";
            this.FatherNameTextBox.Size = new System.Drawing.Size(335, 31);
            this.FatherNameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Fira Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(365, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số điện thoại bố";
            // 
            // FatherPhoneTextBox
            // 
            this.FatherPhoneTextBox.Font = new System.Drawing.Font("Fira Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FatherPhoneTextBox.Location = new System.Drawing.Point(369, 37);
            this.FatherPhoneTextBox.Name = "FatherPhoneTextBox";
            this.FatherPhoneTextBox.Size = new System.Drawing.Size(335, 31);
            this.FatherPhoneTextBox.TabIndex = 1;
            // 
            // FatherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(714, 154);
            this.Controls.Add(this.FatherPhoneTextBox);
            this.Controls.Add(this.FatherNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FatherForm";
            this.Text = "FatherForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FatherNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FatherPhoneTextBox;
    }
}