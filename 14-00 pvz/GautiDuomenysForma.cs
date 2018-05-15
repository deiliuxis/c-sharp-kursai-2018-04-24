using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14_00_pvz
{
    public partial class GautiDuomenysForma : Form
    {
        public GautiDuomenysForma(int skaicius)
        {
            InitializeComponent();
            label1.Text = skaicius.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
