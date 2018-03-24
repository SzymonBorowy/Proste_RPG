namespace tank
{
    partial class Form2
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
            this.atak_przycisk = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.uciekaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // atak_przycisk
            // 
            this.atak_przycisk.Location = new System.Drawing.Point(12, 227);
            this.atak_przycisk.Name = "atak_przycisk";
            this.atak_przycisk.Size = new System.Drawing.Size(120, 23);
            this.atak_przycisk.TabIndex = 1;
            this.atak_przycisk.Text = "Atak";
            this.atak_przycisk.UseVisualStyleBackColor = true;
            this.atak_przycisk.Click += new System.EventHandler(this.atak_przycisk_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(260, 212);
            this.textBox1.TabIndex = 3;
            // 
            // uciekaj
            // 
            this.uciekaj.Location = new System.Drawing.Point(138, 227);
            this.uciekaj.Name = "uciekaj";
            this.uciekaj.Size = new System.Drawing.Size(134, 23);
            this.uciekaj.TabIndex = 4;
            this.uciekaj.Text = "Uciekaj";
            this.uciekaj.UseVisualStyleBackColor = true;
            this.uciekaj.Click += new System.EventHandler(this.uciekaj_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.uciekaj);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.atak_przycisk);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button atak_przycisk;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button uciekaj;
    }
}