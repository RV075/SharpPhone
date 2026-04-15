using System;
using System.Linq;
using System.Windows.Forms;

namespace SharpPhone
{
    public partial class Form1 : Form
    {
        private SharpPhoneFileStorage storage = new SharpPhoneFileStorage();
        private SharpPhoneDataStore data;

        public Form1()
        {
            InitializeComponent();
            data = storage.Load();
            RefreshList();
        }

        private void RefreshList()
        {
            listBoxPhones.Items.Clear();

            foreach (var phone in data.Phones)
            {
                listBoxPhones.Items.Add(phone);
            }
        }

        private int GetNextId()
        {
            if (data.Phones.Count == 0)
                return 0;

            return data.Phones.Max(p => p.Id) + 1;
        }

        private void btnAddPhone_Click(object sender, EventArgs e)
        {
            using var form = new frmAddPhone();

            if (form.ShowDialog() != DialogResult.OK)
                return;

            var phone = form.Phone;
            phone.Id = GetNextId();

            data.Phones.Add(phone);

            RefreshList();
            storage.Save(data);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBoxPhones.SelectedIndex == -1)
                return;

            data.Phones.RemoveAt(listBoxPhones.SelectedIndex);

            RefreshList();
            storage.Save(data);
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (listBoxPhones.SelectedIndex == -1)
                return;

            var phone = data.Phones[listBoxPhones.SelectedIndex];

            using var form = new frmAddPhone(phone);

            if (form.ShowDialog() != DialogResult.OK)
                return;

            RefreshList();
            storage.Save(data);
        }
    }
}