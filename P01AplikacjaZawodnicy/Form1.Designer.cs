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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSciezka = new System.Windows.Forms.TextBox();
            this.btnWczytaj = new System.Windows.Forms.Button();
            this.lbDane = new System.Windows.Forms.ListBox();
            this.btnZapisz = new System.Windows.Forms.Button();
            this.btnEdytuj = new System.Windows.Forms.Button();
            this.gbSzczegolyZawodnika = new System.Windows.Forms.GroupBox();
            this.numWaga = new System.Windows.Forms.NumericUpDown();
            this.numWzrost = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKraj = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNazwisko = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDataUrodzenia = new System.Windows.Forms.TextBox();
            this.dtpDataUrodzenia = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnNowy = new System.Windows.Forms.Button();
            this.txtBlednieSformatowaneWiersze = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnUsun = new System.Windows.Forms.Button();
            this.txtPotwierdzUsuniecie = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtImie = new P01AplikacjaZawodnicy.Dodatki.ExTextBox();
            this.btnZapiszJako = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.gbSzczegolyZawodnika.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWaga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWzrost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Panel2.Controls.Add(this.txtPotwierdzUsuniecie);
            this.splitContainer1.Panel2.Controls.Add(this.btnUsun);
            this.splitContainer1.Panel2.Controls.Add(this.btnNowy);
            this.splitContainer1.Panel2.Controls.Add(this.btnZapisz);
            this.splitContainer1.Panel2.Controls.Add(this.btnEdytuj);
            this.splitContainer1.Size = new System.Drawing.Size(976, 549);
            this.splitContainer1.SplitterDistance = 504;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.btnZapiszJako);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.txtSciezka);
            this.splitContainer2.Panel1.Controls.Add(this.btnWczytaj);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.lbDane);
            this.splitContainer2.Size = new System.Drawing.Size(504, 549);
            this.splitContainer2.SplitterDistance = 40;
            this.splitContainer2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ścieżka";
            // 
            // txtSciezka
            // 
            this.txtSciezka.Location = new System.Drawing.Point(146, 14);
            this.txtSciezka.Name = "txtSciezka";
            this.txtSciezka.Size = new System.Drawing.Size(177, 20);
            this.txtSciezka.TabIndex = 12;
            this.txtSciezka.Text = "C:\\dane\\zawodnicy.txt";
            this.txtSciezka.Click += new System.EventHandler(this.txtSciezka_Click);
            // 
            // btnWczytaj
            // 
            this.btnWczytaj.Location = new System.Drawing.Point(13, 11);
            this.btnWczytaj.Name = "btnWczytaj";
            this.btnWczytaj.Size = new System.Drawing.Size(75, 23);
            this.btnWczytaj.TabIndex = 11;
            this.btnWczytaj.Text = "Wczytaj";
            this.btnWczytaj.UseVisualStyleBackColor = true;
            this.btnWczytaj.Click += new System.EventHandler(this.btnWczytaj_Click);
            // 
            // lbDane
            // 
            this.lbDane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDane.FormattingEnabled = true;
            this.lbDane.Location = new System.Drawing.Point(0, 0);
            this.lbDane.Name = "lbDane";
            this.lbDane.Size = new System.Drawing.Size(504, 505);
            this.lbDane.TabIndex = 10;
            this.lbDane.SelectedIndexChanged += new System.EventHandler(this.lbDane_SelectedIndexChanged);
            // 
            // btnZapisz
            // 
            this.btnZapisz.Location = new System.Drawing.Point(178, 12);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(52, 23);
            this.btnZapisz.TabIndex = 12;
            this.btnZapisz.Text = "Zapisz";
            this.btnZapisz.UseVisualStyleBackColor = true;
            this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);
            // 
            // btnEdytuj
            // 
            this.btnEdytuj.Location = new System.Drawing.Point(16, 12);
            this.btnEdytuj.Name = "btnEdytuj";
            this.btnEdytuj.Size = new System.Drawing.Size(75, 23);
            this.btnEdytuj.TabIndex = 11;
            this.btnEdytuj.Text = "Edytuj";
            this.btnEdytuj.UseVisualStyleBackColor = true;
            this.btnEdytuj.Click += new System.EventHandler(this.btnEdytuj_Click);
            // 
            // gbSzczegolyZawodnika
            // 
            this.gbSzczegolyZawodnika.Controls.Add(this.txtImie);
            this.gbSzczegolyZawodnika.Controls.Add(this.numWaga);
            this.gbSzczegolyZawodnika.Controls.Add(this.numWzrost);
            this.gbSzczegolyZawodnika.Controls.Add(this.label7);
            this.gbSzczegolyZawodnika.Controls.Add(this.label6);
            this.gbSzczegolyZawodnika.Controls.Add(this.label5);
            this.gbSzczegolyZawodnika.Controls.Add(this.label4);
            this.gbSzczegolyZawodnika.Controls.Add(this.txtKraj);
            this.gbSzczegolyZawodnika.Controls.Add(this.label3);
            this.gbSzczegolyZawodnika.Controls.Add(this.txtNazwisko);
            this.gbSzczegolyZawodnika.Controls.Add(this.label2);
            this.gbSzczegolyZawodnika.Controls.Add(this.txtDataUrodzenia);
            this.gbSzczegolyZawodnika.Controls.Add(this.dtpDataUrodzenia);
            this.gbSzczegolyZawodnika.Location = new System.Drawing.Point(20, 26);
            this.gbSzczegolyZawodnika.Name = "gbSzczegolyZawodnika";
            this.gbSzczegolyZawodnika.Size = new System.Drawing.Size(214, 299);
            this.gbSzczegolyZawodnika.TabIndex = 10;
            this.gbSzczegolyZawodnika.TabStop = false;
            this.gbSzczegolyZawodnika.Text = "Zawodnik";
            this.gbSzczegolyZawodnika.Visible = false;
            // 
            // numWaga
            // 
            this.numWaga.Location = new System.Drawing.Point(10, 251);
            this.numWaga.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numWaga.Name = "numWaga";
            this.numWaga.ReadOnly = true;
            this.numWaga.Size = new System.Drawing.Size(188, 20);
            this.numWaga.TabIndex = 6;
            // 
            // numWzrost
            // 
            this.numWzrost.InterceptArrowKeys = false;
            this.numWzrost.Location = new System.Drawing.Point(10, 207);
            this.numWzrost.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numWzrost.Name = "numWzrost";
            this.numWzrost.ReadOnly = true;
            this.numWzrost.Size = new System.Drawing.Size(188, 20);
            this.numWzrost.TabIndex = 5;
            this.numWzrost.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Wzrost";
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
            this.txtKraj.ReadOnly = true;
            this.txtKraj.Size = new System.Drawing.Size(188, 20);
            this.txtKraj.TabIndex = 3;
            this.txtKraj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKraj_KeyPress);
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
            this.txtNazwisko.ReadOnly = true;
            this.txtNazwisko.Size = new System.Drawing.Size(188, 20);
            this.txtNazwisko.TabIndex = 2;
            this.txtNazwisko.Validating += new System.ComponentModel.CancelEventHandler(this.txtNazwisko_Validating);
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
            // txtDataUrodzenia
            // 
            this.txtDataUrodzenia.Location = new System.Drawing.Point(10, 167);
            this.txtDataUrodzenia.Name = "txtDataUrodzenia";
            this.txtDataUrodzenia.ReadOnly = true;
            this.txtDataUrodzenia.Size = new System.Drawing.Size(188, 20);
            this.txtDataUrodzenia.TabIndex = 4;
            // 
            // dtpDataUrodzenia
            // 
            this.dtpDataUrodzenia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataUrodzenia.Location = new System.Drawing.Point(10, 167);
            this.dtpDataUrodzenia.Name = "dtpDataUrodzenia";
            this.dtpDataUrodzenia.Size = new System.Drawing.Size(188, 20);
            this.dtpDataUrodzenia.TabIndex = 12;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnNowy
            // 
            this.btnNowy.Location = new System.Drawing.Point(97, 12);
            this.btnNowy.Name = "btnNowy";
            this.btnNowy.Size = new System.Drawing.Size(75, 23);
            this.btnNowy.TabIndex = 13;
            this.btnNowy.Text = "Nowy";
            this.btnNowy.UseVisualStyleBackColor = true;
            this.btnNowy.Click += new System.EventHandler(this.btnNowy_Click);
            // 
            // txtBlednieSformatowaneWiersze
            // 
            this.txtBlednieSformatowaneWiersze.Location = new System.Drawing.Point(9, 29);
            this.txtBlednieSformatowaneWiersze.Multiline = true;
            this.txtBlednieSformatowaneWiersze.Name = "txtBlednieSformatowaneWiersze";
            this.txtBlednieSformatowaneWiersze.Size = new System.Drawing.Size(223, 381);
            this.txtBlednieSformatowaneWiersze.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Błędnie sformatowane wiersze";
            // 
            // btnUsun
            // 
            this.btnUsun.Location = new System.Drawing.Point(245, 12);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(52, 23);
            this.btnUsun.TabIndex = 16;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // txtPotwierdzUsuniecie
            // 
            this.txtPotwierdzUsuniecie.Location = new System.Drawing.Point(303, 17);
            this.txtPotwierdzUsuniecie.Name = "txtPotwierdzUsuniecie";
            this.txtPotwierdzUsuniecie.Size = new System.Drawing.Size(52, 20);
            this.txtPotwierdzUsuniecie.TabIndex = 17;
            this.txtPotwierdzUsuniecie.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(16, 51);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(255, 442);
            this.tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gbSzczegolyZawodnika);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(247, 416);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Szczegóły";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtBlednieSformatowaneWiersze);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(247, 416);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Błędne wiersze";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtImie
            // 
            this.txtImie.BorderColor = System.Drawing.Color.Blue;
            this.txtImie.Location = new System.Drawing.Point(10, 38);
            this.txtImie.Name = "txtImie";
            this.txtImie.ReadOnly = true;
            this.txtImie.Size = new System.Drawing.Size(188, 20);
            this.txtImie.TabIndex = 1;
            this.txtImie.TextChanged += new System.EventHandler(this.txtImie_TextChanged);
            // 
            // btnZapiszJako
            // 
            this.btnZapiszJako.Location = new System.Drawing.Point(397, 12);
            this.btnZapiszJako.Name = "btnZapiszJako";
            this.btnZapiszJako.Size = new System.Drawing.Size(75, 23);
            this.btnZapiszJako.TabIndex = 14;
            this.btnZapiszJako.Text = "Zapisz";
            this.btnZapiszJako.UseVisualStyleBackColor = true;
            this.btnZapiszJako.Click += new System.EventHandler(this.btnZapiszJako_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(976, 549);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.gbSzczegolyZawodnika.ResumeLayout(false);
            this.gbSzczegolyZawodnika.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWaga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWzrost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSciezka;
        private System.Windows.Forms.Button btnWczytaj;
        private System.Windows.Forms.ListBox lbDane;
        private System.Windows.Forms.Button btnEdytuj;
        private System.Windows.Forms.GroupBox gbSzczegolyZawodnika;
        private System.Windows.Forms.NumericUpDown numWaga;
        private System.Windows.Forms.NumericUpDown numWzrost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNazwisko;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDataUrodzenia;
        private System.Windows.Forms.DateTimePicker dtpDataUrodzenia;
        private Dodatki.ExTextBox txtImie;
        private System.Windows.Forms.Button btnZapisz;
        private System.Windows.Forms.TextBox txtKraj;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnNowy;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBlednieSformatowaneWiersze;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.TextBox txtPotwierdzUsuniecie;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnZapiszJako;
    }
}

