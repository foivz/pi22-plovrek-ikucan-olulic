using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using Baza;
using System.Net;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ServisiranjeVozila
{
    public partial class posaljiEmailForm : Form
    {
        Narudzba odabranaNarudzba;
        KomunikacijaSBazom baza = new KomunikacijaSBazom();
        public posaljiEmailForm(Narudzba narudzba)
        {
            odabranaNarudzba = narudzba;
            InitializeComponent();
        }
        public void PosaljiEmail()
        {
            MailAddress to = new MailAddress("oton.lulic@gmail.com");
            MailAddress from = new MailAddress("LKLTech@foi.hr");
            MailMessage mailMessage = new MailMessage(from, to);
            mailMessage.Subject = "Vaš automobil na servisu";
            mailMessage.Body = $"Vaš automobil biti će na servisu za {brojSatiTextBox.Text} sati. \n\n LKL Tech";
            mailMessage.BodyEncoding = System.Text.Encoding.UTF8;
            SmtpClient client = new SmtpClient("mail.foi.hr", 587);
            //client.Host = "smtp.gmail.com";
            //client.Port = 587;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("olulic@foi.hr", "MojFoi2000");
            try
            {
                client.Send(mailMessage);
                MessageBox.Show("E-mail uspješno poslan!");
            }
            catch (Exception)
            {
                MessageBox.Show("Greška kod slanja emaila");
            }
            mailMessage.Dispose();
        }
        private void DohvatiKorisnika()
        {
            var podaci = baza.PregledKorisnika(odabranaNarudzba).ToArray();
            korisnikTextBox.DataBindings.Add("Text", podaci, "Korisnicko_ime");
            korisnikTextBox.Enabled = false;
            emailTextBox.DataBindings.Add("Text", podaci, "E_mail");
            emailTextBox.Enabled = false;
        }
        private void posaljiButton_Click(object sender, EventArgs e)
        {
            this.PosaljiEmail();
            this.Close();
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void posaljiEmailForm_Load(object sender, EventArgs e)
        {
            DohvatiKorisnika();
        }
    }
}