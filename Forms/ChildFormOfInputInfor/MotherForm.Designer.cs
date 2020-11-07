namespace ScholarshipManagement.Forms.ChildFormOfInputInfor
{
    partial class MotherForm
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
            this.MotherPhoneTextBox = new System.Windows.Forms.TextBox();
            this.MotherNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MotherPhoneTextBox
            // 
            this.MotherPhoneTextBox.Font = new System.Drawing.Font("Fira Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MotherPhoneTextBox.Location = new System.Drawing.Point(369, 37);
            this.MotherPhoneTextBox.Name = "MotherPhoneTextBox";
            this.MotherPhoneTextBox.Size = new System.Drawing.Size(335, 31);
            this.MotherPhoneTextBox.TabIndex = 4;
            // 
            // MotherNameTextBox
            // 
            this.MotherNameTextBox.Font = new System.Drawing.Font("Fira Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MotherNameTextBox.Location = new System.Drawing.Point(14, 37);
            this.MotherNameTextBox.Name = "MotherNameTextBox";
            this.MotherNameTextBox.Size = new System.Drawing.Size(335, 31);
            this.MotherNameTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Fira Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(365, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số điện thoại mẹ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Fira Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Họ và tên mẹ";
            // 
            // MotherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(714, 154);
            this.Controls.Add(this.MotherPhoneTextBox);
            this.Controls.Add(this.MotherNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MotherForm";
            this.Text = "MotherForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MotherPhoneTextBox;
        private System.Windows.Forms.TextBox MotherNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}