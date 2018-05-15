using System;
using HtmlAgilityPack;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Text.RegularExpressions;

namespace _14_03_Herllo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var url = textBox1.Text;
            textBox1.Text = "";
            GautiHTML(url);
        }

        private static async void GautiHTML(string url) // async vyks toliau darbas kol vyskta nuskaitymas
        {
            var httpClient = new HttpClient();
            var html = await httpClient.GetStringAsync(url);
            var htmlDocument = new HtmlAgilityPack.HtmlDocument();
            htmlDocument.LoadHtml(html);

            var produktuSarasas = htmlDocument.DocumentNode.Descendants("div")
                .Where(x => x.GetAttributeValue("class", "")
                     .Equals("auto-lists lt")).ToList();

            var produktuElementai = produktuSarasas[0].Descendants("a")
                .Where(x => x.GetAttributeValue("class", "")
                .Contains("announcement-item")).ToList();

            /* var produktuPavadinimai = produktuSarasas[0].Descendants("div")
                .Where(x => x.GetAttributeValue("class", "")
                .Contains("announcement-title")).ToList();

             var produktuKaina = produktuSarasas[0].Descendants("div")
               .Where(x => x.GetAttributeValue("class", "")
               .Contains("announcement-pricing-info")).ToList();
 */

            string Vardas = "";
            int Brangiausia = 0;
            foreach (var htmlNode in produktuElementai)
            {
                var produktuPavadinimai = htmlNode.Descendants("div")
              .Where(x => x.GetAttributeValue("class", "")
              .Contains("announcement-title")).ToList();

                var produktuKaina = htmlNode.Descendants("div")
                  .Where(x => x.GetAttributeValue("class", "")
                  .Contains("announcement-pricing-info")).ToList();

                var KainaApkarpyta = Regex.Replace(produktuKaina.First().InnerText, "/.* ", "");
              
                var KainaPusiau = Regex.Replace(KainaApkarpyta, @"\s+", "");
                var Kaina = Convert.ToInt32(Regex.Replace(KainaPusiau, "€", ""));

                Vardas += produktuPavadinimai.First().InnerText.Trim() + " " + produktuKaina.First().InnerText.Trim() + " :)))\n"; // trim apkarpo || \n nauja eilute || innertext Paima vidurini teksta || o first nes tik vienas sarase gaunas narys tuo metu
                



                if (Kaina > Brangiausia)
                {
                    Brangiausia = Kaina;
                }
            }

           

            MessageBox.Show(Vardas);
            MessageBox.Show("Brangiausia masinos kaina: "+ Brangiausia.ToString() + " €");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
