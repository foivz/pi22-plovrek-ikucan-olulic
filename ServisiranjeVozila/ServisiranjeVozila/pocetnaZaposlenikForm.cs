using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServisiranjeVozila
{
    public partial class pocetnaZaposlenikForm : Form
    {
        Korisnik trenutniKorisnik;
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
            using (var context = new EntitetiBaze())
            {
                var query = from n in context.Narudzba
                            where n.Zavrsena == 1
                            orderby n.Datum_narudzbe
                            select n;
                var podaci = query.ToList();
                dgvSveNarudzbe.DataSource = null;
                dgvSveNarudzbe.DataSource = podaci;
            }
            PostaviNaslove();
        }

        private void PrikaziOtkazane()
        {
            using (var context = new EntitetiBaze())
            {
                var query = from n in context.Narudzba
                            where n.Otkazano == 1
                            orderby n.Datum_narudzbe
                            select n;
                var podaci = query.ToList();
                dgvSveNarudzbe.DataSource = null;
                dgvSveNarudzbe.DataSource = podaci;
            }
            PostaviNaslove();
        }

        private void PrikaziPotvrdene()
        {
            using (var context = new EntitetiBaze())
            {
                var query = from n in context.Narudzba
                            where n.Potvrđeno == 1
                            orderby n.Datum_narudzbe
                            select n;
                var podaci = query.ToList();
                dgvSveNarudzbe.DataSource = null;
                dgvSveNarudzbe.DataSource = podaci;
            }
            PostaviNaslove();
        }

        private void PrikaziNepotvrdene()
        {
            using (var context = new EntitetiBaze())
            {
                var query = from n in context.Narudzba
                            where n.Potvrđeno == 0
                            orderby n.Datum_narudzbe
                            select n;
                var podaci = query.ToList();
                dgvSveNarudzbe.DataSource = null;
                dgvSveNarudzbe.DataSource = podaci;
            }
            PostaviNaslove();
        }

        private void PostaviNaslove()
        {
            dgvSveNarudzbe.Columns["Korisnik"].Visible = false;
            dgvSveNarudzbe.Columns["Racun"].Visible = false;
            dgvSveNarudzbe.Columns["Dijelovi"].Visible = false;
            dgvSveNarudzbe.Columns["Napredak"].Visible = false;

            dgvSveNarudzbe.Columns["Registracija_vozila"].HeaderText = "Registracija vozila";
            dgvSveNarudzbe.Columns["Marka_vozila"].HeaderText = "Marka";
            dgvSveNarudzbe.Columns["Model_vozila"].HeaderText = "Model";
            dgvSveNarudzbe.Columns["Stanje_brojaca"].HeaderText = "Stanje brojača";
            dgvSveNarudzbe.Columns["Datum_narudzbe"].HeaderText = "Datum narudžbe";
            dgvSveNarudzbe.Columns["Korisnicko_ime"].HeaderText = "Korisničko ime";
            dgvSveNarudzbe.Columns["ID_narudzbe"].HeaderText = "ID narudžbe";
            dgvSveNarudzbe.Columns["Zavrsena"].HeaderText = "Završeno";

            dgvKupovinaDijelova.Columns["Dijelovi"].Visible = false;
            dgvKupovinaDijelova.Columns["ID_kupovine"].HeaderText = "ID Kupovine";
            dgvKupovinaDijelova.Columns["Ukupna_cijena"].HeaderText = "Ukupna cijena";
            dgvKupovinaDijelova.Columns["Datum_kupovine"].HeaderText = "Datum kupovine";
            dgvKupovinaDijelova.Columns["Status_kupovina"].HeaderText = "Status kupovine";
        }

        private void OsvjeziPodatke()
        {
            using (var context = new EntitetiBaze())
            {
                var narudzbe = from n in context.Narudzba
                            orderby n.Datum_narudzbe
                            select n;
                var podaciNarudzbe = narudzbe.ToList();
                dgvSveNarudzbe.DataSource = podaciNarudzbe;

                var kupovine = from k in context.Kupovina
                               orderby k.Datum_kupovine
                               select k;
                var podaciKupovine = kupovine.ToList();
                dgvKupovinaDijelova.DataSource = podaciKupovine;
            }
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
            if (odabranaNarudzba.Potvrđeno == 0)
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
            var selektiranaNarudzba = dgvSveNarudzbe.CurrentRow.DataBoundItem as Narudzba;
            using (var context = new EntitetiBaze())
            {
                context.Narudzba.Attach(selektiranaNarudzba);
                selektiranaNarudzba.Potvrđeno = 1;
                context.SaveChanges();
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
            var selektiranaNarudzba = dgvSveNarudzbe.CurrentRow.DataBoundItem as Narudzba;
            using (var context = new EntitetiBaze())
            {
                context.Narudzba.Attach(selektiranaNarudzba);
                selektiranaNarudzba.Zavrsena = 1;
                context.SaveChanges();
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
            using (var context = new EntitetiBaze())
            {
                Kupovina kupovina = new Kupovina
                {
                    Djelatnik = trenutniKorisnik.Korisnicko_ime,
                    Ukupna_cijena = 0,
                    Datum_kupovine = DateTime.Now,
                    Status_kupovina = "U tijeku"
                };
                context.Kupovina.Add(kupovina);
                context.SaveChanges();
            }
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
            var selektiranaKupovina = dgvKupovinaDijelova.CurrentRow.DataBoundItem as Kupovina;
            using (var context = new EntitetiBaze())
            {
                context.Kupovina.Attach(selektiranaKupovina);
                selektiranaKupovina.Status_kupovina = "Završena";
                context.SaveChanges();
            }
            OsvjeziPodatke();
        }
    }
}
