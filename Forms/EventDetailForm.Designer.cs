namespace ScholarshipManagement.Forms
{
    partial class EventDetailForm
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
            this.EventDektopPanel = new System.Windows.Forms.Panel();
            this.AddScholarshipButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.FilterButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ChildrenDataGirdView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.childrenListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maSoChuongTrinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hovaTenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soDienThoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhPHoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songChungVoiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhTrangSucKhoeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThaiHocVanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienNhan3ThangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chuKyXacNhanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chuKyThayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActionDeleteButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ActionEditButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ActionSeeButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EventDektopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChildrenDataGirdView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.childrenListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // EventDektopPanel
            // 
            this.EventDektopPanel.Controls.Add(this.AddScholarshipButton);
            this.EventDektopPanel.Controls.Add(this.SearchTextBox);
            this.EventDektopPanel.Controls.Add(this.FilterButton);
            this.EventDektopPanel.Controls.Add(this.SearchButton);
            this.EventDektopPanel.Controls.Add(this.ChildrenDataGirdView);
            this.EventDektopPanel.Controls.Add(this.label1);
            this.EventDektopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EventDektopPanel.Location = new System.Drawing.Point(0, 0);
            this.EventDektopPanel.Name = "EventDektopPanel";
            this.EventDektopPanel.Size = new System.Drawing.Size(1008, 595);
            this.EventDektopPanel.TabIndex = 0;
            // 
            // AddScholarshipButton
            // 
            this.AddScholarshipButton.AutoSize = true;
            this.AddScholarshipButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddScholarshipButton.FlatAppearance.BorderSize = 0;
            this.AddScholarshipButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddScholarshipButton.Location = new System.Drawing.Point(845, 22);
            this.AddScholarshipButton.Name = "AddScholarshipButton";
            this.AddScholarshipButton.Size = new System.Drawing.Size(151, 36);
            this.AddScholarshipButton.TabIndex = 16;
            this.AddScholarshipButton.Text = "THÊM HỌC BỔNG";
            this.AddScholarshipButton.UseVisualStyleBackColor = false;
            this.AddScholarshipButton.Click += new System.EventHandler(this.AddScholarshipButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Hoàng Long\t",
            "Hoàng Văn",
            "Hoàng Thụy",
            "Hoàng Tân",
            "Hoàng Đơn"});
            this.SearchTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.SearchTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.SearchTextBox.Font = new System.Drawing.Font("Fira Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTextBox.Location = new System.Drawing.Point(17, 23);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(572, 35);
            this.SearchTextBox.TabIndex = 15;
            // 
            // FilterButton
            // 
            this.FilterButton.AutoSize = true;
            this.FilterButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.FilterButton.FlatAppearance.BorderSize = 0;
            this.FilterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilterButton.Font = new System.Drawing.Font("Fira Sans", 10F);
            this.FilterButton.Location = new System.Drawing.Point(761, 22);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(67, 36);
            this.FilterButton.TabIndex = 13;
            this.FilterButton.Text = "Lọc";
            this.FilterButton.UseVisualStyleBackColor = false;
            // 
            // SearchButton
            // 
            this.SearchButton.AutoSize = true;
            this.SearchButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SearchButton.FlatAppearance.BorderSize = 0;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Font = new System.Drawing.Font("Fira Sans", 10F);
            this.SearchButton.Location = new System.Drawing.Point(611, 21);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(129, 36);
            this.SearchButton.TabIndex = 14;
            this.SearchButton.Text = "Tìm Kiếm";
            this.SearchButton.UseVisualStyleBackColor = false;
            // 
            // ChildrenDataGirdView
            // 
            this.ChildrenDataGirdView.AutoGenerateColumns = false;
            this.ChildrenDataGirdView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ChildrenDataGirdView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSoChuongTrinhDataGridViewTextBoxColumn,
            this.hovaTenDataGridViewTextBoxColumn,
            this.ngaySinhDataGridViewTextBoxColumn,
            this.soDienThoaiDataGridViewTextBoxColumn,
            this.diaChiDataGridViewTextBoxColumn,
            this.thanhPHoDataGridViewTextBoxColumn,
            this.quanDataGridViewTextBoxColumn,
            this.songChungVoiDataGridViewTextBoxColumn,
            this.tinhTrangSucKhoeDataGridViewTextBoxColumn,
            this.trangThaiHocVanDataGridViewTextBoxColumn,
            this.lopDataGridViewTextBoxColumn,
            this.tienNhan3ThangDataGridViewTextBoxColumn,
            this.chuKyXacNhanDataGridViewTextBoxColumn,
            this.chuKyThayDataGridViewTextBoxColumn,
            this.ActionDeleteButton,
            this.ActionEditButton,
            this.ActionSeeButton});
            this.ChildrenDataGirdView.DataSource = this.childrenListBindingSource;
            this.ChildrenDataGirdView.Location = new System.Drawing.Point(17, 132);
            this.ChildrenDataGirdView.Name = "ChildrenDataGirdView";
            this.ChildrenDataGirdView.RowHeadersWidth = 51;
            this.ChildrenDataGirdView.RowTemplate.Height = 24;
            this.ChildrenDataGirdView.Size = new System.Drawing.Size(979, 441);
            this.ChildrenDataGirdView.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Fira Sans", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(59)))));
            this.label1.Location = new System.Drawing.Point(12, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 28);
            this.label1.TabIndex = 11;
            this.label1.Text = "Danh sách  trẻ em ";
            // 
            // childrenListBindingSource
            // 
            this.childrenListBindingSource.DataSource = typeof(ScholarshipManagement.Models.ChildrenList);
            // 
            // maSoChuongTrinhDataGridViewTextBoxColumn
            // 
            this.maSoChuongTrinhDataGridViewTextBoxColumn.DataPropertyName = "MaSoChuongTrinh";
            this.maSoChuongTrinhDataGridViewTextBoxColumn.HeaderText = "Mã Số Chương Trình";
            this.maSoChuongTrinhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maSoChuongTrinhDataGridViewTextBoxColumn.Name = "maSoChuongTrinhDataGridViewTextBoxColumn";
            this.maSoChuongTrinhDataGridViewTextBoxColumn.Width = 125;
            // 
            // hovaTenDataGridViewTextBoxColumn
            // 
            this.hovaTenDataGridViewTextBoxColumn.DataPropertyName = "HovaTen";
            this.hovaTenDataGridViewTextBoxColumn.HeaderText = "Họ và Tên";
            this.hovaTenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hovaTenDataGridViewTextBoxColumn.Name = "hovaTenDataGridViewTextBoxColumn";
            this.hovaTenDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngaySinhDataGridViewTextBoxColumn
            // 
            this.ngaySinhDataGridViewTextBoxColumn.DataPropertyName = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.HeaderText = "Ngày Sinh";
            this.ngaySinhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngaySinhDataGridViewTextBoxColumn.Name = "ngaySinhDataGridViewTextBoxColumn";
            this.ngaySinhDataGridViewTextBoxColumn.Width = 125;
            // 
            // soDienThoaiDataGridViewTextBoxColumn
            // 
            this.soDienThoaiDataGridViewTextBoxColumn.DataPropertyName = "SoDienThoai";
            this.soDienThoaiDataGridViewTextBoxColumn.HeaderText = "Số Điện Thoại";
            this.soDienThoaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soDienThoaiDataGridViewTextBoxColumn.Name = "soDienThoaiDataGridViewTextBoxColumn";
            this.soDienThoaiDataGridViewTextBoxColumn.Width = 125;
            // 
            // diaChiDataGridViewTextBoxColumn
            // 
            this.diaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.HeaderText = "Địa Chỉ";
            this.diaChiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
            this.diaChiDataGridViewTextBoxColumn.Width = 125;
            // 
            // thanhPHoDataGridViewTextBoxColumn
            // 
            this.thanhPHoDataGridViewTextBoxColumn.DataPropertyName = "ThanhPHo";
            this.thanhPHoDataGridViewTextBoxColumn.HeaderText = "Thành Phố";
            this.thanhPHoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.thanhPHoDataGridViewTextBoxColumn.Name = "thanhPHoDataGridViewTextBoxColumn";
            this.thanhPHoDataGridViewTextBoxColumn.Width = 125;
            // 
            // quanDataGridViewTextBoxColumn
            // 
            this.quanDataGridViewTextBoxColumn.DataPropertyName = "Quan";
            this.quanDataGridViewTextBoxColumn.HeaderText = "Quận";
            this.quanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quanDataGridViewTextBoxColumn.Name = "quanDataGridViewTextBoxColumn";
            this.quanDataGridViewTextBoxColumn.Width = 125;
            // 
            // songChungVoiDataGridViewTextBoxColumn
            // 
            this.songChungVoiDataGridViewTextBoxColumn.DataPropertyName = "SongChungVoi";
            this.songChungVoiDataGridViewTextBoxColumn.HeaderText = "Sống Chung Với";
            this.songChungVoiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.songChungVoiDataGridViewTextBoxColumn.Name = "songChungVoiDataGridViewTextBoxColumn";
            this.songChungVoiDataGridViewTextBoxColumn.Width = 125;
            // 
            // tinhTrangSucKhoeDataGridViewTextBoxColumn
            // 
            this.tinhTrangSucKhoeDataGridViewTextBoxColumn.DataPropertyName = "TinhTrangSucKhoe";
            this.tinhTrangSucKhoeDataGridViewTextBoxColumn.HeaderText = "Tình Trạng Sức Khỏe";
            this.tinhTrangSucKhoeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tinhTrangSucKhoeDataGridViewTextBoxColumn.Name = "tinhTrangSucKhoeDataGridViewTextBoxColumn";
            this.tinhTrangSucKhoeDataGridViewTextBoxColumn.Width = 125;
            // 
            // trangThaiHocVanDataGridViewTextBoxColumn
            // 
            this.trangThaiHocVanDataGridViewTextBoxColumn.DataPropertyName = "TrangThaiHocVan";
            this.trangThaiHocVanDataGridViewTextBoxColumn.HeaderText = "Trạng Thái Học Vấn";
            this.trangThaiHocVanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.trangThaiHocVanDataGridViewTextBoxColumn.Name = "trangThaiHocVanDataGridViewTextBoxColumn";
            this.trangThaiHocVanDataGridViewTextBoxColumn.Width = 125;
            // 
            // lopDataGridViewTextBoxColumn
            // 
            this.lopDataGridViewTextBoxColumn.DataPropertyName = "Lop";
            this.lopDataGridViewTextBoxColumn.HeaderText = "Lớp";
            this.lopDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lopDataGridViewTextBoxColumn.Name = "lopDataGridViewTextBoxColumn";
            this.lopDataGridViewTextBoxColumn.Width = 125;
            // 
            // tienNhan3ThangDataGridViewTextBoxColumn
            // 
            this.tienNhan3ThangDataGridViewTextBoxColumn.DataPropertyName = "TienNhan3Thang";
            this.tienNhan3ThangDataGridViewTextBoxColumn.HeaderText = "Tiền nhận 3 Tháng";
            this.tienNhan3ThangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tienNhan3ThangDataGridViewTextBoxColumn.Name = "tienNhan3ThangDataGridViewTextBoxColumn";
            this.tienNhan3ThangDataGridViewTextBoxColumn.Width = 125;
            // 
            // chuKyXacNhanDataGridViewTextBoxColumn
            // 
            this.chuKyXacNhanDataGridViewTextBoxColumn.DataPropertyName = "ChuKyXacNhan";
            this.chuKyXacNhanDataGridViewTextBoxColumn.HeaderText = "Chữ Ký Xác Nhận";
            this.chuKyXacNhanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.chuKyXacNhanDataGridViewTextBoxColumn.Name = "chuKyXacNhanDataGridViewTextBoxColumn";
            this.chuKyXacNhanDataGridViewTextBoxColumn.Width = 125;
            // 
            // chuKyThayDataGridViewTextBoxColumn
            // 
            this.chuKyThayDataGridViewTextBoxColumn.DataPropertyName = "ChuKyThay";
            this.chuKyThayDataGridViewTextBoxColumn.HeaderText = "Chữ Ký Thay";
            this.chuKyThayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.chuKyThayDataGridViewTextBoxColumn.Name = "chuKyThayDataGridViewTextBoxColumn";
            this.chuKyThayDataGridViewTextBoxColumn.Width = 125;
            // 
            // ActionDeleteButton
            // 
            this.ActionDeleteButton.HeaderText = "";
            this.ActionDeleteButton.MinimumWidth = 6;
            this.ActionDeleteButton.Name = "ActionDeleteButton";
            this.ActionDeleteButton.Text = "Xóa";
            this.ActionDeleteButton.UseColumnTextForButtonValue = true;
            this.ActionDeleteButton.Width = 125;
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
            // ActionSeeButton
            // 
            this.ActionSeeButton.HeaderText = "";
            this.ActionSeeButton.MinimumWidth = 6;
            this.ActionSeeButton.Name = "ActionSeeButton";
            this.ActionSeeButton.Text = "Xem";
            this.ActionSeeButton.UseColumnTextForButtonValue = true;
            this.ActionSeeButton.Width = 125;
            // 
            // EventDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 595);
            this.Controls.Add(this.EventDektopPanel);
            this.Name = "EventDetailForm";
            this.Text = "EventDetailForm";
            this.Load += new System.EventHandler(this.EventDetailForm_Load);
            this.EventDektopPanel.ResumeLayout(false);
            this.EventDektopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChildrenDataGirdView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.childrenListBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource childrenListBindingSource;
        private System.Windows.Forms.Panel EventDektopPanel;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button FilterButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.DataGridView ChildrenDataGirdView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddScholarshipButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSoChuongTrinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hovaTenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soDienThoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhPHoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn songChungVoiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhTrangSucKhoeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangThaiHocVanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienNhan3ThangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chuKyXacNhanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chuKyThayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn ActionDeleteButton;
        private System.Windows.Forms.DataGridViewButtonColumn ActionEditButton;
        private System.Windows.Forms.DataGridViewButtonColumn ActionSeeButton;
    }
}