using BO;

namespace Ui
{
    public partial class Customers : Form
    {
        static BlApi.IBl? _bl;
        static List<Customer?>? customers;
        public Customers()
        {
            InitializeComponent();
            _bl = BlApi.Factory.Get();
            customers = _bl.Customer.ReadAll();
            dcustomerscmb.DataSource = customers;
            dcustomerscmb.DisplayMember = "Name";
            dcustomerscmb.ValueMember = "Id";
            unamecmb.DataSource = customers;
            unamecmb.DisplayMember = "Name";
            unamecmb.ValueMember = "Id";
            List<Customer> list = _bl.Customer.ReadAll();
            foreach (var c in list)
            {
                allCustomerslb.Items.Add("מספר זהות: " + c.Id);
                allCustomerslb.Items.Add("שם הלקוח: " + c.Name);
                allCustomerslb.Items.Add("מספר טלפון: " + c.Telephone);
                allCustomerslb.Items.Add("כתובת: " + c.Address);
                allCustomerslb.Items.Add("________________________________");

            }
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                Customer? c = new(int.Parse(aidtxt.Text), anametxt.Text, aadresstxt.Text, aphonetxt.Text);
                _bl!.Customer.Create(c);
                customers = _bl.Customer.ReadAll();
                dcustomerscmb.DataSource = customers;
                unamecmb.DataSource = customers;
                MessageBox.Show("Customer added successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                Customer? selectedproduct = (Customer)unamecmb.SelectedItem!;
                Customer? c = new(int.Parse(uidtxt.Text), selectedproduct!.Name, uadresstxt.Text, uphonetxt.Text);
                _bl!.Customer.Update(c);
                customers = _bl.Customer.ReadAll();
                dcustomerscmb.DataSource = customers;
                unamecmb.DataSource = customers;
                MessageBox.Show("Customer updated successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                Customer? customer = (Customer)unamecmb.SelectedItem!;
                _bl!.Customer.Delete(customer.Id);
                customers = _bl.Customer.ReadAll();
                dcustomerscmb.DataSource = customers;
                unamecmb.DataSource = customers;
                MessageBox.Show("Customer deleted successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void unamecmb_SelectedValueChanged(object sender, EventArgs e)
        {
            Customer customer = (Customer)unamecmb.SelectedItem!;
            if (customer != null)
            {
                uidtxt.Text = customer.Id.ToString();
                uadresstxt.Text = customer.Address;
                uphonetxt.Text = customer.Telephone;
            }
        }

       
    }
}
