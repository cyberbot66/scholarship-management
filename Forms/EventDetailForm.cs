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
    public partial class EventDetailForm : Form
    {
        private Form currentChildForm;

        public EventDetailForm()
        {
            InitializeComponent();
        }

        private void EventDetailForm_Load(object sender, EventArgs e)
        {
            childrenListBindingSource.Add(new Models.ChildrenList() { MaSoChuongTrinh = "1", HovaTen = "Lê Hoàng Long", NgaySinh = "04-05-2000",SoDienThoai = "0778068453",DiaChi = "Phường 19", ThanhPHo = "Hồ Chí Minh",Quan = "Bình Thạnh",SongChungVoi = "Ba và Mẹ",TinhTrangSucKhoe = "Bình Thường", TrangThaiHocVan= "Đại Học", Lop = "18D1TH01",TienNhan3Thang = "100.000.000" });
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
            EventDektopPanel.Controls.Add(childForm);
            EventDektopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void AddScholarshipButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddEventDetailsForm());
        }
    }
}
