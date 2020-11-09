namespace ScholarshipManagement.Forms
{
    partial class ChildrenForm
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
            this.ChildrenFormPanel = new System.Windows.Forms.Panel();
            this.ChildrenListView = new System.Windows.Forms.ListView();
            this.FullNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BirthdayColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BirthPlaceColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PhoneNumberColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HealthConditionColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SearchButton = new FontAwesome.Sharp.IconButton();
            this.AddButton = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.ChildrenFormPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChildrenFormPanel
            // 
            this.ChildrenFormPanel.Controls.Add(this.ChildrenListView);
            this.ChildrenFormPanel.Controls.Add(this.SearchButton);
            this.ChildrenFormPanel.Controls.Add(this.AddButton);
            this.ChildrenFormPanel.Controls.Add(this.label1);
            this.ChildrenFormPanel.Controls.Add(this.SearchTextBox);
            this.ChildrenFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChildrenFormPanel.Location = new System.Drawing.Point(0, 0);
            this.ChildrenFormPanel.Name = "ChildrenFormPanel";
            this.ChildrenFormPanel.Size = new System.Drawing.Size(1008, 595);
            this.ChildrenFormPanel.TabIndex = 0;
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
            this.ChildrenListView.Location = new System.Drawing.Point(28, 143);
            this.ChildrenListView.Name = "ChildrenListView";
            this.ChildrenListView.Size = new System.Drawing.Size(952, 419);
            this.ChildrenListView.TabIndex = 22;
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
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.SearchButton.FlatAppearance.BorderSize = 0;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.SearchButton.Font = new System.Drawing.Font("Fira Sans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.SearchButton.IconColor = System.Drawing.Color.Black;
            this.SearchButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SearchButton.IconSize = 24;
            this.SearchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SearchButton.Location = new System.Drawing.Point(508, 33);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.SearchButton.Rotation = 0D;
            this.SearchButton.Size = new System.Drawing.Size(112, 45);
            this.SearchButton.TabIndex = 21;
            this.SearchButton.Text = "Tìm trẻ";
            this.SearchButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SearchButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SearchButton.UseVisualStyleBackColor = false;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.YellowGreen;
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.AddButton.Font = new System.Drawing.Font("Fira Sans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.AddButton.IconColor = System.Drawing.Color.Black;
            this.AddButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AddButton.IconSize = 24;
            this.AddButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddButton.Location = new System.Drawing.Point(868, 81);
            this.AddButton.Name = "AddButton";
            this.AddButton.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.AddButton.Rotation = 0D;
            this.AddButton.Size = new System.Drawing.Size(112, 45);
            this.AddButton.TabIndex = 20;
            this.AddButton.Text = "Thêm trẻ";
            this.AddButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Fira Sans", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "Danh sách trẻ em";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Font = new System.Drawing.Font("Fira Sans", 14F);
            this.SearchTextBox.Location = new System.Drawing.Point(28, 39);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(474, 30);
            this.SearchTextBox.TabIndex = 18;
            // 
            // ChildrenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 595);
            this.Controls.Add(this.ChildrenFormPanel);
            this.Font = new System.Drawing.Font("Fira Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ChildrenForm";
            this.Text = "Quản lý trẻ em";
            this.Load += new System.EventHandler(this.ChildrenForm_Load);
            this.ChildrenFormPanel.ResumeLayout(false);
            this.ChildrenFormPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ChildrenFormPanel;
        private System.Windows.Forms.ListView ChildrenListView;
        private System.Windows.Forms.ColumnHeader FullNameColumnHeader;
        private System.Windows.Forms.ColumnHeader BirthdayColumnHeader;
        private System.Windows.Forms.ColumnHeader BirthPlaceColumnHeader;
        private System.Windows.Forms.ColumnHeader PhoneNumberColumnHeader;
        private System.Windows.Forms.ColumnHeader HealthConditionColumnHeader;
        private FontAwesome.Sharp.IconButton SearchButton;
        private FontAwesome.Sharp.IconButton AddButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchTextBox;
    }
}