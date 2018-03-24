namespace tank
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.screen = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labe1 = new System.Windows.Forms.Label();
            this.hp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.atak = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.kasa = new System.Windows.Forms.Label();
            this.exp = new System.Windows.Forms.Label();
            this.lvl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.drzewo2 = new System.Windows.Forms.PictureBox();
            this.drzewo1 = new System.Windows.Forms.PictureBox();
            this.sciana4 = new System.Windows.Forms.PictureBox();
            this.sciana2 = new System.Windows.Forms.PictureBox();
            this.sciana3 = new System.Windows.Forms.PictureBox();
            this.boss = new System.Windows.Forms.PictureBox();
            this.medyk = new System.Windows.Forms.PictureBox();
            this.balwan = new System.Windows.Forms.PictureBox();
            this.postac = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.sciana1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.zadanie1 = new System.Windows.Forms.Label();
            this.screen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drzewo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drzewo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sciana4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sciana2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sciana3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medyk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balwan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sciana1)).BeginInit();
            this.SuspendLayout();
            // 
            // screen
            // 
            this.screen.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.screen.Controls.Add(this.drzewo2);
            this.screen.Controls.Add(this.drzewo1);
            this.screen.Controls.Add(this.sciana4);
            this.screen.Controls.Add(this.sciana2);
            this.screen.Controls.Add(this.sciana3);
            this.screen.Controls.Add(this.boss);
            this.screen.Controls.Add(this.medyk);
            this.screen.Controls.Add(this.balwan);
            this.screen.Controls.Add(this.postac);
            this.screen.Controls.Add(this.pictureBox3);
            this.screen.Controls.Add(this.pictureBox1);
            this.screen.Controls.Add(this.player);
            this.screen.Controls.Add(this.sciana1);
            this.screen.Location = new System.Drawing.Point(9, 9);
            this.screen.Margin = new System.Windows.Forms.Padding(0);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(794, 443);
            this.screen.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labe1
            // 
            this.labe1.AutoSize = true;
            this.labe1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labe1.Location = new System.Drawing.Point(806, 14);
            this.labe1.Name = "labe1";
            this.labe1.Size = new System.Drawing.Size(27, 17);
            this.labe1.TabIndex = 1;
            this.labe1.Text = "HP";
            // 
            // hp
            // 
            this.hp.AutoSize = true;
            this.hp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hp.Location = new System.Drawing.Point(857, 14);
            this.hp.Name = "hp";
            this.hp.Size = new System.Drawing.Size(16, 17);
            this.hp.TabIndex = 2;
            this.hp.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(806, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Atak";
            // 
            // atak
            // 
            this.atak.AutoSize = true;
            this.atak.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.atak.Location = new System.Drawing.Point(857, 41);
            this.atak.Name = "atak";
            this.atak.Size = new System.Drawing.Size(16, 17);
            this.atak.TabIndex = 4;
            this.atak.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(806, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Złoto: ";
            // 
            // kasa
            // 
            this.kasa.AutoSize = true;
            this.kasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kasa.Location = new System.Drawing.Point(857, 75);
            this.kasa.Name = "kasa";
            this.kasa.Size = new System.Drawing.Size(16, 17);
            this.kasa.TabIndex = 8;
            this.kasa.Text = "0";
            // 
            // exp
            // 
            this.exp.AutoSize = true;
            this.exp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exp.Location = new System.Drawing.Point(857, 136);
            this.exp.Name = "exp";
            this.exp.Size = new System.Drawing.Size(16, 17);
            this.exp.TabIndex = 9;
            this.exp.Text = "0";
            // 
            // lvl
            // 
            this.lvl.AutoSize = true;
            this.lvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lvl.Location = new System.Drawing.Point(857, 105);
            this.lvl.Name = "lvl";
            this.lvl.Size = new System.Drawing.Size(16, 17);
            this.lvl.TabIndex = 10;
            this.lvl.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(806, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Level: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(806, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "EXP:";
            // 
            // drzewo2
            // 
            this.drzewo2.Image = global::tank.Properties.Resources.drzewo1;
            this.drzewo2.Location = new System.Drawing.Point(466, 258);
            this.drzewo2.Margin = new System.Windows.Forms.Padding(5);
            this.drzewo2.Name = "drzewo2";
            this.drzewo2.Size = new System.Drawing.Size(125, 176);
            this.drzewo2.TabIndex = 23;
            this.drzewo2.TabStop = false;
            // 
            // drzewo1
            // 
            this.drzewo1.Image = global::tank.Properties.Resources.drzewo1;
            this.drzewo1.Location = new System.Drawing.Point(160, 9);
            this.drzewo1.Margin = new System.Windows.Forms.Padding(5);
            this.drzewo1.Name = "drzewo1";
            this.drzewo1.Size = new System.Drawing.Size(125, 176);
            this.drzewo1.TabIndex = 22;
            this.drzewo1.TabStop = false;
            // 
            // sciana4
            // 
            this.sciana4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sciana4.BackgroundImage")));
            this.sciana4.Image = ((System.Drawing.Image)(resources.GetObject("sciana4.Image")));
            this.sciana4.Location = new System.Drawing.Point(0, 0);
            this.sciana4.Margin = new System.Windows.Forms.Padding(5);
            this.sciana4.Name = "sciana4";
            this.sciana4.Size = new System.Drawing.Size(10, 443);
            this.sciana4.TabIndex = 21;
            this.sciana4.TabStop = false;
            // 
            // sciana2
            // 
            this.sciana2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sciana2.BackgroundImage")));
            this.sciana2.Location = new System.Drawing.Point(784, 0);
            this.sciana2.Margin = new System.Windows.Forms.Padding(5);
            this.sciana2.Name = "sciana2";
            this.sciana2.Size = new System.Drawing.Size(10, 443);
            this.sciana2.TabIndex = 20;
            this.sciana2.TabStop = false;
            // 
            // sciana3
            // 
            this.sciana3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sciana3.BackgroundImage")));
            this.sciana3.Image = ((System.Drawing.Image)(resources.GetObject("sciana3.Image")));
            this.sciana3.Location = new System.Drawing.Point(0, 433);
            this.sciana3.Margin = new System.Windows.Forms.Padding(5);
            this.sciana3.Name = "sciana3";
            this.sciana3.Size = new System.Drawing.Size(794, 10);
            this.sciana3.TabIndex = 19;
            this.sciana3.TabStop = false;
            // 
            // boss
            // 
            this.boss.BackColor = System.Drawing.Color.Transparent;
            this.boss.Image = global::tank.Properties.Resources.boss;
            this.boss.Location = new System.Drawing.Point(20, 66);
            this.boss.Margin = new System.Windows.Forms.Padding(5);
            this.boss.Name = "boss";
            this.boss.Size = new System.Drawing.Size(130, 132);
            this.boss.TabIndex = 18;
            this.boss.TabStop = false;
            this.boss.Visible = false;
            this.boss.Click += new System.EventHandler(this.boss_Click);
            // 
            // medyk
            // 
            this.medyk.BackColor = System.Drawing.Color.Transparent;
            this.medyk.Image = global::tank.Properties.Resources.medyk;
            this.medyk.Location = new System.Drawing.Point(295, 304);
            this.medyk.Margin = new System.Windows.Forms.Padding(5);
            this.medyk.Name = "medyk";
            this.medyk.Size = new System.Drawing.Size(33, 48);
            this.medyk.TabIndex = 18;
            this.medyk.TabStop = false;
            this.medyk.Click += new System.EventHandler(this.medyk_Click);
            // 
            // balwan
            // 
            this.balwan.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.balwan.Image = global::tank.Properties.Resources.przód;
            this.balwan.Location = new System.Drawing.Point(221, 305);
            this.balwan.Margin = new System.Windows.Forms.Padding(5);
            this.balwan.Name = "balwan";
            this.balwan.Size = new System.Drawing.Size(28, 47);
            this.balwan.TabIndex = 1;
            this.balwan.TabStop = false;
            this.balwan.Click += new System.EventHandler(this.sciana1_Click);
            // 
            // postac
            // 
            this.postac.Image = global::tank.Properties.Resources.male_12;
            this.postac.Location = new System.Drawing.Point(178, 304);
            this.postac.Margin = new System.Windows.Forms.Padding(5);
            this.postac.Name = "postac";
            this.postac.Size = new System.Drawing.Size(33, 48);
            this.postac.TabIndex = 14;
            this.postac.TabStop = false;
            this.postac.Click += new System.EventHandler(this.postac_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 527);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1020, 10);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::tank.Properties.Resources.cagla;
            this.pictureBox1.Location = new System.Drawing.Point(1010, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 527);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.BackgroundImage = global::tank.Properties.Resources.przod;
            this.player.Image = global::tank.Properties.Resources.przod;
            this.player.Location = new System.Drawing.Point(259, 304);
            this.player.Margin = new System.Windows.Forms.Padding(5);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(26, 44);
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // sciana1
            // 
            this.sciana1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sciana1.BackgroundImage")));
            this.sciana1.Image = ((System.Drawing.Image)(resources.GetObject("sciana1.Image")));
            this.sciana1.Location = new System.Drawing.Point(0, 0);
            this.sciana1.Margin = new System.Windows.Forms.Padding(5);
            this.sciana1.Name = "sciana1";
            this.sciana1.Size = new System.Drawing.Size(794, 10);
            this.sciana1.TabIndex = 8;
            this.sciana1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(806, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Zadania:";
            // 
            // zadanie1
            // 
            this.zadanie1.AutoSize = true;
            this.zadanie1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zadanie1.Location = new System.Drawing.Point(806, 209);
            this.zadanie1.Name = "zadanie1";
            this.zadanie1.Size = new System.Drawing.Size(16, 17);
            this.zadanie1.TabIndex = 21;
            this.zadanie1.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 461);
            this.Controls.Add(this.zadanie1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lvl);
            this.Controls.Add(this.exp);
            this.Controls.Add(this.kasa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.screen);
            this.Controls.Add(this.atak);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hp);
            this.Controls.Add(this.labe1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.screen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.drzewo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drzewo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sciana4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sciana2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sciana3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medyk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balwan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sciana1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel screen;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox balwan;
        private System.Windows.Forms.PictureBox postac;
        private System.Windows.Forms.PictureBox sciana1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labe1;
        private System.Windows.Forms.Label hp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label atak;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox medyk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label kasa;
        private System.Windows.Forms.Label exp;
        private System.Windows.Forms.Label lvl;
        private System.Windows.Forms.PictureBox boss;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox sciana4;
        private System.Windows.Forms.PictureBox sciana2;
        private System.Windows.Forms.PictureBox sciana3;
        private System.Windows.Forms.PictureBox drzewo1;
        private System.Windows.Forms.PictureBox drzewo2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label zadanie1;
    }
}

