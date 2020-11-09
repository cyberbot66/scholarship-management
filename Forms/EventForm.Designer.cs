namespace ScholarshipManagement.Forms
{
    partial class EventForm
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
            this.ChildFormPanel = new System.Windows.Forms.Panel();
            this.FilterButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddProgramButton = new System.Windows.Forms.Button();
            this.ChildFormPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChildFormPanel
            // 
            this.ChildFormPanel.Controls.Add(this.FilterButton);
            this.ChildFormPanel.Controls.Add(this.SearchButton);
            this.ChildFormPanel.Controls.Add(this.SearchTextBox);
            this.ChildFormPanel.Controls.Add(this.label1);
            this.ChildFormPanel.Controls.Add(this.AddProgramButton);
            this.ChildFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChildFormPanel.Location = new System.Drawing.Point(0, 0);
            this.ChildFormPanel.Name = "ChildFormPanel";
            this.ChildFormPanel.Size = new System.Drawing.Size(1008, 595);
            this.ChildFormPanel.TabIndex = 11;
            // 
            // FilterButton
            // 
            this.FilterButton.AutoSize = true;
            this.FilterButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.FilterButton.FlatAppearance.BorderSize = 0;
            this.FilterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilterButton.Location = new System.Drawing.Point(698, 37);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(98, 36);
            this.FilterButton.TabIndex = 7;
            this.FilterButton.Text = "Lọc";
            this.FilterButton.UseVisualStyleBackColor = false;
            // 
            // SearchButton
            // 
            this.SearchButton.AutoSize = true;
            this.SearchButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SearchButton.FlatAppearance.BorderSize = 0;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Location = new System.Drawing.Point(561, 37);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(131, 36);
            this.SearchButton.TabIndex = 6;
            this.SearchButton.Text = "Tìm Kiếm";
            this.SearchButton.UseVisualStyleBackColor = false;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Font = new System.Drawing.Font("Fira Sans", 13.8F);
            this.SearchTextBox.Location = new System.Drawing.Point(17, 37);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(524, 30);
            this.SearchTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Fira Sans", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(59)))));
            this.label1.Location = new System.Drawing.Point(12, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Danh sách chương trình";
            // 
            // AddProgramButton
            // 
            this.AddProgramButton.AutoSize = true;
            this.AddProgramButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddProgramButton.FlatAppearance.BorderSize = 0;
            this.AddProgramButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddProgramButton.Location = new System.Drawing.Point(802, 37);
            this.AddProgramButton.Name = "AddProgramButton";
            this.AddProgramButton.Size = new System.Drawing.Size(194, 36);
            this.AddProgramButton.TabIndex = 3;
            this.AddProgramButton.Text = "THÊM CHƯƠNG TRÌNH";
            this.AddProgramButton.UseVisualStyleBackColor = false;
            this.AddProgramButton.Click += new System.EventHandler(this.AddProgramButton_Click);
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 595);
            this.Controls.Add(this.ChildFormPanel);
            this.Font = new System.Drawing.Font("Fira Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "EventForm";
            this.Text = "Quản lý chương trình";
            this.ChildFormPanel.ResumeLayout(false);
            this.ChildFormPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel ChildFormPanel;
        private System.Windows.Forms.Button AddProgramButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button FilterButton;
        private System.Windows.Forms.Button SearchButton;
    }
}