using Google.Cloud.Firestore;
using ScholarshipManagement.Models;
using System;
using System.Windows.Forms;

namespace ScholarshipManagement.Forms
{
    public partial class ChildrenForm : Form
    {
        private FirestoreDb db;
        private Form currentChildForm;
        public ChildrenForm(FirestoreDb firestore)
        {
            InitializeComponent();
            db = firestore;
        }

        private void ChildrenForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null) currentChildForm.Close();

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            ChildrenFormPanel.Controls.Add(childForm);
            ChildrenFormPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddChildForm(db));
        }

        private void AddData(Child child)
        {
            ListViewItem item = new ListViewItem { Text = child.FullName };
            item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = child.Birthday });
            item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = child.BirthPlace });
            item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = child.PhoneNumber });
            item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = child.HealthCondition });
            item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = child.Id });
            ChildrenListView.Items.Add(item);
        }

        private async void LoadData()
        {
            ChildrenListView.Items.Clear();

            Query children = db.Collection("children");
            QuerySnapshot snapshots = await children.GetSnapshotAsync();

            foreach (DocumentSnapshot child in snapshots)
            {
                AddData(child.ConvertTo<Child>());
            }
        }

        private async void ChildrenListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListView senderList = (ListView)sender;
            ListViewItem clickedItem = senderList.HitTest(e.Location).Item;
            if (clickedItem != null)
            {
                string id = clickedItem.SubItems[5].Text;
                DocumentReference doc = db.Collection("children").Document(id);
                DocumentSnapshot snapshot = await doc.GetSnapshotAsync();
                OpenChildForm(new ChildForm(db, snapshot.ConvertTo<Child>()));
            }
        }
    }
}
