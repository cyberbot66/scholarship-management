namespace ScholarshipManagement.Forms
{
    partial class DashboardForm
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
            this.ChildrenListView = new System.Windows.Forms.ListView();
            this.FullNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BirthdayColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BirthPlaceColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PhoneNumberColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HealthConditionColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EventDataGridView = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.EventCountLabel = new System.Windows.Forms.Label();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ChildrenManagamentPanel = new System.Windows.Forms.Panel();
            this.ChildrenCountLabel = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ChildFormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EventDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.ChildrenManagamentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ChildFormPanel
            // 
            this.ChildFormPanel.Controls.Add(this.ChildrenListView);
            this.ChildFormPanel.Controls.Add(this.EventDataGridView);
            this.ChildFormPanel.Controls.Add(this.label6);
            this.ChildFormPanel.Controls.Add(this.panel2);
            this.ChildFormPanel.Controls.Add(this.ChildrenManagamentPanel);
            this.ChildFormPanel.Controls.Add(this.label1);
            this.ChildFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChildFormPanel.Location = new System.Drawing.Point(0, 0);
            this.ChildFormPanel.Name = "ChildFormPanel";
            this.ChildFormPanel.Size = new System.Drawing.Size(991, 1060);
            this.ChildFormPanel.TabIndex = 0;
            // 
            // ChildrenListView
            // 
            this.ChildrenListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FullNameColumnHeader,
            this.BirthdayColumnHeader,
            this.BirthPlaceColumnHeader,
            this.PhoneNumberColumnHeader,
            this.HealthConditionColumnHeader});
            this.ChildrenListView.Font = new System.Drawing.Font("Fira Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChildrenListView.FullRowSelect = true;
            this.ChildrenListView.GridLines = true;
            this.ChildrenListView.HideSelection = false;
            this.ChildrenListView.Location = new System.Drawing.Point(29, 245);
            this.ChildrenListView.Name = "ChildrenListView";
            this.ChildrenListView.Size = new System.Drawing.Size(935, 359);
            this.ChildrenListView.TabIndex = 29;
            this.ChildrenListView.UseCompatibleStateImageBehavior = false;
            this.ChildrenListView.View = System.Windows.Forms.View.Details;
            this.ChildrenListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ChildrenListView_MouseDoubleClick);
            // 
            // FullNameColumnHeader
            // 
            this.FullNameColumnHeader.Text = "Họ và tên";
            this.FullNameColumnHeader.Width = 215;
            // 
            // BirthdayColumnHeader
            // 
            this.BirthdayColumnHeader.Text = "Ngày sinh";
            this.BirthdayColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BirthdayColumnHeader.Width = 149;
            // 
            // BirthPlaceColumnHeader
            // 
            this.BirthPlaceColumnHeader.Text = "Nơi sinh";
            this.BirthPlaceColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BirthPlaceColumnHeader.Width = 143;
            // 
            // PhoneNumberColumnHeader
            // 
            this.PhoneNumberColumnHeader.Text = "Số điện thoại";
            this.PhoneNumberColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PhoneNumberColumnHeader.Width = 136;
            // 
            // HealthConditionColumnHeader
            // 
            this.HealthConditionColumnHeader.Text = "Tình trạng sức khỏe";
            this.HealthConditionColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HealthConditionColumnHeader.Width = 226;
            // 
            // EventDataGridView
            // 
            this.EventDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EventDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EventDataGridView.Location = new System.Drawing.Point(30, 661);
            this.EventDataGridView.Name = "EventDataGridView";
            this.EventDataGridView.Size = new System.Drawing.Size(934, 347);
            this.EventDataGridView.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Fira Sans", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(59)))));
            this.label6.Location = new System.Drawing.Point(26, 635);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 23);
            this.label6.TabIndex = 27;
            this.label6.Text = "Danh sách chương trình";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(137)))), ((int)(((byte)(89)))));
            this.panel2.Controls.Add(this.EventCountLabel);
            this.panel2.Controls.Add(this.iconPictureBox2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Location = new System.Drawing.Point(392, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(342, 142);
            this.panel2.TabIndex = 26;
            // 
            // EventCountLabel
            // 
            this.EventCountLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EventCountLabel.AutoSize = true;
            this.EventCountLabel.Font = new System.Drawing.Font("Fira Sans", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventCountLabel.ForeColor = System.Drawing.Color.White;
            this.EventCountLabel.Location = new System.Drawing.Point(55, 53);
            this.EventCountLabel.Name = "EventCountLabel";
            this.EventCountLabel.Size = new System.Drawing.Size(70, 77);
            this.EventCountLabel.TabIndex = 3;
            this.EventCountLabel.Text = "0";
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(137)))), ((int)(((byte)(89)))));
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.iconPictureBox2.IconColor = System.Drawing.Color.White;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 42;
            this.iconPictureBox2.Location = new System.Drawing.Point(18, 75);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(42, 42);
            this.iconPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconPictureBox2.TabIndex = 0;
            this.iconPictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Fira Sans", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(14, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(310, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tổng số chương trình đang quản lý";
            // 
            // ChildrenManagamentPanel
            // 
            this.ChildrenManagamentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(167)))), ((int)(((byte)(134)))));
            this.ChildrenManagamentPanel.Controls.Add(this.ChildrenCountLabel);
            this.ChildrenManagamentPanel.Controls.Add(this.iconPictureBox1);
            this.ChildrenManagamentPanel.Controls.Add(this.label2);
            this.ChildrenManagamentPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChildrenManagamentPanel.Location = new System.Drawing.Point(30, 53);
            this.ChildrenManagamentPanel.Name = "ChildrenManagamentPanel";
            this.ChildrenManagamentPanel.Size = new System.Drawing.Size(342, 142);
            this.ChildrenManagamentPanel.TabIndex = 25;
            this.ChildrenManagamentPanel.Click += new System.EventHandler(this.ChildrenManagamentPanel_Click);
            // 
            // ChildrenCountLabel
            // 
            this.ChildrenCountLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ChildrenCountLabel.AutoSize = true;
            this.ChildrenCountLabel.Font = new System.Drawing.Font("Fira Sans", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChildrenCountLabel.ForeColor = System.Drawing.Color.White;
            this.ChildrenCountLabel.Location = new System.Drawing.Point(52, 53);
            this.ChildrenCountLabel.Name = "ChildrenCountLabel";
            this.ChildrenCountLabel.Size = new System.Drawing.Size(70, 77);
            this.ChildrenCountLabel.TabIndex = 3;
            this.ChildrenCountLabel.Text = "0";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(167)))), ((int)(((byte)(134)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 42;
            this.iconPictureBox1.Location = new System.Drawing.Point(15, 75);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(42, 42);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Fira Sans", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tổng số trẻ em đang quản lý";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Fira Sans", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(59)))));
            this.label1.Location = new System.Drawing.Point(26, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 23);
            this.label1.TabIndex = 24;
            this.label1.Text = "Danh sách trẻ em";
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(0, 1060);
            this.ClientSize = new System.Drawing.Size(1008, 1021);
            this.Controls.Add(this.ChildFormPanel);
            this.Font = new System.Drawing.Font("Fira Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeBox = false;
            this.Name = "DashboardForm";
            this.Text = "Tổng quan";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.ChildFormPanel.ResumeLayout(false);
            this.ChildFormPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EventDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.ChildrenManagamentPanel.ResumeLayout(false);
            this.ChildrenManagamentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ChildFormPanel;
        private System.Windows.Forms.ListView ChildrenListView;
        private System.Windows.Forms.ColumnHeader FullNameColumnHeader;
        private System.Windows.Forms.ColumnHeader BirthdayColumnHeader;
        private System.Windows.Forms.ColumnHeader BirthPlaceColumnHeader;
        private System.Windows.Forms.ColumnHeader PhoneNumberColumnHeader;
        private System.Windows.Forms.ColumnHeader HealthConditionColumnHeader;
        private System.Windows.Forms.DataGridView EventDataGridView;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label EventCountLabel;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel ChildrenManagamentPanel;
        private System.Windows.Forms.Label ChildrenCountLabel;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}