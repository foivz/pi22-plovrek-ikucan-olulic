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

        private void DohvatiDijelove()
        {
            dgvDijelovi.DataSource = baza.DohvatiDijeloveZaOdabranuNarudzbu(odabranaNarudzba);

            dgvDijelovi.Columns["ID_dijela"].Visible = false;
            dgvDijelovi.Columns["Sifra_dijela"].Visible = false;
            dgvDijelovi.Columns["Kupovina"].Visible = false;
            dgvDijelovi.Columns["Narudzba"].Visible = false;
            dgvDijelovi.Columns["Naziv_dijela"].HeaderText = "Naziv dijela";
            dgvDijelovi.Columns["Opis_dijela"].HeaderText = "Opis";
        }

        private void DohvatiNapredak()
        {
            var podaciNapredak = baza.DohvatiNapredakZaOdabranuNarudzbu(odabranaNarudzba);
            foreach (var pod in podaciNapredak)
            {
                textBoxNapredak.Text += pod.Opis.ToString() + "\r\n";
            }
        }

        private void detaljiNarudzbeForm_Load(object sender, EventArgs e)
        {
            DohvatiDijelove();
            DohvatiNapredak();
            textBoxKorime.Text = odabranaNarudzba.Korisnicko_ime.ToString();
            textBoxRegistracija.Text = odabranaNarudzba.Registracija_vozila.ToString();
            textBoxMarka.Text = odabranaNarudzba.Marka_vozila.ToString();
            textBoxModel.Text = odabranaNarudzba.Model_vozila.ToString();
            textBoxStanje.Text = odabranaNarudzba.Stanje_brojaca.ToString();
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

        private void buttonOtkazi_Click(object sender, EventArgs e)
        {
            baza.OtkaziNarudzbu(odabranaNarudzba);
            radioButtonOtkazano.Checked = true;
            buttonOtkazi.Enabled = false;
        }

        private void buttonZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
