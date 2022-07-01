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
    public partial class pocetnaZaposlenikForm : Form
    {
        Korisnik trenutniKorisnik;
        KomunikacijaSBazom baza = new KomunikacijaSBazom();
        public pocetnaZaposlenikForm(Korisnik korisnik)
        {
            InitializeComponent();
            trenutniKorisnik = korisnik;
        }
        public pocetnaZaposlenikForm()
        {
            InitializeComponent();
        }

        private void Filter(int optionIndex)
        {
            switch (optionIndex)
            {
                case 0: OsvjeziPodatke(); break;
                case 1: PrikaziNepotvrdene(); break;
                case 2: PrikaziPotvrdene(); break;
                case 3: PrikaziOtkazane(); break;
                case 4: PrikaziZavrsene(); break;
                default:
                    break;
            }
        }

        private void PrikaziZavrsene()
        {
            dgvSveNarudzbe.DataSource = baza.PrikaziZavrseneNarudzbe();
            PostaviNaslove();
        }

        private void PrikaziOtkazane()
        {
            dgvSveNarudzbe.DataSource = baza.PrikaziOtkazaneNarudzbe();
            PostaviNaslove();
        }

        private void PrikaziPotvrdene()
        {
            dgvSveNarudzbe.DataSource = baza.PrikaziPotvrdeneNarudzbe();
            PostaviNaslove();
        }

        private void PrikaziNepotvrdene()
        {
            dgvSveNarudzbe.DataSource = baza.PrikaziNepotvrdeneNarudzbe();
            PostaviNaslove();
        }

        private void PostaviNaslove()
        {
            dgvSveNarudzbe.Columns["Korisnik"].Visible = false;
            dgvSveNarudzbe.Columns["Korisnik1"].Visible = false;
            dgvSveNarudzbe.Columns["Napredak"].Visible = false;
            dgvSveNarudzbe.Columns["Vozilo1"].Visible = false;
            dgvSveNarudzbe.Columns["Sadrzi_dio"].Visible = false;

            dgvSveNarudzbe.Columns["Vozilo"].HeaderText = "Registracija vozila";
            dgvSveNarudzbe.Columns["Datum_narudzbe"].HeaderText = "Datum narudžbe";
            dgvSveNarudzbe.Columns["Korisnicko_ime"].HeaderText = "Korisničko ime";
            dgvSveNarudzbe.Columns["ID_narudzbe"].HeaderText = "ID narudžbe";
            dgvSveNarudzbe.Columns["Zavrsena"].HeaderText = "Završeno";
            dgvSveNarudzbe.Columns["Ukupna_cijena"].HeaderText = "Cijena";

            dgvKupovinaDijelova.Columns["Dio_u_kupovini"].Visible = false;
            dgvKupovinaDijelova.Columns["Korisnik"].Visible = false;

            dgvKupovinaDijelova.Columns["ID_kupovine"].HeaderText = "ID Kupovine";
            dgvKupovinaDijelova.Columns["Ukupna_cijena"].HeaderText = "Ukupna cijena";
            dgvKupovinaDijelova.Columns["Datum_kupovine"].HeaderText = "Datum kupovine";
            dgvKupovinaDijelova.Columns["Status_kupovine"].HeaderText = "Status kupovine";
        }

        private void OsvjeziPodatke()
        {

            dgvSveNarudzbe.DataSource = baza.DohvatiSveNarudzbeSortPoDatumu();
            dgvKupovinaDijelova.DataSource = baza.DohvatiSveKupovineSortPoDatumu();
            PostaviNaslove();
            

        }

        private void pocetnaZaposlenikForm_Load(object sender, EventArgs e)
        {
            OsvjeziPodatke();
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            Filter(cmbFilter.SelectedIndex);
        }

        private void dgvSveNarudzbe_SelectionChanged(object sender, EventArgs e)
        {
            Narudzba odabranaNarudzba = dgvSveNarudzbe.CurrentRow.DataBoundItem as Narudzba;
            if (odabranaNarudzba.Potvrđeno == 0 && odabranaNarudzba.Otkazano != 1 && odabranaNarudzba.Zavrsena == 0)
            {
                buttonPotvrdi.Enabled = true;
            }
            else
            {
                buttonPotvrdi.Enabled = false;
            }

            if(odabranaNarudzba.Zavrsena == 1 || odabranaNarudzba.Otkazano == 1 || odabranaNarudzba.Potvrđeno == 0)
            {
                buttonNapredak.Enabled = false;
                buttonDijelovi.Enabled = false;
            }
            else
            {
                buttonNapredak.Enabled = true;
                buttonDijelovi.Enabled = true;
            }

            if(odabranaNarudzba.Zavrsena == 1 || odabranaNarudzba.Potvrđeno == 0 || odabranaNarudzba.Otkazano == 1)
            {
                buttonZavrsi.Enabled = false;
            }
            else
            {
                buttonZavrsi.Enabled = true;
            }
        }

        private void buttonPotvrdi_Click(object sender, EventArgs e)
        {
            if (dgvSveNarudzbe.SelectedRows.Count > 0)
            {
                var selektiranaNarudzba = dgvSveNarudzbe.CurrentRow.DataBoundItem as Narudzba;
                baza.PotvrdiNarudzbu(selektiranaNarudzba);
            }
            OsvjeziPodatke();
        }

        private void buttonNapredak_Click(object sender, EventArgs e)
        {
            dodajNapredakZaposlenikForm dodajNapredak = new dodajNapredakZaposlenikForm(dgvSveNarudzbe.CurrentRow.DataBoundItem as Narudzba);
            this.Hide();
            dodajNapredak.ShowDialog();
            this.Show();
            OsvjeziPodatke();
        }

        private void buttonZavrsi_Click(object sender, EventArgs e)
        {
            if (dgvSveNarudzbe.SelectedRows.Count > 0)
            {
                var selektiranaNarudzba = dgvSveNarudzbe.CurrentRow.DataBoundItem as Narudzba;
                baza.ZavrsiNarudzbu(selektiranaNarudzba);
            }
            OsvjeziPodatke();
        }

        private void buttonDijelovi_Click(object sender, EventArgs e)
        {
            var selektiranaNarudzba = dgvSveNarudzbe.CurrentRow.DataBoundItem as Narudzba;
            dodajDijeloveZaposlenikForm dodajDijelove = new dodajDijeloveZaposlenikForm(selektiranaNarudzba);
            dodajDijelove.ShowDialog();
        }

        private void buttonKreirajKupovinu_Click(object sender, EventArgs e)
        {
            //baza.KreirajKupovinu(trenutniKorisnik);
            OsvjeziPodatke();
        }

        private void buttonDijeloviKupovina_Click(object sender, EventArgs e)
        {
            dodajDijeloveUKupovinuZaposlenikForm dodajDijeloveUKupovinu = new dodajDijeloveUKupovinuZaposlenikForm(dgvKupovinaDijelova.CurrentRow.DataBoundItem as Kupovina);
            dodajDijeloveUKupovinu.ShowDialog();
            OsvjeziPodatke();
        }

        private void buttonKupovinaZavrsena_Click(object sender, EventArgs e)
        {
            if (dgvKupovinaDijelova.SelectedRows.Count > 0)
            {
                Kupovina odabranaKupovina = dgvKupovinaDijelova.CurrentRow.DataBoundItem as Kupovina;
                baza.ZavrsiKupovinu(odabranaKupovina);
            }
            OsvjeziPodatke();
        }

        private void dgvKupovinaDijelova_SelectionChanged(object sender, EventArgs e)
        {
            Kupovina odabranaKupovina = dgvKupovinaDijelova.CurrentRow.DataBoundItem as Kupovina;
            
            if(odabranaKupovina.Status_kupovine == "Završena")
            {
                buttonDijeloviKupovina.Enabled = false;
                buttonKupovinaZavrsena.Enabled = false;
            }
            else
            {
                buttonDijeloviKupovina.Enabled = true;
                buttonKupovinaZavrsena.Enabled = true;
            }
            
        }

        private void pocetnaZaposlenikForm_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Pomoc pomoc = new Pomoc();
            pomoc.OtvoriPomocDjelatnik(this, "pocetnaZaposlenik.htm");
        }
    }
}
