using P01AplikacjaZawodnicy.Dodatki;
using P01AplikacjaZawodnicy.Domains;
using P01AplikacjaZawodnicy.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P01AplikacjaZawodnicy
{
    public partial class Form1 : Form
    {
        ManagerZawodnikow mz;
        bool edycjaAktywna = false;
        public Form1()
        {
            InitializeComponent();

            numWzrost.Maximum = decimal.MaxValue;
            numWaga.Maximum = decimal.MaxValue;

            // mozna dodac kontroke dynamiczne 
            //ExTextBox exTextBox = new ExTextBox();
            //exTextBox.Location = new System.Drawing.Point(10, 37);
            //exTextBox.Name = "txtImie";
            //exTextBox.ReadOnly = true;
            //exTextBox.Size = new System.Drawing.Size(188, 20);
            //exTextBox.TabIndex = 0;
            //// exTextBox.TextChanged += new System.EventHandler(this.txtImie_TextChanged);
            //gbSzczegolyZawodnika.Controls.Add(exTextBox);

        }

        private void txtSciezka_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "pliki tekstowe (*.txt)|*.txt|wszystkie pliki (*.*)|*.*";
            ofd.ShowDialog();
            
            txtSciezka.Text = ofd.FileName;
        }

        private void btnWczytaj_Click(object sender, EventArgs e)
        {
            Odswiez();
        }

        private void Odswiez()
        {
            mz = new ManagerZawodnikow(txtSciezka.Text, TypImportu.Loklany);
            Zawodnik[] zawodnicy = mz.WczytajZawodnikow();

            //WErsja 1: 
            // wczytwanie rekord po rekodzie 
            // UWAGA: nasz listbox przechowuje napisy (stringi) 
            //foreach (var z in zawodnicy)
            //lbDane.Items.Add(z.Imie + " " + z.Nazwisko + " " + z.Kraj);

            //Wersja2: 
            // zastosowanie databinding 
            lbDane.DataSource = zawodnicy;
            lbDane.DisplayMember = "Wiersz";
        }

        private void lbDane_SelectedIndexChanged(object sender, EventArgs e)
        {
            gbSzczegolyZawodnika.Visible = true;

            // wersja gdy szukamy po indeksie (niebezpieczna ze wzledu np na sorotwanie, filtorwanie )
            // int indeks = lbDane.SelectedIndex;
            // Zawodnik zaznaczony= mz.Zawodnicy[indeks];
            // Ulopszona wersja wykorzystujaca fakt, ze dane sa teraz zbindowanie z listbox 
            Zawodnik zaznaczony = (Zawodnik)lbDane.SelectedItem;

            txtImie.Text = zaznaczony.Imie;
            txtNazwisko.Text = zaznaczony.Nazwisko;
            txtKraj.Text = zaznaczony.Kraj;
            dtpDataUrodzenia.Value = zaznaczony.DataUrodzenia;
            
            numWaga.Value = zaznaczony.Waga;
            numWaga.Increment = 0;
           // numWaga.Maximum = numWaga.Value;
           // numWaga.Minimum = numWaga.Value;

            numWzrost.Value = zaznaczony.Wzrost;
            numWzrost.Increment = 0;
            //numWzrost.Maximum = numWzrost.Value;
            //numWzrost.Minimum = numWzrost.Value;

            //dtpDataUrodzenia.MaxDate = dtpDataUrodzenia.Value;
            //dtpDataUrodzenia.MinDate = dtpDataUrodzenia.Value;

            txtDataUrodzenia.Text = zaznaczony.DataUrodzenia.ToString("dd.MM.yyyy");

            //ZablokujZawodnika();
            txtImie.BorderColor = Color.Black;
        }

        
        private void btnEdytuj_Click(object sender, EventArgs e)
        {
            if (!edycjaAktywna)
                OdblokujZawodnika();
            else
                ZablokujZawodnika();

            edycjaAktywna = !edycjaAktywna;
        }

        public void ZablokujZawodnika()
        {
            foreach (var item in gbSzczegolyZawodnika.Controls)
            {
                if (item is TextBox)
                    ((TextBox)item).ReadOnly = true;

                if (item is NumericUpDown)
                    ((NumericUpDown)item).ReadOnly = true;
            }
            txtDataUrodzenia.Visible = true;
            numWzrost.Increment = 0;
            numWaga.Increment = 0;
            numWaga.BackColor = SystemColors.Control;

            txtImie.BorderColor = Color.Black;


        }

        public void OdblokujZawodnika()
        {
            //    txtImie.ReadOnly = true;
            //    txtNazwisko.ReadOnly = true;
            //txtKraj.ReadOnly = true;

            foreach (var item in gbSzczegolyZawodnika.Controls)
            {
                if (item is TextBox)
                    ((TextBox)item).ReadOnly = false;

                if (item is NumericUpDown)
                    ((NumericUpDown)item).ReadOnly = false;
            }
            txtDataUrodzenia.Visible = false;
            numWzrost.Increment = 1;
            numWaga.Increment = 1;

            if (numWaga.Value > 100)
                numWaga.BackColor = Color.Red;
            else
                numWaga.BackColor = Color.White;
        }



        private void txtImie_TextChanged(object sender, EventArgs e)
        {
            if(edycjaAktywna)
                txtImie.BorderColor = Color.Red;
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            // krok 1 : 
            // kto jest zaznaczony 
            // mz.Zawodnicy[2]
            Zawodnik z = (Zawodnik)lbDane.SelectedItem;

            z.Imie = txtImie.Text;
            z.Nazwisko = txtNazwisko.Text;
            z.Kraj = txtKraj.Text;
            z.DataUrodzenia = dtpDataUrodzenia.Value;
            z.Waga = Convert.ToInt32(numWaga.Value);
            z.Wzrost = Convert.ToInt32(numWzrost.Value);

            mz.EdytujZawodnika(z);
            mz.Zapisz();
            Odswiez();
        }

        //private void txtKraj_Validating(object sender, CancelEventArgs e)
        //{
        //    if (txtKraj.Text.Length > 3)
        //    {
        //        MessageBox.Show("Niepoprawny format kraju");
        //    }
        //}

        private void txtKraj_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtKraj.Text.Length > 3)
            {
                e.Handled = true;
                //MessageBox.Show("Niepoprawny format kraju");
            }
         }

        private void txtKraj_TextChanged(object sender, EventArgs e)
        {
          
        }


        //https://github.com/tomasz-trener/12DDzien5
        //https://github.com/tomasz-trener/12ZDzien4
    }
}


// PWA Progressive Web Application  (w Visual studio Blazor)