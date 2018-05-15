using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace _14_01_su_file
{
    public partial class Form1 : Form
    {
        public List<Automobilis> Automobiliai { get; set; }
        public Form1()
        {
            InitializeComponent();
            Automobiliai = new List<Automobilis>();
        }

        private void iseitiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void atidarytiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var failas = new OpenFileDialog())
            {
                failas.InitialDirectory = "c:\\users\\Deividas\\Darbalaukis\\Automobiliai.csv";
                failas.Filter = "csv failas (*.csv)|*.csv";
                

                //MessageBox.Show(failas.FileName);

                if (failas.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var tekstas = File.ReadAllLines(failas.FileName);

                        foreach (var eilute in tekstas)
                        {
                            //   MessageBox.Show(eilute);

                            var auto = new Automobilis(eilute);

                            // Automobiliai.Add(auto);

                            Automobiliai.Add(new Automobilis(eilute));



                        }
                        dataGridView1.DataSource = Automobiliai;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                    }
                }
            }
        }
    }
}
