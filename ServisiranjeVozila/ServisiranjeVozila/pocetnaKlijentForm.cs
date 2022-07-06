using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using F1_pomoc;
using Baza;

namespace ServisiranjeVozila
{
    public partial class PocetnaKlijentForm : Form
    {
        Korisnik trenutniKorisnik;
        KomunikacijaSBazom baza = new KomunikacijaSBazom();
        public PocetnaKlijentForm(Korisnik korisnik)
        {
            InitializeComponent();
            trenutniKorisnik = korisnik;
        }
        public PocetnaKlijentForm()
        {
            InitializeComponent();
        }

        private void OsvjeziPodatke()
        {

            dgvKorisnikoveNarudzbe.DataSource = baza.DohvatiNarudzbeKorisnika(trenutniKorisnik);
            PostaviNaslove();
        }

        private void PostaviNaslove()
        {
            dgvKorisnikoveNarudzbe.Columns["ID_narudzbe"].Visible = false;
            dgvKorisnikoveNarudzbe.Columns["Korisnicko_ime"].Visible = false;
            dgvKorisnikoveNarudzbe.Columns["Korisnik"].Visible = false;
            dgvKorisnikoveNarudzbe.Columns["Korisnik1"].Visible = false;
            dgvKorisnikoveNarudzbe.Columns["Napredak"].Visible = false;
            dgvKorisnikoveNarudzbe.Columns["Sadrzi_dio"].Visible = false;
            dgvKorisnikoveNarudzbe.Columns["Potvrđeno"].Visible = false;
            dgvKorisnikoveNarudzbe.Columns["Otkazano"].Visible = false;
            dgvKorisnikoveNarudzbe.Columns["Zavrsena"].Visible = false;
            dgvKorisnikoveNarudzbe.Columns["Vozilo1"].Visible = false;
            dgvKorisnikoveNarudzbe.Columns["Ukupna_cijena"].Visible = false;


            dgvKorisnikoveNarudzbe.Columns["Datum_narudzbe"].HeaderText = "Datum narudžbe";
        }

        private void PocetnaKlijentForm_Load(object sender, EventArgs e)
        {
            OsvjeziPodatke();
            

        }

        private void detaljiNarudzbe_Click(object sender, EventArgs e)
        {
            var odabranaNarudzba = dgvKorisnikoveNarudzbe.CurrentRow.DataBoundItem as Narudzba;
            detaljiNarudzbeKlijentForm detaljiNarudzbeForm = new detaljiNarudzbeKlijentForm(odabranaNarudzba);
            detaljiNarudzbeForm.ShowDialog();
            OsvjeziPodatke();
        }

        private void PocetnaKlijentForm_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Pomoc pomoc = new Pomoc();
            pomoc.OtvoriPomocKorisnik(this, "pocetnaKlijent.htm");
        }

        private void buttonKreirajNarudzbu_Click(object sender, EventArgs e)
        {
            kreirajNarudzbuKlijentForm kreirajNarudzbu = new kreirajNarudzbuKlijentForm(trenutniKorisnik);
            this.Hide();
            kreirajNarudzbu.ShowDialog();
            this.Show();
            OsvjeziPodatke();
        }

        private void buttonPregledVozila_Click(object sender, EventArgs e)
        {
            pregledVozilaKlijentForm pregledVozila = new pregledVozilaKlijentForm(trenutniKorisnik);
            this.Hide();
            pregledVozila.ShowDialog();
            this.Show();
        }

        private void PregledOdradenihRadovaNaVozilu_Click(object sender, EventArgs e)
        {
            pregledOdradenihRadovaNaVozilu pregledRadova = new pregledOdradenihRadovaNaVozilu(trenutniKorisnik);
            this.Hide();
            pregledRadova.ShowDialog();
            this.Show();
        }
    }
}
