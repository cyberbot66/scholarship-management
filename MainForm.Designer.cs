namespace ScholarshipManagement
{
    partial class MainForm
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
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.BudgetManagementButton = new FontAwesome.Sharp.IconButton();
            this.ChildrenManagementButton = new FontAwesome.Sharp.IconButton();
            this.HomeButton = new FontAwesome.Sharp.IconButton();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.TitleBarPanel = new System.Windows.Forms.Panel();
            this.CloseButton = new FontAwesome.Sharp.IconButton();
            this.MinimizeButton = new FontAwesome.Sharp.IconButton();
            this.MaximizeButton = new FontAwesome.Sharp.IconButton();
            this.TitleBarLabel = new System.Windows.Forms.Label();
            this.TitleBarIcon = new FontAwesome.Sharp.IconPictureBox();
            this.ChildFormPanel = new System.Windows.Forms.Panel();
            this.MenuPanel.SuspendLayout();
            this.TitleBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TitleBarIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(74)))));
            this.MenuPanel.Controls.Add(this.BudgetManagementButton);
            this.MenuPanel.Controls.Add(this.ChildrenManagementButton);
            this.MenuPanel.Controls.Add(this.HomeButton);
            this.MenuPanel.Controls.Add(this.LogoPanel);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.ForeColor = System.Drawing.Color.White;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(240, 884);
            this.MenuPanel.TabIndex = 0;
            // 
            // BudgetManagementButton
            // 
            this.BudgetManagementButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.BudgetManagementButton.FlatAppearance.BorderSize = 0;
            this.BudgetManagementButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BudgetManagementButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BudgetManagementButton.Font = new System.Drawing.Font("Fira Sans", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BudgetManagementButton.ForeColor = System.Drawing.Color.White;
            this.BudgetManagementButton.IconChar = FontAwesome.Sharp.IconChar.Calendar;
            this.BudgetManagementButton.IconColor = System.Drawing.Color.White;
            this.BudgetManagementButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BudgetManagementButton.IconSize = 28;
            this.BudgetManagementButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BudgetManagementButton.Location = new System.Drawing.Point(0, 261);
            this.BudgetManagementButton.Name = "BudgetManagementButton";
            this.BudgetManagementButton.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.BudgetManagementButton.Rotation = 0D;
            this.BudgetManagementButton.Size = new System.Drawing.Size(240, 60);
            this.BudgetManagementButton.TabIndex = 3;
            this.BudgetManagementButton.Text = "Quản lý chương trình";
            this.BudgetManagementButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BudgetManagementButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BudgetManagementButton.UseVisualStyleBackColor = true;
            this.BudgetManagementButton.Click += new System.EventHandler(this.BudgetManagementButton_Click);
            // 
            // ChildrenManagementButton
            // 
            this.ChildrenManagementButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ChildrenManagementButton.FlatAppearance.BorderSize = 0;
            this.ChildrenManagementButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChildrenManagementButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ChildrenManagementButton.Font = new System.Drawing.Font("Fira Sans", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChildrenManagementButton.ForeColor = System.Drawing.Color.White;
            this.ChildrenManagementButton.IconChar = FontAwesome.Sharp.IconChar.User;
            this.ChildrenManagementButton.IconColor = System.Drawing.Color.White;
            this.ChildrenManagementButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ChildrenManagementButton.IconSize = 28;
            this.ChildrenManagementButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChildrenManagementButton.Location = new System.Drawing.Point(0, 201);
            this.ChildrenManagementButton.Name = "ChildrenManagementButton";
            this.ChildrenManagementButton.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.ChildrenManagementButton.Rotation = 0D;
            this.ChildrenManagementButton.Size = new System.Drawing.Size(240, 60);
            this.ChildrenManagementButton.TabIndex = 2;
            this.ChildrenManagementButton.Text = "Quản lý trẻ em";
            this.ChildrenManagementButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChildrenManagementButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ChildrenManagementButton.UseVisualStyleBackColor = true;
            this.ChildrenManagementButton.Click += new System.EventHandler(this.ChildrenManagementButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.HomeButton.FlatAppearance.BorderSize = 0;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.HomeButton.Font = new System.Drawing.Font("Fira Sans", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeButton.ForeColor = System.Drawing.Color.White;
            this.HomeButton.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.HomeButton.IconColor = System.Drawing.Color.White;
            this.HomeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.HomeButton.IconSize = 28;
            this.HomeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeButton.Location = new System.Drawing.Point(0, 141);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.HomeButton.Rotation = 0D;
            this.HomeButton.Size = new System.Drawing.Size(240, 60);
            this.HomeButton.TabIndex = 1;
            this.HomeButton.Text = "Tổng quan";
            this.HomeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // LogoPanel
            // 
            this.LogoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(74)))));
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoPanel.ForeColor = System.Drawing.Color.White;
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(240, 141);
            this.LogoPanel.TabIndex = 0;
            // 
            // TitleBarPanel
            // 
            this.TitleBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(59)))));
            this.TitleBarPanel.Controls.Add(this.CloseButton);
            this.TitleBarPanel.Controls.Add(this.MinimizeButton);
            this.TitleBarPanel.Controls.Add(this.MaximizeButton);
            this.TitleBarPanel.Controls.Add(this.TitleBarLabel);
            this.TitleBarPanel.Controls.Add(this.TitleBarIcon);
            this.TitleBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBarPanel.ForeColor = System.Drawing.Color.White;
            this.TitleBarPanel.Location = new System.Drawing.Point(240, 0);
            this.TitleBarPanel.Name = "TitleBarPanel";
            this.TitleBarPanel.Size = new System.Drawing.Size(1024, 70);
            this.TitleBarPanel.TabIndex = 1;
            this.TitleBarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBarPanel_MouseDown);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.CloseButton.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.CloseButton.IconColor = System.Drawing.Color.White;
            this.CloseButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CloseButton.IconSize = 16;
            this.CloseButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CloseButton.Location = new System.Drawing.Point(986, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Rotation = 0D;
            this.CloseButton.Size = new System.Drawing.Size(38, 29);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.MinimizeButton.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.MinimizeButton.IconColor = System.Drawing.Color.White;
            this.MinimizeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MinimizeButton.IconSize = 16;
            this.MinimizeButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.MinimizeButton.Location = new System.Drawing.Point(898, 0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Rotation = 0D;
            this.MinimizeButton.Size = new System.Drawing.Size(38, 29);
            this.MinimizeButton.TabIndex = 4;
            this.MinimizeButton.UseVisualStyleBackColor = true;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // MaximizeButton
            // 
            this.MaximizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaximizeButton.FlatAppearance.BorderSize = 0;
            this.MaximizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaximizeButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.MaximizeButton.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.MaximizeButton.IconColor = System.Drawing.Color.White;
            this.MaximizeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MaximizeButton.IconSize = 16;
            this.MaximizeButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.MaximizeButton.Location = new System.Drawing.Point(942, 0);
            this.MaximizeButton.Name = "MaximizeButton";
            this.MaximizeButton.Rotation = 0D;
            this.MaximizeButton.Size = new System.Drawing.Size(38, 29);
            this.MaximizeButton.TabIndex = 3;
            this.MaximizeButton.UseVisualStyleBackColor = true;
            this.MaximizeButton.Click += new System.EventHandler(this.MaximizeButton_Click);
            // 
            // TitleBarLabel
            // 
            this.TitleBarLabel.AutoSize = true;
            this.TitleBarLabel.Font = new System.Drawing.Font("Fira Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleBarLabel.Location = new System.Drawing.Point(56, 29);
            this.TitleBarLabel.Name = "TitleBarLabel";
            this.TitleBarLabel.Size = new System.Drawing.Size(85, 19);
            this.TitleBarLabel.TabIndex = 1;
            this.TitleBarLabel.Text = "Tổng quan";
            // 
            // TitleBarIcon
            // 
            this.TitleBarIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(59)))));
            this.TitleBarIcon.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.TitleBarIcon.IconColor = System.Drawing.Color.White;
            this.TitleBarIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.TitleBarIcon.Location = new System.Drawing.Point(19, 23);
            this.TitleBarIcon.Name = "TitleBarIcon";
            this.TitleBarIcon.Size = new System.Drawing.Size(32, 32);
            this.TitleBarIcon.TabIndex = 0;
            this.TitleBarIcon.TabStop = false;
            // 
            // ChildFormPanel
            // 
            this.ChildFormPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.ChildFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChildFormPanel.Location = new System.Drawing.Point(240, 70);
            this.ChildFormPanel.Name = "ChildFormPanel";
            this.ChildFormPanel.Size = new System.Drawing.Size(1024, 814);
            this.ChildFormPanel.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 884);
            this.ControlBox = false;
            this.Controls.Add(this.ChildFormPanel);
            this.Controls.Add(this.TitleBarPanel);
            this.Controls.Add(this.MenuPanel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Fira Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MenuPanel.ResumeLayout(false);
            this.TitleBarPanel.ResumeLayout(false);
            this.TitleBarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TitleBarIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private FontAwesome.Sharp.IconButton HomeButton;
        private System.Windows.Forms.Panel LogoPanel;
        private FontAwesome.Sharp.IconButton BudgetManagementButton;
        private FontAwesome.Sharp.IconButton ChildrenManagementButton;
        private System.Windows.Forms.Panel TitleBarPanel;
        private FontAwesome.Sharp.IconPictureBox TitleBarIcon;
        private System.Windows.Forms.Label TitleBarLabel;
        private System.Windows.Forms.Panel ChildFormPanel;
        private FontAwesome.Sharp.IconButton CloseButton;
        private FontAwesome.Sharp.IconButton MaximizeButton;
        private FontAwesome.Sharp.IconButton MinimizeButton;
    }
}