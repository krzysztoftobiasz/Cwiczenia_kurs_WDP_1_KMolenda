namespace GraficznaAppHello
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelimie = new System.Windows.Forms.Label();
            this.textBoxImie = new System.Windows.Forms.TextBox();
            this.LabelNazwisko = new System.Windows.Forms.Label();
            this.textBoxNazwisko = new System.Windows.Forms.TextBox();
            this.labelWiek = new System.Windows.Forms.Label();
            this.textBoxWiek = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.labelKomunikat1 = new System.Windows.Forms.Label();
            this.labelKomunikat2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelimie
            // 
            this.labelimie.AutoSize = true;
            this.labelimie.Location = new System.Drawing.Point(41, 32);
            this.labelimie.Name = "labelimie";
            this.labelimie.Size = new System.Drawing.Size(26, 13);
            this.labelimie.TabIndex = 0;
            this.labelimie.Text = "Imię";
            this.labelimie.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxImie
            // 
            this.textBoxImie.Location = new System.Drawing.Point(140, 32);
            this.textBoxImie.Name = "textBoxImie";
            this.textBoxImie.Size = new System.Drawing.Size(100, 20);
            this.textBoxImie.TabIndex = 1;
            this.textBoxImie.TextChanged += new System.EventHandler(this.textBoxImie_TextChanged);
            // 
            // LabelNazwisko
            // 
            this.LabelNazwisko.AutoSize = true;
            this.LabelNazwisko.Location = new System.Drawing.Point(41, 75);
            this.LabelNazwisko.Name = "LabelNazwisko";
            this.LabelNazwisko.Size = new System.Drawing.Size(53, 13);
            this.LabelNazwisko.TabIndex = 2;
            this.LabelNazwisko.Text = "Nazwisko";
            // 
            // textBoxNazwisko
            // 
            this.textBoxNazwisko.Location = new System.Drawing.Point(140, 75);
            this.textBoxNazwisko.Name = "textBoxNazwisko";
            this.textBoxNazwisko.Size = new System.Drawing.Size(100, 20);
            this.textBoxNazwisko.TabIndex = 3;
            this.textBoxNazwisko.TextChanged += new System.EventHandler(this.textBoxNazwisko_TextChanged);
            // 
            // labelWiek
            // 
            this.labelWiek.AutoSize = true;
            this.labelWiek.Location = new System.Drawing.Point(41, 121);
            this.labelWiek.Name = "labelWiek";
            this.labelWiek.Size = new System.Drawing.Size(32, 13);
            this.labelWiek.TabIndex = 4;
            this.labelWiek.Text = "Wiek";
            // 
            // textBoxWiek
            // 
            this.textBoxWiek.Location = new System.Drawing.Point(140, 121);
            this.textBoxWiek.Name = "textBoxWiek";
            this.textBoxWiek.Size = new System.Drawing.Size(100, 20);
            this.textBoxWiek.TabIndex = 5;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(90, 168);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 6;
            this.buttonOk.Text = "Kliknij!";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // labelKomunikat1
            // 
            this.labelKomunikat1.AutoSize = true;
            this.labelKomunikat1.Location = new System.Drawing.Point(28, 207);
            this.labelKomunikat1.Name = "labelKomunikat1";
            this.labelKomunikat1.Size = new System.Drawing.Size(66, 13);
            this.labelKomunikat1.TabIndex = 7;
            this.labelKomunikat1.Text = "Komunikat 1";
            // 
            // labelKomunikat2
            // 
            this.labelKomunikat2.AutoSize = true;
            this.labelKomunikat2.Location = new System.Drawing.Point(28, 234);
            this.labelKomunikat2.Name = "labelKomunikat2";
            this.labelKomunikat2.Size = new System.Drawing.Size(66, 13);
            this.labelKomunikat2.TabIndex = 8;
            this.labelKomunikat2.Text = "Komunikat 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 327);
            this.Controls.Add(this.labelKomunikat2);
            this.Controls.Add(this.labelKomunikat1);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textBoxWiek);
            this.Controls.Add(this.labelWiek);
            this.Controls.Add(this.textBoxNazwisko);
            this.Controls.Add(this.LabelNazwisko);
            this.Controls.Add(this.textBoxImie);
            this.Controls.Add(this.labelimie);
            this.Name = "Form1";
            this.Text = "Aplikacja Siemanko!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelimie;
        private System.Windows.Forms.TextBox textBoxImie;
        private System.Windows.Forms.Label LabelNazwisko;
        private System.Windows.Forms.TextBox textBoxNazwisko;
        private System.Windows.Forms.Label labelWiek;
        private System.Windows.Forms.TextBox textBoxWiek;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Label labelKomunikat1;
        private System.Windows.Forms.Label labelKomunikat2;
    }
}

