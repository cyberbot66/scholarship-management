using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScholarshipManagement.Forms
{
    public partial class AddEventForm : Form
    {
        private Form currentChildForm;

        public AddEventForm()
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
            DektopPanel.Controls.Add(childForm);
            DektopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new EventManagementForm());
        }   
    }
}
