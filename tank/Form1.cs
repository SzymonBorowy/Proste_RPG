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
    public partial class Form1 : Form
    {
        int aaaaaa;
        bool right;
        bool left;
        bool up;
        bool down;
        int atak_bohatera = 25;
        int zycie_bohatera = 1000;
        int zloto = 150;
        int doswiadczenie = 0;
        int level = 1;
        int zycie_bohatera_max = 1000;
        int atak_balwana = 5;
        int zycie_balwana = 40;
        int atak_zjawa = 50;
        int zycie_zjawa = 250;
        int atak_medyk = 150;
        int zycie_medyk = 2500;
        int atak_boss = 1;
        int zycie_boss = 5000;
        int czas = 1;
        int liczba_zabitych_balwan = 0;
        int liczba_zabitych_zjawa = 0;
        Random random = new Random();
        int x;        //losowa pozycja x    
        int y;        //losowa pozycja y
        Form2 form2;
        public Form1()
        {
            InitializeComponent();
            hp.Text = zycie_bohatera.ToString()+ " / "+ zycie_bohatera_max.ToString();
            atak.Text = atak_bohatera.ToString();
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(this.postac, "Zjawa \nHP: 250 \nAtak: 50");
            toolTip1.SetToolTip(this.medyk, "Medyk \nHP: 2500 \nAtak: 150");
            toolTip1.SetToolTip(this.balwan, "Bałwan \nHP: 40 \nAtak: 5");
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            #region boss
            // boss
            if (boss.Visible)
            {
                if (player.Right + 10 > boss.Left && player.Left < boss.Right && player.Bottom > boss.Top && player.Top < boss.Bottom)
                {
                    right = false;
                }
                if (player.Left - 10 < boss.Right && player.Right > boss.Left && player.Bottom > boss.Top && player.Top < boss.Bottom)
                {
                    left = false;
                }

                if (player.Bottom + 10 > boss.Top && player.Top < boss.Bottom && player.Right > boss.Left && player.Left < boss.Right)
                {
                    down = false;
                }
                if (player.Top - 10 < boss.Bottom && player.Bottom > boss.Top && player.Right > boss.Left && player.Left < boss.Right)
                {
                    up = false;
                }
            }
            #endregion
            #region postac
            toolTip1.SetToolTip(this.player, "Player \nHP: " + zycie_bohatera + " \nAtak: " + atak_bohatera);
            // postac
            if (postac.Visible)
            {
                if (player.Right + 10 > postac.Left && player.Left < postac.Right && player.Bottom > postac.Top && player.Top < postac.Bottom)
                {
                    right = false;
                }
                if (player.Left - 10 < postac.Right && player.Right > postac.Left && player.Bottom > postac.Top && player.Top < postac.Bottom)
                {
                    left = false;
                }

                if (player.Bottom + 10 > postac.Top && player.Top < postac.Bottom && player.Right > postac.Left && player.Left < postac.Right)
                {
                    down = false;
                }
                if (player.Top - 10 < postac.Bottom && player.Bottom > postac.Top && player.Right > postac.Left && player.Left < postac.Right)
                {
                    up = false;
                }
            }
            #endregion
            #region medyk
            // medyk
            if (medyk.Visible)
            {
                if (player.Right + 10 > medyk.Left && player.Left < medyk.Right && player.Bottom > medyk.Top && player.Top < medyk.Bottom)
                {
                    right = false;
                }
                if (player.Left - 10 < medyk.Right && player.Right > medyk.Left && player.Bottom > medyk.Top && player.Top < medyk.Bottom)
                {
                    left = false;
                }

                if (player.Bottom + 10 > medyk.Top && player.Top < medyk.Bottom && player.Right > medyk.Left && player.Left < medyk.Right)
                {
                    down = false;
                }
                if (player.Top - 10 < medyk.Bottom && player.Bottom > medyk.Top && player.Right > medyk.Left && player.Left < medyk.Right)
                {
                    up = false;
                }
            }
            #endregion
            #region balwan
            // balwan
            if (balwan.Visible)
            {
                if (player.Right + 10 > balwan.Left && player.Left < balwan.Right && player.Bottom > balwan.Top && player.Top < balwan.Bottom)
                {
                    right = false;
                }
                if (player.Left - 10 < balwan.Right && player.Right > balwan.Left && player.Bottom > balwan.Top && player.Top < balwan.Bottom)
                {
                    left = false;
                }

                if (player.Bottom + 10 > balwan.Top && player.Top < balwan.Bottom && player.Right > balwan.Left && player.Left < balwan.Right)
                {
                    down = false;
                }
                if (player.Top - 10 < balwan.Bottom && player.Bottom > balwan.Top && player.Right > balwan.Left && player.Left < balwan.Right)
                {
                    up = false;
                }
            }
            #endregion
            #region sciana1
            // sciana1
            if (player.Right + 10 > sciana1.Left && player.Left < sciana1.Right && player.Bottom > sciana1.Top && player.Top < sciana1.Bottom)
            {
                right = false;
            }
            if (player.Left - 10 < sciana1.Right && player.Right > sciana1.Left && player.Bottom > sciana1.Top && player.Top < sciana1.Bottom)
            {
                left = false;
            }

            if (player.Bottom + 10 > sciana1.Top && player.Top < sciana1.Bottom && player.Right > sciana1.Left && player.Left < sciana1.Right)
            {
                down = false;
            }
            if (player.Top - 10 < sciana1.Bottom && player.Bottom > sciana1.Top && player.Right > sciana1.Left && player.Left < sciana1.Right)
            {
                up = false;
            }
           
            #endregion
            #region sciana2
            // sciana2
            if (player.Right + 10 > sciana2.Left && player.Left < sciana2.Right && player.Bottom > sciana2.Top && player.Top < sciana2.Bottom)
            {
                right = false;
            }
            if (player.Left - 10 < sciana2.Right && player.Right > sciana2.Left && player.Bottom > sciana2.Top && player.Top < sciana2.Bottom)
            {
                left = false;
            }
            
            if (player.Bottom + 10 > sciana2.Top && player.Top < sciana2.Bottom && player.Right > sciana2.Left && player.Left < sciana2.Right)
            {
                down = false;
            }
            if (player.Top - 10 < sciana2.Bottom && player.Bottom > sciana2.Top && player.Right > sciana2.Left && player.Left < sciana2.Right)
            {
                up = false;
            }            
            #endregion
            #region sciana3
            // sciana3
            if (player.Right + 10 > sciana3.Left && player.Left < sciana3.Right && player.Bottom > sciana3.Top && player.Top < sciana3.Bottom)
            {
                right = false;
            }
            if (player.Left - 10 < sciana3.Right && player.Right > sciana3.Left && player.Bottom > sciana3.Top && player.Top < sciana3.Bottom)
            {
                left = false;
            }
            
            if (player.Bottom + 10 > sciana3.Top && player.Top < sciana3.Bottom && player.Right > sciana3.Left && player.Left < sciana3.Right)
            {
                down = false;
            }
            if (player.Top - 10 < sciana3.Bottom && player.Bottom > sciana3.Top && player.Right > sciana3.Left && player.Left < sciana3.Right)
            {
                up = false;
            }
            #endregion
            #region sciana4
            // sciana4
            if (player.Right + 10 > sciana4.Left && player.Left < sciana4.Right && player.Bottom > sciana4.Top && player.Top < sciana4.Bottom)
            {
                right = false;
            }
            if (player.Left - 10 < sciana4.Right && player.Right > sciana4.Left && player.Bottom > sciana4.Top && player.Top < sciana4.Bottom)
            {
                left = false;
            }

            if (player.Bottom + 10 > sciana4.Top && player.Top < sciana4.Bottom && player.Right > sciana4.Left && player.Left < sciana4.Right)
            {
                down = false;
            }
            if (player.Top - 10 < sciana4.Bottom && player.Bottom > sciana4.Top && player.Right > sciana4.Left && player.Left < sciana4.Right)
            {
                up = false;
            }
            #endregion
            #region drzewo1
            // drzewo1
            if (player.Right + 10 > drzewo1.Left && player.Left < drzewo1.Right && player.Bottom > drzewo1.Top && player.Top < drzewo1.Bottom)
            {
                right = false;
            }
            if (player.Left - 10 < drzewo1.Right && player.Right > drzewo1.Left && player.Bottom > drzewo1.Top && player.Top < drzewo1.Bottom)
            {
                left = false;
            }

            if (player.Bottom + 10 > drzewo1.Top && player.Top < drzewo1.Bottom && player.Right > drzewo1.Left && player.Left < drzewo1.Right)
            {
                down = false;
            }
            if (player.Top - 10 < drzewo1.Bottom && player.Bottom > drzewo1.Top && player.Right > drzewo1.Left && player.Left < drzewo1.Right)
            {
                up = false;
            }
            #endregion
            #region drzewo2
            // drzewo2
            if (player.Right + 10 > drzewo2.Left && player.Left < drzewo2.Right && player.Bottom > drzewo2.Top && player.Top < drzewo2.Bottom)
            {
                right = false;
            }
            if (player.Left - 10 < drzewo2.Right && player.Right > drzewo2.Left && player.Bottom > drzewo2.Top && player.Top < drzewo2.Bottom)
            {
                left = false;
            }

            if (player.Bottom + 10 > drzewo2.Top && player.Top < drzewo2.Bottom && player.Right > drzewo2.Left && player.Left < drzewo2.Right)
            {
                down = false;
            }
            if (player.Top - 10 < drzewo2.Bottom && player.Bottom > drzewo2.Top && player.Right > drzewo2.Left && player.Left < drzewo2.Right)
            {
                up = false;
            }
            #endregion

            #region resp
            //respown postaci 
            if (czas % 100 == 1 && postac.Visible==false)
            {
                x = random.Next(1, screen.Width - postac.Width - 1);   //losowa pozycja
                y = random.Next(1, screen.Height - postac.Height - 1); //losowa pozycja
                postac.Visible = true;
                postac.Location = new Point(x,y);
                zycie_zjawa += 30 * (liczba_zabitych_zjawa / 2);  // zwiększanie życia
                atak_zjawa += 15 * (liczba_zabitych_zjawa / 2);   // zwiększanie ataku
                toolTip1.SetToolTip(this.postac, "Zjawa \nHP: " + zycie_zjawa + "\nAtak: " + atak_zjawa);   
            }
            //respown balwana
            if (czas % 75 == 1 && balwan.Visible == false)
            {
                x = random.Next(1, screen.Width - balwan.Width - 1);     //losowa pozycja
                y = random.Next(1, screen.Height - balwan.Height - 1);   //losowa pozycja
                balwan.Visible = true;
                balwan.Location = new Point(x, y);
                zycie_balwana += 20 * (liczba_zabitych_balwan/2);  // zwiększanie życia
                atak_balwana += 10 * (liczba_zabitych_balwan/2);   // zwiększanie ataku
                toolTip1.SetToolTip(this.balwan, "Bałwan \nHP: "+zycie_balwana+"\nAtak: "+atak_balwana);
            }
            //respown gracza
            if (player.Visible == false)
            {
                player.Visible = true;
                player.Location = new Point(10, 10);
                zycie_bohatera = 1;    
            }
            //BOSS pojawia się 
            if(level==5 && zycie_boss>0)
            {
                boss.Visible = true;
            }
            #endregion
            
            #region wychodzenie za ekran
            //blokowanie wychodzenia za ekran
            if (player.Left - 1 < 0)
            {
                left = false;
            }
            if (player.Right +1 > screen.Width)
            {
                right = false;
            }
            if (player.Top -1 < 0)
            {
                up = false;
            }
            if (player.Bottom +8 > screen.Height)
            {
                down = false;
            }
            #endregion

            // poruszanie
            if (right == true) { player.Left += 10; player.Image = Image.FromFile("prawo.png"); }
            if (left == true) { player.Left -= 10; player.Image = Image.FromFile("lewo.png"); }
            if (up == true) { player.Top -= 10; player.Image = Image.FromFile("gora.png"); }
            if (down == true) { player.Top += 10; player.Image = Image.FromFile("przod.png"); }

            hp.Text = zycie_bohatera.ToString() + " / " + zycie_bohatera_max.ToString();
            atak.Text = atak_bohatera.ToString();
            czas += 1;
            kasa.Text = zloto.ToString();         
            //LEVEL
            int lvl_doswiadczenie= 150;
            if (doswiadczenie >= 150 ) { level = 2; atak_bohatera = 40; zycie_bohatera_max = 1150; lvl_doswiadczenie = 300; }
            if (doswiadczenie >= 300 ) { level = 3; atak_bohatera = 65; zycie_bohatera_max = 1350; lvl_doswiadczenie = 700; }
            if (doswiadczenie >= 700 ) { level = 4; atak_bohatera = 100; zycie_bohatera_max = 1600; lvl_doswiadczenie = 1500; }
            if (doswiadczenie >= 1500) { level = 5; atak_bohatera = 140; zycie_bohatera_max = 2100; lvl_doswiadczenie = 2100; }
            if (doswiadczenie >= 2100) { level = 6; atak_bohatera = 195; zycie_bohatera_max = 2500; lvl_doswiadczenie = 3300; }
            if (doswiadczenie >= 3300) { level = 7; atak_bohatera = 230; zycie_bohatera_max = 3000; lvl_doswiadczenie = 5000; }
            exp.Text = doswiadczenie.ToString() + " / " + lvl_doswiadczenie.ToString();
            lvl.Text = level.ToString();

            //zadania
            
            if ((2 - liczba_zabitych_balwan) > 0)
            {
                zadanie1.Text = " Zabij 10 bałwanów. \nPosostało do zabicia:\n" + (2 - liczba_zabitych_balwan) + " bałwanów";
            }
            else
            {
                if (aaaaaa == 0)
                {
                    zloto += 1000;
                    doswiadczenie += 500;
                    zadanie1.Text = "brawo ukończyłeś zadanie";
                    zadanie1.Visible = false;
                    aaaaaa++;
                }
            }


        }

        #region poruszanie 
        // poruszanie
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D) { right = true; }
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A) { left = true; }
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W) { up = true; }
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S) { down = true; }
            if (e.KeyCode == Keys.Escape) { this.Close(); }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D) { right = false; }
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A) { left = false; }
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W) { up = false; }
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S) { down = false; }
        }
        #endregion

        private void sciana1_Click(object sender, EventArgs e)
        {
            if (balwan.Left-25 < player.Right && balwan.Right+25 > player.Left && balwan.Top -25 < player.Bottom && balwan.Bottom+25 > player.Top)
            {
                DialogResult dialogResult = MessageBox.Show("Atakować ?\n"+"HP: "+zycie_bohatera, "Atak", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    atak atak = new atak();
                    form2 = new Form2(atak_bohatera.ToString(), atak_balwana.ToString(), zycie_bohatera.ToString(), zycie_balwana.ToString());
                    form2.Left = 300;
                    form2.ShowDialog();
                    hp.Text = form2.hp_bohatera;
                    zycie_bohatera = Int32.Parse(form2.hp_bohatera);
                    zycie_balwana = Int32.Parse(form2.hp_przeciwnika);
                    form2.Dispose();
                    if (form2.ucieczka)
                    {
                        zycie_bohatera = 1;
                        MessageBox.Show("Uciekłeś z walki :( ");
                    }
                }
               
                if (zycie_balwana <= 0)
                {
                    MessageBox.Show("Balwan nie żyje");
                    balwan.Visible = false;
                    zloto += 50;
                    doswiadczenie += 50;
                    zycie_balwana = 40;
                    liczba_zabitych_balwan += 1;
                }
                if (zycie_bohatera <= 0)
                {
                    hp.Text = "0";
                    MessageBox.Show("Nie żyjesz");
                    player.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("jesteś za daleko, żeby atakować");
            }
            
        }

        private void postac_Click(object sender, EventArgs e)
        {
            if (postac.Left - 25 < player.Right && postac.Right + 25 > player.Left && postac.Top - 25 < player.Bottom && postac.Bottom + 25 > player.Top)
            {
                DialogResult dialogResult = MessageBox.Show("Atakować ?\n" + "HP: " + zycie_bohatera, "Atak", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    atak atak = new atak();
                    form2 = new Form2(atak_bohatera.ToString(), atak_zjawa.ToString(), zycie_bohatera.ToString(), zycie_zjawa.ToString());
                    form2.ShowDialog();
                    hp.Text = form2.hp_bohatera;
                    zycie_bohatera = Int32.Parse(form2.hp_bohatera);
                    zycie_zjawa = Int32.Parse(form2.hp_przeciwnika);
                    form2.Dispose();
                    if (form2.ucieczka)
                    {
                        zycie_bohatera = 1;
                        MessageBox.Show("Uciekłeś z walki :( \nHP: 1");
                    }
                }
               
                if (zycie_zjawa <= 0)
                {
                    MessageBox.Show("Zjawa nie żyje");
                    postac.Visible = false;
                    zloto += 100;
                    doswiadczenie += 100;
                    zycie_zjawa = 250;
                    liczba_zabitych_zjawa += 1;
                }
                if (zycie_bohatera <= 0)
                {
                    hp.Text = "0";
                    MessageBox.Show("Nie żyjesz");
                    player.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("jesteś za daleko, żeby atakować");
            }

        }

        private void medyk_Click(object sender, EventArgs e)
        {
            if (medyk.Left - 25 < player.Right && medyk.Right + 25 > player.Left && medyk.Top - 25 < player.Bottom && medyk.Bottom + 25 > player.Top)
            {
                DialogResult dialogResult = MessageBox.Show("Leczyć ? \nKoszt: 150 złota", "Leczenie", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {                   
                   
                    if(zloto - 150 >= 0)
                    {
                        zycie_bohatera = zycie_bohatera_max;
                        zloto -= 150;
                    }
                    else
                    {
                        MessageBox.Show("Masz za mało złota");
                    }            
                }

                DialogResult dialogResult1 = MessageBox.Show("Atakować ?\n" + "HP: " + zycie_bohatera, "Atak", MessageBoxButtons.YesNo);
                if (dialogResult1 == DialogResult.Yes)
                {
                    atak atak = new atak();
                    form2 = new Form2(atak_bohatera.ToString(), atak_medyk.ToString(), zycie_bohatera.ToString(), zycie_medyk.ToString());
                    form2.ShowDialog();
                    hp.Text = form2.hp_bohatera;
                    zycie_bohatera = Int32.Parse(form2.hp_bohatera);
                    zycie_medyk = Int32.Parse(form2.hp_przeciwnika);
                    form2.Dispose();
                    if (form2.ucieczka == true)
                    {
                        zycie_bohatera = 1;
                        MessageBox.Show("Uciekłeś z walki :( \nHP: 1 ");
                    }
                }
                
                if (zycie_medyk <= 0)
                {
                    MessageBox.Show("Zjawa nie żyje");
                    medyk.Visible = false;
                    zloto += 1000;
                    doswiadczenie += 200;
                    zycie_medyk = 2500;
                }
                if (zycie_bohatera <= 0)
                {
                    hp.Text = "0";
                    MessageBox.Show("Nie żyjesz");
                    player.Visible = false;
                }
            }

            else
            {
                MessageBox.Show("jesteś za daleko");
            }
        }

        private void boss_Click(object sender, EventArgs e)
        {
            if (boss.Left - 25 < player.Right && boss.Right + 25 > player.Left && boss.Top - 25 < player.Bottom && boss.Bottom + 25 > player.Top)
            {
                DialogResult dialogResult = MessageBox.Show("Atakować ?\n" + "HP: " + zycie_bohatera, "Atak", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    atak atak = new atak();
                    form2 = new Form2(atak_bohatera.ToString(), atak_boss.ToString(), zycie_bohatera.ToString(), zycie_boss.ToString());
                    form2.ShowDialog();
                    hp.Text = form2.hp_bohatera;
                    zycie_bohatera = Int32.Parse(form2.hp_bohatera);
                    zycie_boss = Int32.Parse(form2.hp_przeciwnika);
                    form2.Dispose();
                    if (form2.ucieczka)
                    {
                        zycie_bohatera = 1;
                        MessageBox.Show("Uciekłeś z walki :( \nHP: 1 ");
                    }
                }
                if (zycie_boss <= 0)
                {
                    MessageBox.Show("Boss nie żyje");
                    boss.Visible = false;
                    zloto += 5000;
                    doswiadczenie += 500;
                    zycie_boss = 5000;
                }
                if (zycie_bohatera <= 0)
                {
                    hp.Text = "0";
                    MessageBox.Show("Nie żyjesz");
                    player.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("jesteś za daleko, żeby atakować");
            }
        }
    }
}
