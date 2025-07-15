using BO;

namespace Ui
{
    public partial class Sales : Form
    {
        static BlApi.IBl _bl = BlApi.Factory.Get();
        static List<Sale>? sales;
        public Sales()
        {
            InitializeComponent();
            sales = _bl.Sale.ReadAll()!;
            aproductscmb.DataSource = _bl.Product.ReadAll();
            aproductscmb.DisplayMember = "Name";
            aproductscmb.ValueMember = "Id";
            upsalecmb.DataSource = sales;
            //aproductscmb.DisplayMember = "Name";
            upsalecmb.ValueMember = "Id";
            dproductscmb.DataSource = sales;
            //aproductscmb.DisplayMember = "Name";
            dproductscmb.ValueMember = "Id";
            List<Sale> list = _bl.Sale.ReadAll();
            foreach (var s in list)
            {
                allSaleslb.Items.Add("מזהה מבצע: " + s.Id);
                allSaleslb.Items.Add("מזהה מוצר: " + s.ProdId);
                allSaleslb.Items.Add("כמות מינימלית למבצע: " + s.MinCount);
                allSaleslb.Items.Add("מחיר כולל: " + s.AllPrice);
                allSaleslb.Items.Add("המבצע תקף מהתאריך: " + s.Begin);
                allSaleslb.Items.Add("עד התאריך: " + s.Finish);
                allSaleslb.Items.Add("האם רק ללקוחות המועדון: " + !s.IsToAll);
                allSaleslb.Items.Add("________________________________");

            }
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                Sale s = new Sale(0, (int)aproductscmb.SelectedValue!, (int)amincntnud.Value, (int)apricenud.Value, !apreferednud.Checked, abegindate.Value, aenddate.Value);
                _bl.Sale.Create(s);
                sales = _bl.Sale.ReadAll()!;
                dproductscmb.DataSource = sales;
                upsalecmb.DataSource = sales;
                MessageBox.Show("Sale added successfully");
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
                Sale? selectedSale = (Sale)upsalecmb.SelectedItem;
                Sale s = new Sale(selectedSale!.Id, (int)selectedSale.ProdId!, (int)(double)umincntnud.Value, (int)upricenud.Value, !upreferedcb.Checked, ubegindate.Value, uenddate.Value);
                _bl.Sale.Update(s);
                sales = _bl.Sale.ReadAll()!;
                dproductscmb.DataSource = sales;
                upsalecmb.DataSource = sales;
                MessageBox.Show("Sale updated successfully");
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
                _bl.Sale.Delete((int)dproductscmb.SelectedValue!);
                sales = _bl.Sale.ReadAll()!;
                dproductscmb.DataSource = sales;
                upsalecmb.DataSource = sales;
                MessageBox.Show("Sale deleted successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void upsalecmb_SelectedValueChanged(object sender, EventArgs e)
        {
            Sale sale = (Sale)upsalecmb.SelectedItem!;
            if (sale != null)
            {
                umincntnud.Value = sale.MinCount;
                upricenud.Value = (decimal)sale.AllPrice;
                upreferedcb.Checked = !sale.IsToAll;
                ubegindate.Value = (DateTime)sale.Begin!;
                uenddate.Value = (DateTime)sale.Finish!;
            }
        }
    }
}
