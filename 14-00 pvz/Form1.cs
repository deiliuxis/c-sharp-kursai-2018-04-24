﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Obelis yra vaisius"); // mbox
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Suklydote sori :)))");
        }

        private void Ar_Tiesa_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Suklydote sori :)))");

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Suklydote sori :)))");

        }

        private void button2_Click(object sender, EventArgs e)
        {
           // MessageBox.Show(tekstoLaukelis.Text);
            var skaicius = Convert.ToInt32(tekstoLaukelis.Text);
            MessageBox.Show(skaicius.ToString());
            tekstoLaukelis.Text = "";
        }

       

        private void perkeltii_Click(object sender, EventArgs e)
        {
            var skaicius = Convert.ToInt32(perkelti.Text);
            var forma = new GautiDuomenysForma(skaicius);
            forma.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var forma = new IvestiForma())
            {
                forma.ShowDialog();

                if (forma.DialogResult == DialogResult.OK)
                {
                    label1.Text = forma.Tekstas;
                    
                }
            }

        }
    }
}
