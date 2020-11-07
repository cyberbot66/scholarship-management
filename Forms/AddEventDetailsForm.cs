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
    public partial class AddEventDetailsForm : Form
    {
        private Form currentChildForm;
        public AddEventDetailsForm()
        {
            InitializeComponent();
        }
        
        private void CancelButton_Click(object sender, EventArgs e)
        {

        }

        private void UploadButton_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    pictureBox1.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Tải hình ảnh lên bị lỗi, vui lòng tài lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    SignatureInsteadPictureBox.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Tải hình ảnh lên bị lỗi, vui lòng tài lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            EventDetailPanel.Controls.Add(childForm);
            EventDetailPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void CancelButton_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new EventDetailForm());
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new EventDetailForm());
        }
    }
 }

