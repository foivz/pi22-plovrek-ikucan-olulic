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
            using (var context = new EntitetiBaze())
            {
                var query = from d in context.Dijelovi
                            where d.Narudzba.Any(n=>n.ID_narudzbe == odabranaNarudzba.ID_narudzbe)
                            select d;
                dgvDijelovi.DataSource = query.ToList();
                dgvDijelovi.Columns["ID_dijela"].Visible = false;
                dgvDijelovi.Columns["Sifra_dijela"].Visible = false;
                dgvDijelovi.Columns["Kupovina"].Visible = false;
                dgvDijelovi.Columns["Narudzba"].Visible = false;
                dgvDijelovi.Columns["Naziv_dijela"].HeaderText = "Naziv dijela";
                dgvDijelovi.Columns["Opis_dijela"].HeaderText = "Opis";

            }
        }

        private void DohvatiNapredak()
        {
            using (var context = new EntitetiBaze())
            {
                context.Narudzba.Attach(odabranaNarudzba);
                var query = from n in context.Napredak
                            where n.ID_narudzbe == odabranaNarudzba.ID_narudzbe
                            select n;
                var podaci = query.ToList();
                foreach (var pod in podaci)
                {
                    textBoxNapredak.Text += pod.Opis.ToString() + "\r\n";
                }
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
            using (var context = new EntitetiBaze())
            {
                context.Narudzba.Attach(odabranaNarudzba);
                odabranaNarudzba.Otkazano = 1;
                context.SaveChanges();
            }
            radioButtonOtkazano.Checked = true;
            buttonOtkazi.Enabled = false;
        }

        private void buttonZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
