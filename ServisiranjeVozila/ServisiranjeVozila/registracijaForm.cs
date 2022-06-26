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
    public partial class registracijaForm : Form
    {
        public registracijaForm()
        {
            InitializeComponent();
        }

        private void registracijaForm_Load(object sender, EventArgs e)
        {
            IspuniComboBox();
        }

        private void IspuniComboBox()
        {
            using (EntitetiBaze context = new EntitetiBaze())
             {
                ulogaCmbBox.DataSource = context.TipKorisnika.ToList();
                ulogaCmbBox.ValueMember = "ID_tipa";
                ulogaCmbBox.DisplayMember = "Naziv_tipa";
             }
     
        }

        private void backToLoginButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void regPotvButton_Click(object sender, EventArgs e)
        {
            using (var context = new EntitetiBaze()) 
            {
                Korisnik korisnik = new Korisnik();
                korisnik.Korisnicko_ime = korimeTxtBox.Text;
                korisnik.Ime = imeTxtBox.Text;
                korisnik.Prezime = prezimeTxtBox.Text;
                korisnik.Adresa = adresaTxtBox.Text;
                korisnik.E_mail = emailTxtBox.Text;
                korisnik.Broj_telefona = telefonTxtBox.Text;
                korisnik.ID_tipa = (ulogaCmbBox.SelectedItem as TipKorisnika).ID_tipa;
                korisnik.Lozinka=lozinkaTxtBox.Text;
                context.Korisnik.Add(korisnik);
                context.SaveChanges();
            }

        }

        
    }
}
