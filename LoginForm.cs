using Google.Cloud.Firestore;
using System;
using System.Windows.Forms;

namespace ScholarshipManagement.Forms
{
    public partial class LoginForm : Form
    {
        private readonly string path = AppDomain.CurrentDomain.BaseDirectory + @"winform-project.json";
        public FirestoreDb db;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            db = FirestoreDb.Create("winform-project");
        }

        private async void HandleLogin()
        {
            try
            {
                DocumentReference doc = db.Collection("users").Document(UsernameTextBox.Text);
                DocumentSnapshot snapshot = await doc.GetSnapshotAsync();
                if (snapshot.GetValue<string>("Password") == PasswordTextBox.Text)
                {
                    MessageBox.Show("Đăng nhập thành công!");
                    this.Hide();
                    MainForm mainForm = new MainForm(db);
                    mainForm.Show();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Đăng nhập thất bại!");
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            HandleLogin();
        }

        private void LoginForm_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Enter) HandleLogin();
        }
    }
}
