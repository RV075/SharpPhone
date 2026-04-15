using System;
using System.Linq;
using System.Windows.Forms;

namespace SharpPhone
{
    public partial class FormLogin : Form
    {
        private SharpPhoneFileStorage storage = new SharpPhoneFileStorage();
        private SharpPhoneDataStore data;

        public FormLogin()
        {
            InitializeComponent();
            data = storage.Load();
            MessageBox.Show("Users count = " + data.Users.Count);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text.Trim();
            var password = txtPassword.Text.Trim();

            var user = data.Users.FirstOrDefault(u => u.Username == username);

            if (user == null)
            {
                lblError.Text = "Fout";
                return;
            }

            if (user.Password != password)
            {
                user.FailedAttempts++;

                if (user.FailedAttempts >= 3)
                {
                    storage.Save(data);
                    Application.Exit();
                    return;
                }

                storage.Save(data);
                lblError.Text = "Fout";
                return;
            }

            user.FailedAttempts = 0;
            storage.Save(data);

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}