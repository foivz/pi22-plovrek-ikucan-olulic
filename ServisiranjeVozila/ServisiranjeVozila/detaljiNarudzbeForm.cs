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
    public partial class detaljiNarudzbeForm : Form
    {
        private Narudzba odabranaNarudzba;
        public detaljiNarudzbeForm(Narudzba narudzba)
        {
            odabranaNarudzba = narudzba;
            InitializeComponent();
        }
        public detaljiNarudzbeForm()
        {
            InitializeComponent();
        }

        private void detaljiNarudzbeForm_Load(object sender, EventArgs e)
        {
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
