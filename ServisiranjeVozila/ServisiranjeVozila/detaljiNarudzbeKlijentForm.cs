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
    public partial class detaljiNarudzbeKlijentForm : Form
    {
        private Narudzba odabranaNarudzba;
        KomunikacijaSBazom baza = new KomunikacijaSBazom();
        public detaljiNarudzbeKlijentForm(Narudzba narudzba)
        {
            odabranaNarudzba = narudzba;
            InitializeComponent();
        }
        public detaljiNarudzbeKlijentForm()
        {
            InitializeComponent();
        }

        //Iz klase "Baza" dohvaća podatke, pridružuje ih dataGridView-u,
        //sakriva podatke koji korisniku nisu potrebni te postavlja naslove stupaca
        private void DohvatiDijelove()
        {
            dgvDijelovi.DataSource = baza.DohvatiDijeloveZaOdabranuNarudzbu(odabranaNarudzba);

            dgvDijelovi.Columns["ID_dijela"].Visible = false;
            dgvDijelovi.Columns["Sifra_dijela"].Visible = false;
            dgvDijelovi.Columns["Dio_u_kupovini"].Visible = false;
            dgvDijelovi.Columns["Sadrzi_dio"].Visible = false;
            dgvDijelovi.Columns["Naziv_dijela"].HeaderText = "Naziv dijela";
            dgvDijelovi.Columns["Opis_dijela"].HeaderText = "Opis";
        }

        //Iz klase "Baza" dohvaća podatke i prikazuje ih u textBox
        private void DohvatiNapredak()
        {
            dgvNapredak.DataSource = baza.DohvatiNapredakZaOdabranuNarudzbu(odabranaNarudzba);
            
        }

        //Kod učitavanja forme dohvaćaju se i prikazuju podaci
        private void detaljiNarudzbeForm_Load(object sender, EventArgs e)
        {
            DohvatiDijelove();
            DohvatiNapredak();
            textBoxKorime.Text = odabranaNarudzba.Korisnicko_ime.ToString();
            textBoxNapomena.Text = odabranaNarudzba.Napomene.ToString();
            textBoxDatum.Text = odabranaNarudzba.Datum_narudzbe.ToString();

            if(odabranaNarudzba.Potvrđeno == 0)
            {
                radioButtonPotvrdeno.Checked = false;
            }
            else
            {
                radioButtonPotvrdeno.Checked = true;
            }

            if (odabranaNarudzba.Otkazano == 0)
            {
                radioButtonOtkazano.Checked = false;
            }
            else
            {
                radioButtonOtkazano.Checked = true;
            }

            if (odabranaNarudzba.Zavrsena == 0)
            {
                radioButtonZavrseno.Checked = false;
            }
            else
            {
                radioButtonZavrseno.Checked = true;
            }

            if(odabranaNarudzba.Zavrsena == 0 && odabranaNarudzba.Potvrđeno == 0 && odabranaNarudzba.Otkazano == 0)
            {
                buttonOtkazi.Enabled = true;
            }




        }

        //Klikom na gumb poziva metodu OtkaziNarudzbu
        private void buttonOtkazi_Click(object sender, EventArgs e)
        {
            baza.OtkaziNarudzbu(odabranaNarudzba);
            radioButtonOtkazano.Checked = true;
            buttonOtkazi.Enabled = false;
        }

        //Klikom na gumb za zatvaranje zatvara formu
        private void buttonZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Pritiskom na F1 otvara se pomoć
        private void detaljiNarudzbeKlijentForm_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Pomoc pomoc = new Pomoc();
            pomoc.OtvoriPomocKorisnik(this, "detaljiNarudzbe.htm");
        }
    }
}
