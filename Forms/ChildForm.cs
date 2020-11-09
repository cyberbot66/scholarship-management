using FontAwesome.Sharp;
using Google.Cloud.Firestore;
using ScholarshipManagement.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace ScholarshipManagement.Forms
{
    public partial class ChildForm : Form
    {
        private readonly FirestoreDb db;
        private readonly Child data;
        public ChildForm(FirestoreDb firestore,Child child)
        {
            InitializeComponent();
            db = firestore;
            data = child;
        }
        private async void ChildForm_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> academicLevelsSource = new Dictionary<string, string>();
            Dictionary<string, string> healthConditionsSource = new Dictionary<string, string>();

            QuerySnapshot academicLevels = await db.Collection("academic_levels").OrderBy("Level").GetSnapshotAsync();
            QuerySnapshot healthConditions = await db.Collection("health_conditions").OrderBy("Index").GetSnapshotAsync();

            foreach (DocumentSnapshot doc in academicLevels.Documents)
            {
                academicLevelsSource.Add(doc.Id, doc.GetValue<string>("Value"));
            }

            foreach (DocumentSnapshot doc in healthConditions.Documents)
            {
                healthConditionsSource.Add(doc.Id, doc.GetValue<string>("Value"));
            }

            AcademicLevelComboBox.DataSource = new BindingSource(academicLevelsSource, null);
            AcademicLevelComboBox.DisplayMember = "Value";
            AcademicLevelComboBox.ValueMember = "Key";

            HealthConditionsComboBox.DataSource = new BindingSource(healthConditionsSource, null);
            HealthConditionsComboBox.DisplayMember = "Value";
            HealthConditionsComboBox.ValueMember = "Key";

            byte[] avatarBase64 = Convert.FromBase64String(data.Avatar);
            MemoryStream ms = new MemoryStream();
            ms.Write(avatarBase64, 0, Convert.ToInt32(avatarBase64.Length));
            Bitmap bitmap = new Bitmap(ms, false);
            ms.Dispose();

            AvatarPictureBox.BackgroundImage = bitmap;
            FullNameTextBox.Text = data.FullName;
            BirthdayDateTimePicker.Value = Convert.ToDateTime(data.Birthday);
            PhoneNumberTextBox.Text = data.PhoneNumber;
            BirthPlaceTextBox.Text = data.BirthPlace;
            AddressTextBox.Text = data.Address;
            AcademicLevelComboBox.Text = data.AcademicLevel;
            HealthConditionsComboBox.Text = data.HealthCondition;
            FatherFullNameTextBox.Text = data.FatherFullName;
            FatherPhoneNumberTextBox.Text = data.FatherPhoneNumber;
            MotherFullNameTextBox.Text = data.MotherFullName;
            MotherPhoneNumberTextBox.Text = data.MotherPhoneNumber;
            ProtectorFullNametextBox.Text = data.ProtectorFullName;
            ProtectorPhoneNumberTextBox.Text = data.ProtectorPhoneNumber;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToggleInput(bool status)
        {
            FullNameTextBox.Enabled = status;
            BirthdayDateTimePicker.Enabled = status;
            PhoneNumberTextBox.Enabled = status;
            BirthPlaceTextBox.Enabled = status;
            AddressTextBox.Enabled = status;
            AcademicLevelComboBox.Enabled = status;
            HealthConditionsComboBox.Enabled = status;
            FatherFullNameTextBox.Enabled = status;
            FatherPhoneNumberTextBox.Enabled = status;
            MotherFullNameTextBox.Enabled = status;
            MotherPhoneNumberTextBox.Enabled = status;
            ProtectorFullNametextBox.Enabled = status;
            ProtectorPhoneNumberTextBox.Enabled = status;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            IconButton editButton = (IconButton)sender;
            editButton.Visible = false;
            SaveButton.Visible = true;
            CancelButton.Visible = true;
            UpdateAvatarButton.Visible = true;
            DeleteButton.Visible = false;

            ToggleInput(true);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            IconButton cancelButton = (IconButton)sender;
            cancelButton.Visible = false;
            SaveButton.Visible = false;
            EditButton.Visible = true;
            UpdateAvatarButton.Visible = false;
            DeleteButton.Visible = true;

            ToggleInput(false);
        }

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            if (data.Avatar == null)
            {
                AvatarPictureBox.Image.Save(ms, ImageFormat.Jpeg);
            }
            byte[] buffer = ms.GetBuffer();
            string avatarBase64String = Convert.ToBase64String(buffer);

            Child updateChildren = new Child
            {
                Avatar = avatarBase64String ?? data.Avatar,
                FullName = FullNameTextBox.Text,
                Birthday = BirthdayDateTimePicker.Value.ToUniversalTime().ToString("dd/MM/yyyy"),
                BirthPlace = BirthPlaceTextBox.Text,
                PhoneNumber = PhoneNumberTextBox.Text,
                Address = AddressTextBox.Text,
                AcademicLevel = AcademicLevelComboBox.Text,
                HealthCondition = HealthConditionsComboBox.Text,
                FatherFullName = FatherFullNameTextBox.Text,
                FatherPhoneNumber = FatherPhoneNumberTextBox.Text,
                MotherFullName = MotherFullNameTextBox.Text,
                MotherPhoneNumber = MotherPhoneNumberTextBox.Text,
                ProtectorFullName = ProtectorFullNametextBox.Text,
                ProtectorPhoneNumber = ProtectorPhoneNumberTextBox.Text
            };

            DocumentReference doc = db.Collection("children").Document(data.Id);
            await doc.SetAsync(updateChildren);
            DocumentSnapshot snapshot = await doc.GetSnapshotAsync();
            MessageBox.Show($"Cập nhật thông tin bạn {snapshot.GetValue<string>("FullName")} thành công!");

            IconButton saveButton = (IconButton)sender;
            saveButton.Visible = false;
            CancelButton.Visible = false;
            EditButton.Visible = true;
            UpdateAvatarButton.Visible = false;
            DeleteButton.Visible = true;
            ToggleInput(false);
        }

        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            DocumentReference doc = db.Collection("children").Document(data.Id);

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", buttons);

            if (result == DialogResult.Yes)
            {
                await doc.DeleteAsync();
                MessageBox.Show("Xóa thành công!");
                this.Close();
            }
        }
    }
}
