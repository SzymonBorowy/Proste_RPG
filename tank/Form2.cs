using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tank
{
    public partial class Form2 : Form
    {
        public string atak_bohatera ;
        public string atak_przeciwnika ;
        public string hp_bohatera ;
        public string hp_przeciwnika ;
        public bool ucieczka = false;
        int pom = 1;
        public Form2(string atak_boh, string atak_prz, string hp_boh, string hp_prz)
        {
            InitializeComponent();
            ucieczka = false;
            atak_bohatera= atak_boh;
            atak_przeciwnika = atak_prz ;
            hp_bohatera= hp_boh ;
            hp_przeciwnika= hp_prz ;
            textBox1.Text += "HP: " + hp_bohatera + " HP przeciwnika: " + hp_przeciwnika + Environment.NewLine;
        }

        private void atak_przycisk_Click(object sender, EventArgs e)
        {
            #region atak krytyczny
            if (pom % 5 == 0)
            {
                pom = 1;
                atak atak = new atak();
                hp_przeciwnika = (Int32.Parse(hp_przeciwnika) - (Int32.Parse(atak_bohatera) + (Int32.Parse(atak_bohatera) * atak.los_1))).ToString();
                textBox1.Text += "Atakujesz krytycznie za " + (Int32.Parse(atak_bohatera) + (Int32.Parse(atak_bohatera) * atak.los_1)) + Environment.NewLine + "HP przeciwnika: " + hp_przeciwnika + Environment.NewLine;
                if (Int32.Parse(hp_przeciwnika) <= 0)
                {
                    textBox1.Text += Environment.NewLine + "Przeciwnik nie żyje";
                    atak_przycisk.Enabled = false;
                    uciekaj.Enabled = false;
                    this.Close();
                }
                else
                {
                    textBox1.Text += "Przeciwnik atakuje za " + (Int32.Parse(atak_przeciwnika) + atak.los_2) + Environment.NewLine + "HP: " + hp_bohatera + Environment.NewLine;
                }
                if (Int32.Parse(hp_bohatera) <= 0)
                {
                    textBox1.Text += Environment.NewLine + "Nie żyjesz";
                    atak_przycisk.Enabled = false;
                    uciekaj.Enabled = false;
                    this.Close();
                }
            }
            #endregion
            #region atak
            else
            {
                pom++;
                atak atak = new atak();
                hp_przeciwnika = atak.atak_bohatera(Int32.Parse(hp_przeciwnika), Int32.Parse(atak_bohatera));          
                textBox1.Text += "Atakujesz za " + (Int32.Parse(atak_bohatera) + atak.los_1) + Environment.NewLine + "HP przeciwnika: " + hp_przeciwnika + Environment.NewLine;
                if (Int32.Parse(hp_przeciwnika) <= 0)
                {
                    textBox1.Text += Environment.NewLine + "Przeciwnik nie żyje";
                    atak_przycisk.Enabled = false;
                    uciekaj.Enabled = false;
                    this.Close();
                }
                else
                {
                    hp_bohatera = atak.atak_potwora(Int32.Parse(hp_bohatera), Int32.Parse(atak_przeciwnika));
                    textBox1.Text += "Przeciwnik atakuje za " + (Int32.Parse(atak_przeciwnika) + atak.los_2) + Environment.NewLine + "HP: " + hp_bohatera + Environment.NewLine;
                    if (Int32.Parse(hp_bohatera) <= 0)
                    {
                        textBox1.Text += Environment.NewLine + "Nie żyjesz";
                        atak_przycisk.Enabled = false;
                        uciekaj.Enabled = false;
                        this.Close();
                    }
                }

                
            }
            #endregion
        }

        private void uciekaj_Click(object sender, EventArgs e)
        {
            ucieczka = true;
            this.Close();
        }
   }
 }
