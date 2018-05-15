using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14_4_Teleloto
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        int[,] Skaiciukai = new int[6, 6];/* { { 0, 0,0,0,0,0 }, { 1, 2, 4, 5, 8, 9 }, { 1, 2, 4, 5, 8, 9 }, { 1, 2, 4, 5, 8, 9 }, { 1, 2, 4, 5, 8, 9 }, { 1, 2, 4, 5, 8, 9 } };*/


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            string Eile = "";
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    var Skaicius = random.Next(10, 100);
                    Skaiciukai[i, j] = Skaicius;
                    Eile += Skaiciukai[i, j].ToString() + " ";

                    // dataGridView1.Rows[i].Cells.Add(Skaicius);

                }
                Eile += "\n";
            }

            // dataGridView1.DataSource = Skaiciukai;
            button2.Enabled = true;
            MessageBox.Show(Eile);


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var Skaicius1 = new int[50];
            for (int i = 0; i < 50; i++)
            {
                Skaicius1[i] = random.Next(10, 101);
            }
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    for (int k = 0; k < 50; k++)
                    {
                        if (Skaiciukai[i, j] == Skaicius1[k])
                        {
                            Skaiciukai[i, j] = 0;
                        }
                    }

                }

            }

            string Eile = "";
            int Counteris = 0;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (Skaiciukai[i, j] != 0)
                    {

                        Eile += Skaiciukai[i, j].ToString() + " ";
                    }
                    else if (Skaiciukai[i, j] == 0)
                    {
                        Eile += "---" + " ";
                        Counteris++;
                    }


                }
                Eile += "\n";
            }
            if (Counteris == 36)
            {
                MessageBox.Show("LAIMEEEJOOOTE");
            }
            else
            {
                MessageBox.Show(Eile);
            }


            Close();




        }
    }
}
