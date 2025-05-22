using BO;

namespace Ui
{
    public partial class Products : Form
    {
        static BlApi.IBl _bl = BlApi.Factory.Get();
        static List<Product?>? products;
        public Products()
        {
            InitializeComponent();
            products = _bl.Product.ReadAll();
            acategorycmb.DataSource = Enum.GetValues(typeof(Categories));
            ucategorycmb.DataSource = Enum.GetValues(typeof(Categories));
            dproductscmb.DataSource = products;
            uproductcmb.DataSource = products;
            uproductcmb.DisplayMember = "Name";
            uproductcmb.ValueMember = "Id";
            dproductscmb.DisplayMember = "Name";
            dproductscmb.ValueMember = "Id";
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                _bl.Product.Delete((int)dproductscmb.SelectedValue);
                products = _bl.Product.ReadAll();
                dproductscmb.DataSource = products;
                uproductcmb.DataSource = products;
                MessageBox.Show("Product deleted successfully");
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
                Product selectedproduct = (Product)uproductcmb.SelectedItem!;
                Product p = new(selectedproduct!.Id, selectedproduct.Name, (Categories)ucategorycmb.SelectedValue, (double)upricenud.Value, (int)ucntnud.Value);
                _bl.Product.Update(p);
                products = _bl.Product.ReadAll();
                dproductscmb.DataSource = products;
                uproductcmb.DataSource = products;
                MessageBox.Show("Product updated successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                Product p = new(0, anametxt.Text, (Categories)acategorycmb.SelectedValue!, (double)apricenud.Value, (int)acntnud.Value);
                _bl.Product.Create(p);
                //products!.Add(p);
                products = _bl.Product.ReadAll();
                dproductscmb.DataSource = products;
                uproductcmb.DataSource = products;
                MessageBox.Show("Product added successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Uproductcmb_SelectedValueChanged(object sender, EventArgs e)
        {
            Product product = (Product)uproductcmb.SelectedItem!;
            if (product != null)
            {
                ucategorycmb.SelectedItem = product.Category;
                upricenud.Value = (decimal)product.Price;
                ucntnud.Value = product.Count;
            }
        }
    }
}
