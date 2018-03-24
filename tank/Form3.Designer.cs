namespace tank
{
    partial class Form3
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
            this.ulecz = new System.Windows.Forms.Button();
            this.zadanie = new System.Windows.Forms.Button();
            this.atakuj = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ulecz
            // 
            this.ulecz.Location = new System.Drawing.Point(12, 12);
            this.ulecz.Name = "ulecz";
            this.ulecz.Size = new System.Drawing.Size(100, 50);
            this.ulecz.TabIndex = 0;
            this.ulecz.Text = "Ulecz";
            this.ulecz.UseVisualStyleBackColor = true;
            // 
            // zadanie
            // 
            this.zadanie.Location = new System.Drawing.Point(12, 68);
            this.zadanie.Name = "zadanie";
            this.zadanie.Size = new System.Drawing.Size(100, 50);
            this.zadanie.TabIndex = 1;
            this.zadanie.Text = "Zadanie";
            this.zadanie.UseVisualStyleBackColor = true;
            // 
            // atakuj
            // 
            this.atakuj.Location = new System.Drawing.Point(126, 12);
            this.atakuj.Name = "atakuj";
            this.atakuj.Size = new System.Drawing.Size(100, 50);
            this.atakuj.TabIndex = 2;
            this.atakuj.Text = "Atakuj";
            this.atakuj.UseVisualStyleBackColor = true;
            this.atakuj.Click += new System.EventHandler(this.atakuj_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(126, 68);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 50);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 224);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.atakuj);
            this.Controls.Add(this.zadanie);
            this.Controls.Add(this.ulecz);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ulecz;
        private System.Windows.Forms.Button zadanie;
        private System.Windows.Forms.Button atakuj;
        private System.Windows.Forms.Button button4;
    }
}