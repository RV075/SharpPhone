namespace SharpPhone
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnModify_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("delete button clicked");
        }

        private void btnAddPhone_Click(object sender, EventArgs e)
        {
            SmartPhone newPhone = new SmartPhone(1, "Apple", "iPhone 14 Pro", 256000, 999.99m);
            //MessageBox.Show(newPhone.Brand);

            List<SmartPhone> phones = new List<SmartPhone>();
            phones.Add(newPhone);

            phones.Add(
                new SmartPhone(2, "Apple", "iPhone 15 Pro Max", 512000, 1
                );

            foreach (SmartPhone phone in phones) // foreach (var item in phones)
            {
                MessageBox.Show(phone.Brand); // MessageBox.Show(item.Brand);
            }

            // Show Form addEdit

            Form frmAddEdit = new frmAddEdit();
            frmAddEdit.ShowDialog();
        }
    }
}
