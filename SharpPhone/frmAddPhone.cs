using System;
using System.Windows.Forms;

namespace SharpPhone
{
    public partial class frmAddPhone : Form
    {
        private ClassSmartPhone? editPhone;

        public ClassSmartPhone? Phone { get; private set; }

        public frmAddPhone()
        {
            InitializeComponent();
        }

        public frmAddPhone(ClassSmartPhone phone)
        {
            InitializeComponent();

            editPhone = phone;

            txtBrand.Text = phone.Brand;
            txtModel.Text = phone.Model;
            txtSize.Text = phone.StorageSizeMb.ToString();
            txtPrice.Text = phone.Price.ToString();
            txtStock.Text = phone.Stock.ToString();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int size = int.Parse(txtSize.Text);
            decimal price = decimal.Parse(txtPrice.Text);
            int stock = int.Parse(txtStock.Text);

            if (editPhone == null)
            {
                Phone = new ClassSmartPhone(0, txtBrand.Text, txtModel.Text, size, price)
                {
                    Stock = stock
                };
            }
            else
            {
                editPhone.Brand = txtBrand.Text;
                editPhone.Model = txtModel.Text;
                editPhone.StorageSizeMb = size;
                editPhone.Price = price;
                editPhone.Stock = stock;

                Phone = editPhone;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void frmAddPhone_Load(object sender, EventArgs e)
        {

        }
    }
}