using System;
using System.Windows.Forms;

namespace ScholarshipManagement.Forms
{
    public partial class EventForm : Form
    {
        private Form currentChildForm;

        public EventForm()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            ChildFormPanel.Controls.Add(childForm);
            ChildFormPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void AddProgramButton_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new AddEventForm());
        }
    }
}
