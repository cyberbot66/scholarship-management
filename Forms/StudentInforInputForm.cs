using ScholarshipManagement.Forms.ChildFormOfInputInfor;
using System;
using System.Windows.Forms;

namespace ScholarshipManagement.Forms
{
    public partial class StudentInforInputForm : Form
    {
        private Form currentChildForm;

        public StudentInforInputForm()
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
            ParentPanel.Controls.Add(childForm);
            ParentPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void ParentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ParentComboBox.SelectedIndex == 0)
                OpenChildForm(new FatherForm());
            else
            {
                if (ParentComboBox.SelectedIndex == 1)
                    OpenChildForm(new MotherForm());
                else
                {
                    if (ParentComboBox.SelectedIndex == 2)
                        OpenChildForm(new BothForm());
                    else
                        OpenChildForm(new OtherForm());
                }
            }
        }

        private void UploadButton_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg|  PNG files(*.png)|*.png|  All Files(*.*)|*.*";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    AvatarPictureBox.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
