namespace P01AplikacjaZawodnicy
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
            this.lbDane = new System.Windows.Forms.ListBox();
            this.btnWczytaj = new System.Windows.Forms.Button();
            this.txtSciezka = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbSzczegolyZawodnika = new System.Windows.Forms.GroupBox();
            this.txtImie = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNazwisko = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKraj = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpDataUrodzenia = new System.Windows.Forms.DateTimePicker();
            this.numWzrost = new System.Windows.Forms.NumericUpDown();
            this.numWaga = new System.Windows.Forms.NumericUpDown();
            this.gbSzczegolyZawodnika.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWzrost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWaga)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDane
            // 
            this.lbDane.FormattingEnabled = true;
            this.lbDane.Location = new System.Drawing.Point(13, 46);
            this.lbDane.Name = "lbDane";
            this.lbDane.Size = new System.Drawing.Size(310, 277);
            this.lbDane.TabIndex = 0;
            this.lbDane.SelectedIndexChanged += new System.EventHandler(this.lbDane_SelectedIndexChanged);
            // 
            // btnWczytaj
            // 
            this.btnWczytaj.Location = new System.Drawing.Point(13, 13);
            this.btnWczytaj.Name = "btnWczytaj";
            this.btnWczytaj.Size = new System.Drawing.Size(75, 23);
            this.btnWczytaj.TabIndex = 1;
            this.btnWczytaj.Text = "Wczytaj";
            this.btnWczytaj.UseVisualStyleBackColor = true;
            this.btnWczytaj.Click += new System.EventHandler(this.btnWczytaj_Click);
            // 
            // txtSciezka
            // 
            this.txtSciezka.Location = new System.Drawing.Point(146, 16);
            this.txtSciezka.Name = "txtSciezka";
            this.txtSciezka.Size = new System.Drawing.Size(177, 20);
            this.txtSciezka.TabIndex = 2;
            this.txtSciezka.Click += new System.EventHandler(this.txtSciezka_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ścieżka";
            // 
            // gbSzczegolyZawodnika
            // 
            this.gbSzczegolyZawodnika.Controls.Add(this.numWaga);
            this.gbSzczegolyZawodnika.Controls.Add(this.numWzrost);
            this.gbSzczegolyZawodnika.Controls.Add(this.dtpDataUrodzenia);
            this.gbSzczegolyZawodnika.Controls.Add(this.label7);
            this.gbSzczegolyZawodnika.Controls.Add(this.label6);
            this.gbSzczegolyZawodnika.Controls.Add(this.label5);
            this.gbSzczegolyZawodnika.Controls.Add(this.label4);
            this.gbSzczegolyZawodnika.Controls.Add(this.txtKraj);
            this.gbSzczegolyZawodnika.Controls.Add(this.label3);
            this.gbSzczegolyZawodnika.Controls.Add(this.txtNazwisko);
            this.gbSzczegolyZawodnika.Controls.Add(this.label2);
            this.gbSzczegolyZawodnika.Controls.Add(this.txtImie);
            this.gbSzczegolyZawodnika.Location = new System.Drawing.Point(329, 46);
            this.gbSzczegolyZawodnika.Name = "gbSzczegolyZawodnika";
            this.gbSzczegolyZawodnika.Size = new System.Drawing.Size(220, 277);
            this.gbSzczegolyZawodnika.TabIndex = 4;
            this.gbSzczegolyZawodnika.TabStop = false;
            this.gbSzczegolyZawodnika.Text = "Zawodnik";
            this.gbSzczegolyZawodnika.Visible = false;
            // 
            // txtImie
            // 
            this.txtImie.Location = new System.Drawing.Point(10, 37);
            this.txtImie.Name = "txtImie";
            this.txtImie.Size = new System.Drawing.Size(188, 20);
            this.txtImie.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Imie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nazwisko";
            // 
            // txtNazwisko
            // 
            this.txtNazwisko.Location = new System.Drawing.Point(10, 80);
            this.txtNazwisko.Name = "txtNazwisko";
            this.txtNazwisko.Size = new System.Drawing.Size(188, 20);
            this.txtNazwisko.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Kraj";
            // 
            // txtKraj
            // 
            this.txtKraj.Location = new System.Drawing.Point(10, 124);
            this.txtKraj.Name = "txtKraj";
            this.txtKraj.Size = new System.Drawing.Size(188, 20);
            this.txtKraj.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Data Urodzenia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Wzrost";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Waga";
            // 
            // dtpDataUrodzenia
            // 
            this.dtpDataUrodzenia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataUrodzenia.Location = new System.Drawing.Point(10, 167);
            this.dtpDataUrodzenia.Name = "dtpDataUrodzenia";
            this.dtpDataUrodzenia.Size = new System.Drawing.Size(188, 20);
            this.dtpDataUrodzenia.TabIndex = 12;
            // 
            // numWzrost
            // 
            this.numWzrost.Location = new System.Drawing.Point(10, 207);
            this.numWzrost.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numWzrost.Name = "numWzrost";
            this.numWzrost.Size = new System.Drawing.Size(188, 20);
            this.numWzrost.TabIndex = 13;
            // 
            // numWaga
            // 
            this.numWaga.Location = new System.Drawing.Point(10, 251);
            this.numWaga.Name = "numWaga";
            this.numWaga.Size = new System.Drawing.Size(188, 20);
            this.numWaga.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 335);
            this.Controls.Add(this.gbSzczegolyZawodnika);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSciezka);
            this.Controls.Add(this.btnWczytaj);
            this.Controls.Add(this.lbDane);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbSzczegolyZawodnika.ResumeLayout(false);
            this.gbSzczegolyZawodnika.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWzrost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWaga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbDane;
        private System.Windows.Forms.Button btnWczytaj;
        private System.Windows.Forms.TextBox txtSciezka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbSzczegolyZawodnika;
        private System.Windows.Forms.NumericUpDown numWaga;
        private System.Windows.Forms.NumericUpDown numWzrost;
        private System.Windows.Forms.DateTimePicker dtpDataUrodzenia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKraj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNazwisko;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtImie;
    }
}

