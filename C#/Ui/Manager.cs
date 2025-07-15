using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ui
{
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        private void productsbtn_Click(object sender, EventArgs e)
        {
            Products products = new Products();
            products.Show();
        }

        private void customersbtn_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers();
            customers.Show();
        }

        private void sales_Click(object sender, EventArgs e)
        {
            Sales sales = new Sales();
            sales.Show();
        }

        private void Manager_Load(object sender, EventArgs e)
        {

        }
    }
}
