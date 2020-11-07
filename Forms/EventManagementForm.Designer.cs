namespace ScholarshipManagement.Forms
{
    partial class EventManagementForm
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
            this.components = new System.ComponentModel.Container();
            this.ChildFormPanel = new System.Windows.Forms.Panel();
            this.FilterButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddProgramButton = new System.Windows.Forms.Button();
            this.ProgramDatabaseGirdView = new System.Windows.Forms.DataGridView();
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maSoChuongTrinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayNhanTienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayPhatTienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActionSeeButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ActionEditButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ActionDeleteButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ChildFormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProgramDatabaseGirdView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ChildFormPanel
            // 
            this.ChildFormPanel.Controls.Add(this.FilterButton);
            this.ChildFormPanel.Controls.Add(this.SearchButton);
            this.ChildFormPanel.Controls.Add(this.SearchTextBox);
            this.ChildFormPanel.Controls.Add(this.label1);
            this.ChildFormPanel.Controls.Add(this.AddProgramButton);
            this.ChildFormPanel.Controls.Add(this.ProgramDatabaseGirdView);
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
            this.SearchTextBox.Size = new System.Drawing.Size(524, 35);
            this.SearchTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Fira Sans", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(59)))));
            this.label1.Location = new System.Drawing.Point(12, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 28);
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
            // ProgramDatabaseGirdView
            // 
            this.ProgramDatabaseGirdView.AutoGenerateColumns = false;
            this.ProgramDatabaseGirdView.BackgroundColor = System.Drawing.Color.Silver;
            this.ProgramDatabaseGirdView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProgramDatabaseGirdView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProgramDatabaseGirdView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSoChuongTrinhDataGridViewTextBoxColumn,
            this.ngayNhanTienDataGridViewTextBoxColumn,
            this.ngayPhatTienDataGridViewTextBoxColumn,
            this.ActionSeeButton,
            this.ActionEditButton,
            this.ActionDeleteButton});
            this.ProgramDatabaseGirdView.DataSource = this.programBindingSource;
            this.ProgramDatabaseGirdView.GridColor = System.Drawing.Color.White;
            this.ProgramDatabaseGirdView.Location = new System.Drawing.Point(17, 148);
            this.ProgramDatabaseGirdView.Name = "ProgramDatabaseGirdView";
            this.ProgramDatabaseGirdView.RowHeadersWidth = 51;
            this.ProgramDatabaseGirdView.RowTemplate.Height = 24;
            this.ProgramDatabaseGirdView.Size = new System.Drawing.Size(979, 435);
            this.ProgramDatabaseGirdView.TabIndex = 0;
            this.ProgramDatabaseGirdView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProgramDatabaseGirdView_CellContentClick);
            // 
            // programBindingSource
            // 
            this.programBindingSource.DataSource = typeof(ScholarshipManagement.Models.Program);
            // 
            // maSoChuongTrinhDataGridViewTextBoxColumn
            // 
            this.maSoChuongTrinhDataGridViewTextBoxColumn.DataPropertyName = "MaSoChuongTrinh";
            this.maSoChuongTrinhDataGridViewTextBoxColumn.HeaderText = "Mã Số Chương Trình";
            this.maSoChuongTrinhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maSoChuongTrinhDataGridViewTextBoxColumn.Name = "maSoChuongTrinhDataGridViewTextBoxColumn";
            this.maSoChuongTrinhDataGridViewTextBoxColumn.Width = 160;
            // 
            // ngayNhanTienDataGridViewTextBoxColumn
            // 
            this.ngayNhanTienDataGridViewTextBoxColumn.DataPropertyName = "NgayNhanTien";
            this.ngayNhanTienDataGridViewTextBoxColumn.HeaderText = "Ngày Nhận Tiền";
            this.ngayNhanTienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayNhanTienDataGridViewTextBoxColumn.Name = "ngayNhanTienDataGridViewTextBoxColumn";
            this.ngayNhanTienDataGridViewTextBoxColumn.Width = 200;
            // 
            // ngayPhatTienDataGridViewTextBoxColumn
            // 
            this.ngayPhatTienDataGridViewTextBoxColumn.DataPropertyName = "NgayPhatTien";
            this.ngayPhatTienDataGridViewTextBoxColumn.HeaderText = "Ngày Nhận Tiền";
            this.ngayPhatTienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayPhatTienDataGridViewTextBoxColumn.Name = "ngayPhatTienDataGridViewTextBoxColumn";
            this.ngayPhatTienDataGridViewTextBoxColumn.Width = 200;
            // 
            // ActionSeeButton
            // 
            this.ActionSeeButton.HeaderText = "";
            this.ActionSeeButton.MinimumWidth = 6;
            this.ActionSeeButton.Name = "ActionSeeButton";
            this.ActionSeeButton.Text = "Xem";
            this.ActionSeeButton.UseColumnTextForButtonValue = true;
            this.ActionSeeButton.Width = 125;
            // 
            // ActionEditButton
            // 
            this.ActionEditButton.HeaderText = "";
            this.ActionEditButton.MinimumWidth = 6;
            this.ActionEditButton.Name = "ActionEditButton";
            this.ActionEditButton.Text = "Sửa";
            this.ActionEditButton.UseColumnTextForButtonValue = true;
            this.ActionEditButton.Width = 125;
            // 
            // ActionDeleteButton
            // 
            this.ActionDeleteButton.HeaderText = "";
            this.ActionDeleteButton.MinimumWidth = 6;
            this.ActionDeleteButton.Name = "ActionDeleteButton";
            this.ActionDeleteButton.Text = "Xoá";
            this.ActionDeleteButton.UseColumnTextForButtonValue = true;
            this.ActionDeleteButton.Width = 125;
            // 
            // EventManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 595);
            this.Controls.Add(this.ChildFormPanel);
            this.Font = new System.Drawing.Font("Fira Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "EventManagementForm";
            this.Text = "Quản lý chương trình";
            this.Load += new System.EventHandler(this.EventManagementForm_Load);
            this.ChildFormPanel.ResumeLayout(false);
            this.ChildFormPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProgramDatabaseGirdView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel ChildFormPanel;
        private System.Windows.Forms.DataGridView ProgramDatabaseGirdView;
        private System.Windows.Forms.BindingSource programBindingSource;
        private System.Windows.Forms.Button AddProgramButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button FilterButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSoChuongTrinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayNhanTienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayPhatTienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn ActionSeeButton;
        private System.Windows.Forms.DataGridViewButtonColumn ActionEditButton;
        private System.Windows.Forms.DataGridViewButtonColumn ActionDeleteButton;
    }
}