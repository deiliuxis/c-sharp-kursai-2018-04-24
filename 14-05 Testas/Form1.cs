using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14_05_Testas
{
    public partial class PirmaForma : Form
    {
        List<char> Raideles = new List<char>();
        
        public PirmaForma()
        {
            InitializeComponent();
           
            
        }

       

        string zodis = "";
        private void button3_Click(object sender, EventArgs e)
        {
            zodis = textBox1.Text;
            MessageBox.Show("Zaidimas pradėtas :)) SĖKMĖS");
            label2.Visible = true;
            button1.Visible = true;
            textBox2.Visible = true;
            label1.Visible = false;
            button3.Visible = false;
            textBox1.Visible = false;



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }




        int Counteris = 0;
        private void button1_Click(object sender, EventArgs e)
        {
           
            var Zodis = "";
            
            for (int i = 0; i < zodis.Length; i++)
            {
                Zodis += "*";
            }

            

            var Raide = textBox2.Text;
           

            if (Raide.Length == 1 && Regex.IsMatch(Raide, @"^[a-zA-Z]+$"))
            {
                string uzvertas = "";
                Raideles.Add(Raide[0]);

                
                foreach (var raide in zodis)
                {
                    
                    if (Raideles.Contains(raide))
                    {
                        
                        uzvertas += raide;
                       

                    }
                    else
                    {
                        uzvertas += "*";
                       
                        
                    }
                   

                }

                if (uzvertas.Contains(Raide))
                {
                    
                }
                else
                {
                    Counteris++;
                }
                ManoZodis.Text = uzvertas;
                Panaudotos.Text += Raide + "  ";
                if (Counteris == 0)
                {
                    MessageBox.Show(uzvertas);
                    
                }
                else if (Counteris == 1)
                {
                    MessageBox.Show(uzvertas);
                    Pirmas.Visible = false;
                    Antras.Visible = false;
                    Trecias.Visible = true;
                    Ketvirtas.Visible = false;
                    Penkta.Visible = false;
                    Sesta.Visible = false;
                    Septinta.Visible = false;
                   
                }
                else if (Counteris == 2)
                {
                    MessageBox.Show(uzvertas);
                    Pirmas.Visible = true;
                    Antras.Visible = false;
                    Trecias.Visible = true;
                    Ketvirtas.Visible = false;
                    Penkta.Visible = false;
                    Sesta.Visible = false;
                    Septinta.Visible = false;
                }
                else if (Counteris == 3)
                {
                    MessageBox.Show(uzvertas);
                    Pirmas.Visible = true;
                    Antras.Visible = true;
                    Trecias.Visible = true;
                    Ketvirtas.Visible = false;
                    Penkta.Visible = false;
                    Sesta.Visible = false;
                    Septinta.Visible = false;
                }
                else if (Counteris == 4)
                {
                    MessageBox.Show(uzvertas);
                    Pirmas.Visible = true;
                    Antras.Visible = true;
                    Trecias.Visible = true;
                    Ketvirtas.Visible = true;
                    Penkta.Visible = false;
                    Sesta.Visible = false;
                    Septinta.Visible = false;
                }
                else if (Counteris == 5)
                {
                    MessageBox.Show(uzvertas);
                    Pirmas.Visible = true;
                    Antras.Visible = true;
                    Trecias.Visible = true;
                    Ketvirtas.Visible = true;
                    Penkta.Visible = true;
                    Sesta.Visible = false;
                    Septinta.Visible = false;
                }
                else if (Counteris == 6)
                {
                    MessageBox.Show(uzvertas);
                    Pirmas.Visible = true;
                    Antras.Visible = true;
                    Trecias.Visible = true;
                    Ketvirtas.Visible = true;
                    Penkta.Visible = true;
                    Sesta.Visible = true;
                    Septinta.Visible = false;
                }
                else if (Counteris == 8)
                {
                    
                    Pirmas.Visible = true;
                    Antras.Visible = true;
                    Trecias.Visible = true;
                    Ketvirtas.Visible = true;
                    Penkta.Visible = true;
                    Sesta.Visible = true;
                    Septinta.Visible = true;
                    MessageBox.Show("Pasikorete :)))))))");
                    Close();
                }



                if (uzvertas == zodis)
                {
                    MessageBox.Show("Laimėjai :))))");
                    Close();
                }





            }
            else
            {
                MessageBox.Show("Ivedete ne ta simboli arba skaiciu");
            }
    
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Antras_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            Counteris--;
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Counteris--;
            
        }

        private void PirmaForma_Load(object sender, EventArgs e)
        {

        }
    }
}
