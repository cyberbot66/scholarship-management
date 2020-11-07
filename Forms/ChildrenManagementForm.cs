using System;
using System.Windows.Forms;

namespace ScholarshipManagement.Forms
{
    public partial class ChildrenManagementForm : Form
    {
        private Form currentChildForm;
        public ChildrenManagementForm()
        {
            InitializeComponent();
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
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new StudentInforInputForm());
        }
    }
}
