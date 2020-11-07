using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using FontAwesome.Sharp;
using ScholarshipManagement.Forms;
using Google.Cloud.Firestore;

namespace ScholarshipManagement
{
    public partial class MainForm : Form
    {
        private readonly string path = AppDomain.CurrentDomain.BaseDirectory + @"winform-project.json";
        public FirestoreDb db;

        private Form currentChildForm;
        private IconButton currentButton;
        private readonly Panel leftBorderButton;

        public MainForm()
        {
            InitializeComponent();

            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            // Add left border to the menu panel
            leftBorderButton = new Panel { Size = new Size(7, 60) };
            MenuPanel.Controls.Add(leftBorderButton);
            OpenChildForm(new DashboardForm());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            db = FirestoreDb.Create("winform-project");
        }

        private void OpenChildForm(Form childForm)
        {   
            if (currentChildForm != null) currentChildForm.Close();

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            ChildFormPanel.Controls.Add(childForm);
            ChildFormPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            TitleBarLabel.Text = childForm.Text;
        }

        private void ActivateButton(object senderButton)
        {
            if(senderButton != null)
            {
                DisableButton(); 

                currentButton = (IconButton)senderButton;
                currentButton.BackColor = Color.FromArgb(43, 51, 59);

                leftBorderButton.BackColor = Color.FromArgb(26, 31, 35);
                leftBorderButton.Location = new Point(0, currentButton.Location.Y);
                leftBorderButton.Visible = true;
                leftBorderButton.BringToFront();

                TitleBarIcon.IconChar = currentButton.IconChar;
            }
        }

        private void DisableButton()
        {
            if(currentButton != null) currentButton.BackColor = Color.FromArgb(55, 64, 74);
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new DashboardForm());
        }

        private void ChildrenManagementButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new ChildrenManagementForm());
        }

        private void BudgetManagementButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new EventManagementForm());
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void TitleBarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MaximizeButton_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else WindowState = FormWindowState.Normal;
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
