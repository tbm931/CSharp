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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Manager m = new Manager();
            m.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Saleman s = new Saleman();
            s.Show();
        }
    }
}
