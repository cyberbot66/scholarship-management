using Google.Cloud.Firestore;
using ScholarshipManagement.Models;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace ScholarshipManagement.Forms
{
    public partial class AddChildForm : Form
    {
        public FirestoreDb db;

        public AddChildForm(FirestoreDb firestore)
        {
            InitializeComponent();
            db = firestore;
        }

        private async void AddChildrenForm_Load(object sender, EventArgs e)
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
        }

        private void UploadAvatarButton_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg|  PNG files(*.png)|*.png";

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

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            AvatarPictureBox.Image.Save(ms, ImageFormat.Jpeg);

            byte[] buffer = ms.GetBuffer();
            string avatarBase64String = Convert.ToBase64String(buffer);

            Child newChildren = new Child
            {
                Avatar = avatarBase64String,
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

            DocumentReference doc = await db.Collection("children").AddAsync(newChildren);
            DocumentSnapshot snapshot = await doc.GetSnapshotAsync();

            MessageBox.Show($"Đã thêm bạn {snapshot.GetValue<string>("FullName")} thành công!");
            this.Close();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
