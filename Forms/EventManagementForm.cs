using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScholarshipManagement.Forms
{
    public partial class EventManagementForm : Form
    {
        private Form currentChildForm;

        public EventManagementForm()
        {
            InitializeComponent();
        }

        private void EventManagementForm_Load(object sender, EventArgs e)
        {
            programBindingSource.Add(new Models.Program() {MaSoChuongTrinh ="1",NgayNhanTien = "10-10-2020",NgayPhatTien = "11-10-2020" });
            programBindingSource.Add(new Models.Program() { MaSoChuongTrinh = "2", NgayNhanTien = "10-10-2020", NgayPhatTien = "11-10-2020" });
            programBindingSource.Add(new Models.Program() { MaSoChuongTrinh = "3", NgayNhanTien = "10-10-2020", NgayPhatTien = "11-10-2020" });
            programBindingSource.Add(new Models.Program() { MaSoChuongTrinh = "4", NgayNhanTien = "10-10-2020", NgayPhatTien = "11-10-2020" });
            programBindingSource.Add(new Models.Program() { MaSoChuongTrinh = "5", NgayNhanTien = "10-10-2020", NgayPhatTien = "11-10-2020" });
            programBindingSource.Add(new Models.Program() { MaSoChuongTrinh = "6", NgayNhanTien = "10-10-2020", NgayPhatTien = "11-10-2020" });
            programBindingSource.Add(new Models.Program() { MaSoChuongTrinh = "7", NgayNhanTien = "10-10-2020", NgayPhatTien = "11-10-2020" });
            programBindingSource.Add(new Models.Program() { MaSoChuongTrinh = "8", NgayNhanTien = "10-10-2020", NgayPhatTien = "11-10-2020" });
            programBindingSource.Add(new Models.Program() { MaSoChuongTrinh = "9", NgayNhanTien = "10-10-2020", NgayPhatTien = "11-10-2020" });
            programBindingSource.Add(new Models.Program() { MaSoChuongTrinh = "10", NgayNhanTien = "10-10-2020", NgayPhatTien = "11-10-2020" });
            programBindingSource.Add(new Models.Program() { MaSoChuongTrinh = "11", NgayNhanTien = "10-10-2020", NgayPhatTien = "11-10-2020" });
            programBindingSource.Add(new Models.Program() { MaSoChuongTrinh = "12", NgayNhanTien = "10-10-2020", NgayPhatTien = "11-10-2020" });
            programBindingSource.Add(new Models.Program() { MaSoChuongTrinh = "13", NgayNhanTien = "10-10-2020", NgayPhatTien = "11-10-2020" });
            programBindingSource.Add(new Models.Program() { MaSoChuongTrinh = "14", NgayNhanTien = "10-10-2020", NgayPhatTien = "11-10-2020" });

        }

        private void ProgramDatabaseGirdView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ProgramDatabaseGirdView.Columns[e.ColumnIndex].Name == "ActionDeleteButton")
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa dữ liệu chương trình này không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    programBindingSource.RemoveCurrent();
                }
            }
            if (ProgramDatabaseGirdView.Columns[e.ColumnIndex].Name == "ActionSeeButton")
            {
                OpenChildForm(new EventDetailForm()); 
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
            ChildFormPanel.Controls.Add(childForm);
            ChildFormPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void AddProgramButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddEventForm());
        }
    }
}
