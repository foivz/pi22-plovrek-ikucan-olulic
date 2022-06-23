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
    public partial class dodajNapredakForm : Form
    {
        private Narudzba odabranaNarudzba;
        public dodajNapredakForm(Narudzba narudzba)
        {
            odabranaNarudzba = narudzba;
            InitializeComponent();
        }
        public dodajNapredakForm()
        {
            InitializeComponent();
        }

        private void dodajNapredakForm_Load(object sender, EventArgs e)
        {
            textBoxIDNarudzbe.Text = odabranaNarudzba.ID_narudzbe.ToString();
            textBoxKorime.Text = odabranaNarudzba.Korisnicko_ime.ToString();
            textBoxRegistracija.Text = odabranaNarudzba.Registracija_vozila.ToString();
            textBoxMarka.Text = odabranaNarudzba.Marka_vozila.ToString();
            textBoxModel.Text = odabranaNarudzba.Model_vozila.ToString();
            textBoxStanje.Text = odabranaNarudzba.Stanje_brojaca.ToString();
        }

        private void buttonZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDodajNapredak_Click(object sender, EventArgs e)
        {
            string opis = textBoxNapredak.Text;
            int id = odabranaNarudzba.ID_narudzbe;
            Napredak napredak = new Napredak
            {
                Opis = opis,
                ID_narudzbe = id
            };
            using (var context = new EntitetiBaze())
            {
                context.Narudzba.Attach(odabranaNarudzba); 
                context.Napredak.Add(napredak);
                context.SaveChanges();
            }
            MessageBox.Show("Napredak je uspješno dodan!");
        }
    }
}
