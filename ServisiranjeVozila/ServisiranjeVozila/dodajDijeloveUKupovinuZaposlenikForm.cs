using F1_pomoc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Baza;

namespace ServisiranjeVozila
{
    public partial class dodajDijeloveUKupovinuZaposlenikForm : Form
    {
        Kupovina odabranaKupovina;
        KomunikacijaSBazom baza = new KomunikacijaSBazom();
        public dodajDijeloveUKupovinuZaposlenikForm(Kupovina kupovina)
        {
            odabranaKupovina = kupovina;
            InitializeComponent();
        }

        //Postavlja naslove dataGridView-ova i sakriva stupce koji nisu potrebni za korisnika
        private void PostaviNaslove()
        {
            dgvDijelovi.Columns["ID_dijela"].Visible = false;
            dgvDijelovi.Columns["Kupovina"].Visible = false;
            dgvDijelovi.Columns["Narudzba"].Visible = false;

            dgvDijelovi.Columns["Naziv_dijela"].HeaderText = "Naziv dijela";
            dgvDijelovi.Columns["Opis_dijela"].HeaderText = "Opis";
            dgvDijelovi.Columns["Sifra_dijela"].HeaderText = "Šifra dijela";

            dgvDijeloviUNarudzbi.Columns["ID_dijela"].Visible = false;
            dgvDijeloviUNarudzbi.Columns["Kupovina"].Visible = false;
            dgvDijeloviUNarudzbi.Columns["Narudzba"].Visible = false;

            dgvDijeloviUNarudzbi.Columns["Naziv_dijela"].HeaderText = "Naziv dijela";
            dgvDijeloviUNarudzbi.Columns["Opis_dijela"].HeaderText = "Opis";
            dgvDijeloviUNarudzbi.Columns["Sifra_dijela"].HeaderText = "Šifra dijela";


        }
        public dodajDijeloveUKupovinuZaposlenikForm()
        {
            InitializeComponent();
        }

        //Iz klase "Baza" dohvaća podatke i prikazuje ih u tablicama
        private void OsvjeziPodatke()
        {
            dgvDijelovi.DataSource = baza.DohvatiDijeloveOsimUKupovini(odabranaKupovina);
            dgvDijeloviUNarudzbi.DataSource = baza.DohvatiDijeloveUKupovini(odabranaKupovina);

            PostaviNaslove();
        }


        private void dodajDijeloveUKupovinuZaposlenikForm_Load(object sender, EventArgs e)
        {
            OsvjeziPodatke();
        }

        //Upisivanjem teksta poziva se metoda te se prikazuju podaci prema upisanom tekstu
        private void textBoxPretrazivanjeNaziv_TextChanged(object sender, EventArgs e)
        {

            dgvDijelovi.DataSource = baza.FiltrirajDijelovePremaNazivuZaKupovinu(textBoxPretrazivanjeNaziv.Text, odabranaKupovina);
            PostaviNaslove();
        }

        //Upisivanjem teksta poziva se metoda te se prikazuju podaci prema upisanom tekstu
        private void textBoxPretrazivanjeSifra_TextChanged(object sender, EventArgs e)
        {
            
            dgvDijelovi.DataSource = baza.FiltrirajDijelovePremaSifriZaKupovinu(textBoxPretrazivanjeSifra.Text, odabranaKupovina);
            PostaviNaslove();
        }

        //Odabrani dio pridružuje kupovini
        private void buttonUNarudzbu_Click(object sender, EventArgs e)
        {
            if(dgvDijelovi.SelectedRows.Count > 0)
            {
                baza.DodajDioUKupovinu(dgvDijelovi.CurrentRow.DataBoundItem as Dijelovi, odabranaKupovina);
                OsvjeziPodatke();
            }
            else
            {
                MessageBox.Show("Označite red!");
            }
            
        }

        private void buttonZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dodajDijeloveUKupovinuZaposlenikForm_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Pomoc pomoc = new Pomoc();
            pomoc.OtvoriPomocDjelatnik(this, "dodajDijeloveKupoviniZaposlenik.htm");
        }
    }
}
