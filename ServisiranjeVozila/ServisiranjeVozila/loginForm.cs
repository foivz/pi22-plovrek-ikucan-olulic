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
    
    public partial class loginForm : Form
    {
        public bool stanjeKorisnika = false;
        TipKorisnika tipKorisnika = new TipKorisnika();

        public loginForm()
        {
            InitializeComponent();
        }

        private void otkaziButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registrirajButton_Click(object sender, EventArgs e)
        {
            registracijaForm forma = new registracijaForm();
            this.Hide();
            forma.ShowDialog();
            this.Show();
            

            /*using(var context=new EntitetiBaze())
            {
                if (!context.TipKorisnika.Any())
                {
                    MessageBox.Show("U tablici nema ništa");

                    var tipKorisnika=context.Set<TipKorisnika>();
                    tipKorisnika.Add(new TipKorisnika { ID_tipa = 1, Naziv_tipa = "Klijent", Opis_tipa = "Klijent" });
                    tipKorisnika.Add(new TipKorisnika { ID_tipa = 2, Naziv_tipa = "Zaposlenik", Opis_tipa = "Zaposlenik" });

                    context.SaveChanges();
                }
                else
                {
                    MessageBox.Show("U tablici ima nekaj");
                }
            }*/
        }

        private void potvrdiButton_Click(object sender, EventArgs e)
        {
            using (var context= new EntitetiBaze())
            {
                var zastavica = false;
                List<Korisnik> korisnici = new List<Korisnik>();

                korisnici= context.Korisnik.ToList();

                foreach(var item in korisnici)
                {
                    if (item.Korisnicko_ime == korimeTxtBox.Text && item.Lozinka == lozinkaTxtBox.Text)
                    {
                        MessageBox.Show("Podaci su ok");
                        zastavica = true;
                        if(item.ID_tipa == 1)
                        {
                            PocetnaKlijentForm pocetna = new PocetnaKlijentForm(item);
                            this.Hide();
                            pocetna.ShowDialog();
                            this.Close();
                            
                        }
                        else if(item.ID_tipa == 2)
                        {
                            pocetnaZaposlenikForm pocetna = new pocetnaZaposlenikForm(item);
                            this.Hide();
                            pocetna.ShowDialog();
                            this.Close();
                        }
                    }
                }
                if (!zastavica)
                {
                    MessageBox.Show("Podaci nisu točni");
                }
            }
        }
    }
}
