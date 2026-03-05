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
            //SmartPhone newPhone = new SmartPhone(1, "Apple", "iPhone 14 Pro", 256000

            // Show Form addEdit

            Form frmAddEdit = new frmAddEdit();
            frmAddEdit.ShowDialog();
        }
    }
}
