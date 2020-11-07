namespace ScholarshipManagement.Forms
{
    partial class ChildrenManagementForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.FillterButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ChildrentDataGridView = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ChildFormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChildrentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ChildFormPanel
            // 
            this.ChildFormPanel.Controls.Add(this.label1);
            this.ChildFormPanel.Controls.Add(this.AddButton);
            this.ChildFormPanel.Controls.Add(this.FillterButton);
            this.ChildFormPanel.Controls.Add(this.SearchButton);
            this.ChildFormPanel.Controls.Add(this.ChildrentDataGridView);
            this.ChildFormPanel.Controls.Add(this.textBox1);
            this.ChildFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChildFormPanel.Location = new System.Drawing.Point(0, 0);
            this.ChildFormPanel.Name = "ChildFormPanel";
            this.ChildFormPanel.Size = new System.Drawing.Size(1008, 595);
            this.ChildFormPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Fira Sans", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 28);
            this.label1.TabIndex = 9;
            this.label1.Text = "Danh sách trẻ em";
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(11)))));
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Fira Sans", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(864, 36);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(143, 35);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "Thêm";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // FillterButton
            // 
            this.FillterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(86)))), ((int)(((byte)(7)))));
            this.FillterButton.FlatAppearance.BorderSize = 0;
            this.FillterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FillterButton.Font = new System.Drawing.Font("Fira Sans", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FillterButton.Location = new System.Drawing.Point(686, 36);
            this.FillterButton.Name = "FillterButton";
            this.FillterButton.Size = new System.Drawing.Size(143, 35);
            this.FillterButton.TabIndex = 7;
            this.FillterButton.Text = "Lọc";
            this.FillterButton.UseVisualStyleBackColor = false;
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(110)))));
            this.SearchButton.FlatAppearance.BorderSize = 0;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Font = new System.Drawing.Font("Fira Sans", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(508, 36);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(143, 35);
            this.SearchButton.TabIndex = 8;
            this.SearchButton.Text = "Tìm kiếm";
            this.SearchButton.UseVisualStyleBackColor = false;
            // 
            // ChildrentDataGridView
            // 
            this.ChildrentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ChildrentDataGridView.Location = new System.Drawing.Point(23, 127);
            this.ChildrentDataGridView.Name = "ChildrentDataGridView";
            this.ChildrentDataGridView.RowHeadersWidth = 51;
            this.ChildrentDataGridView.RowTemplate.Height = 24;
            this.ChildrentDataGridView.Size = new System.Drawing.Size(985, 456);
            this.ChildrentDataGridView.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Fira Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(23, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(474, 35);
            this.textBox1.TabIndex = 4;
            // 
            // ChildrenManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 595);
            this.Controls.Add(this.ChildFormPanel);
            this.Font = new System.Drawing.Font("Fira Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ChildrenManagementForm";
            this.Text = "Quản lý trẻ em";
            this.ChildFormPanel.ResumeLayout(false);
            this.ChildFormPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChildrentDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ChildFormPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button FillterButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.DataGridView ChildrentDataGridView;
        private System.Windows.Forms.TextBox textBox1;
    }
}