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
    public partial class dodajDijeloveUNarudzbuKolicinaForm : Form
    {
        Narudzba odabranaNarudzba;
        Dijelovi odabraniDio;
        KomunikacijaSBazom baza = new KomunikacijaSBazom();
        public dodajDijeloveUNarudzbuKolicinaForm(Narudzba narudzba, Dijelovi dio)
        {
            odabranaNarudzba = narudzba;
            odabraniDio = dio;
            InitializeComponent();
        }
        public dodajDijeloveUNarudzbuKolicinaForm()
        {
            InitializeComponent();
        }

        private void buttonZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPotvrdi_Click(object sender, EventArgs e)
        {
            var rezultat = baza.DodajDioUNarudzbu(odabraniDio, odabranaNarudzba, int.Parse(textBoxKolicina.Text));
            if (rezultat == 1)
            {
                MessageBox.Show("Količina koju ste unijeli veća je od količine na skladištu!");
            }
            else if (rezultat == 2)
            {
                MessageBox.Show("Količina ne može biti negativna!");
            }
            this.Close();
        }
    }
}
