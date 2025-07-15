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
            List<Help> help = new List<Help>();
            DO.categories[] categories = (DO.categories[])Enum.GetValues(typeof(Categories));
            for (int i = 0; i < categories.Length; i++)
                help.Add(new Help(categories[i].ToString().Replace("_", " "), categories[i]));
            acategorycmb.DataSource = help;
            acategorycmb.ValueMember = "category";
            acategorycmb.DisplayMember = "name";
            ucategorycmb.DataSource = help;
            ucategorycmb.ValueMember = "category";
            ucategorycmb.DisplayMember = "name";
            List<Help> help2 = new List<Help>(help);
            help2.Add(new Help("הכל", DO.categories.אלקטרוניקה));
            findcmb.DataSource = help;
            findcmb.ValueMember = "category";
            findcmb.DisplayMember = "name";
            List<Product> list = _bl.Product.ReadAll();
            foreach (var p in list)
            {
                allProductslb.Items.Add("קוד מוצר: " + p.Id);
                allProductslb.Items.Add("שם המוצר: " + p.Name);
                allProductslb.Items.Add("קטגוריה: " + p.Category.ToString().Replace("_", " "));
                allProductslb.Items.Add("מחיר: " + p.Price);
                allProductslb.Items.Add("כמות: " + p.Count);
                allProductslb.Items.Add("________________________________");

            }
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
                //delete the sales of deleted product
                while (_bl.Sale.ReadAll(s => s.ProdId == (int)dproductscmb.SelectedValue).Count > 0)
                    _bl.Sale.Delete((int)_bl.Sale.ReadAll(s => s.ProdId == (int)dproductscmb.SelectedValue).First().Id);
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

        private void findbtn_Click(object sender, EventArgs e)
        {

        }
    }
    public class Help
    {
        public string Name { get; set; }
        public DO.categories Category { get; set; }
        public Help(string name, DO.categories category)
        {
            this.Name = name;
            this.Category = category;
        }
    }
}
