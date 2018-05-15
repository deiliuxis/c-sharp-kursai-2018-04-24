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

namespace _14_02_su_file2
{
    public partial class Darbelis : Form
    {
        List<Gyvunai> gyvuneliai = new List<Gyvunai>();
        public Darbelis()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void atidarytiToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void uzdarytiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pasirinktiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var failas = new OpenFileDialog())
            {
                if (failas.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var Tekstas = File.ReadAllLines(failas.FileName);

                        foreach (var eilute in Tekstas)
                        {
                            var gyvunas = new Gyvunai(eilute);

                            gyvuneliai.Add(new Gyvunai(eilute));
                        }
                        dataGridView1.DataSource = gyvuneliai;
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private Gyvunai Jauniausias()
        {
            var indeksas = 0;
            var Jauniausias = gyvuneliai.First();
            for (int i = 0; i < gyvuneliai.Count; i++)
            {
                
                if (Jauniausias.Amzius < gyvuneliai[i].Amzius)
                {
                    Jauniausias.Amzius = gyvuneliai[i].Amzius;
                    indeksas = i;
                }
            }
            //return indeksas;
            //label2.Text = gyvuneliai.ElementAt(indeksas).Vardas;
            return Jauniausias;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            var indeksas = 0;
            var Vyriausias = gyvuneliai.First();
            for (int i = 0; i > gyvuneliai.Count; i++)
            {

                if (Vyriausias.Amzius < gyvuneliai[i].Amzius)
                {
                    Vyriausias.Amzius = gyvuneliai[i].Amzius;
                    indeksas = i;
                }
            }
            //return indeksas;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            label2.Text = Jauniausias().Vardas;
        }
    }
}
