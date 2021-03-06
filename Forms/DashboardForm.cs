﻿using Google.Cloud.Firestore;
using ScholarshipManagement.Models;
using System.Windows.Forms;

namespace ScholarshipManagement.Forms
{
    public partial class DashboardForm : Form
    {
        readonly FirestoreDb db;
        private Form currentChildForm;
        public DashboardForm(FirestoreDb firestore)
        {
            InitializeComponent();
            db = firestore;
        }

        private async void DashboardForm_Load(object sender, System.EventArgs e)
        {
            QuerySnapshot children = await db.Collection("children").GetSnapshotAsync();
            ChildrenCountLabel.Text = children.Documents.Count.ToString();
            LoadData();
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

        private void ChildrenManagamentPanel_Click(object sender, System.EventArgs e)
        {
            OpenChildForm(new ChildrenForm(db));
        }
    }
}
