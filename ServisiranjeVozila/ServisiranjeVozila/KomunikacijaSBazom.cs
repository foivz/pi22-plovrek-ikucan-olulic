using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServisiranjeVozila
{
    public class KomunikacijaSBazom
    {
        public List<Narudzba> DohvatiNarudzbeKorisnika(Korisnik trenutniKorisnik)
        {
            using (var context = new EntitetiBaze())
            {
                var query = from n in context.Narudzba
                            where n.Korisnicko_ime == trenutniKorisnik.Korisnicko_ime
                            orderby n.Datum_narudzbe
                            select n;
                return query.ToList();
            }

        }

        public List<Narudzba> DohvatiSveNarudzbeSortPoDatumu()
        {
            using (var context = new EntitetiBaze())
            {
                var narudzbe = from n in context.Narudzba
                               orderby n.Datum_narudzbe descending
                               select n;
                return narudzbe.ToList();
            }
        }

        public List<Kupovina> DohvatiSveKupovineSortPoDatumu()
        {
            using (var context = new EntitetiBaze())
            {
                var kupovine = from k in context.Kupovina
                               orderby k.Datum_kupovine descending
                               select k;
                return kupovine.ToList();
            }
        }

        public List<Napredak> DohvatiNapredakZaOdabranuNarudzbu(Narudzba odabranaNarudzba)
        {
            using (var context = new EntitetiBaze())
            {
                context.Narudzba.Attach(odabranaNarudzba);
                var napredak = from n in context.Napredak
                            where n.ID_narudzbe == odabranaNarudzba.ID_narudzbe
                            select n;
                return napredak.ToList();
            }
        }

        public List<Dijelovi> DohvatiDijeloveZaOdabranuNarudzbu(Narudzba odabranaNarudzba)
        {
            using (var context = new EntitetiBaze())
            {
                var dijelovi = from d in context.Dijelovi
                            where d.Narudzba.Any(n => n.ID_narudzbe == odabranaNarudzba.ID_narudzbe)
                            select d;
                return dijelovi.ToList();

            }
        }

        public void OtkaziNarudzbu(Narudzba odabranaNarudzba)
        {
            using (var context = new EntitetiBaze())
            {
                context.Narudzba.Attach(odabranaNarudzba);
                odabranaNarudzba.Otkazano = 1;
                context.SaveChanges();
            }
        }

        public void PotvrdiNarudzbu(Narudzba odabranaNarudzba)
        {
            using (var context = new EntitetiBaze())
            {
                context.Narudzba.Attach(odabranaNarudzba);
                odabranaNarudzba.Potvrđeno = 1;
                context.SaveChanges();
            }
        }

        public void ZavrsiNarudzbu(Narudzba odabranaNarudzba)
        {
            using (var context = new EntitetiBaze())
            {
                context.Narudzba.Attach(odabranaNarudzba);
                odabranaNarudzba.Zavrsena = 1;
                context.SaveChanges();
            }
        }

        public List<Dijelovi> DohvatiSveDijelove()
        {
            using (var context = new EntitetiBaze())
            {
                var querySvi = from d in context.Dijelovi
                               select d;
                return querySvi.ToList();
            }
        }


        public List<Dijelovi> DohvatiDijeloveUKupovini(Kupovina odabranaKupovina)
        {
            using (var context = new EntitetiBaze())
            {
                var queryUKupovini = from d in context.Dijelovi
                                     where d.Kupovina.Any(x => x.ID_kupovine == odabranaKupovina.ID_kupovine)
                                     select d;
                return queryUKupovini.ToList();

            }
        }

        public List<Dijelovi> DohvatiDijeloveOsimUKupovini(Kupovina odabranaKupovina)
        {
            using (var context = new EntitetiBaze())
            {
                var queryUKupovini = from d in context.Dijelovi
                                     where !d.Kupovina.Any(x => x.ID_kupovine == odabranaKupovina.ID_kupovine)
                                     select d;
                return queryUKupovini.ToList();

            }
        }

        public List<Dijelovi> DohvatiDijeloveUNarudzbi(Narudzba odabranaNarudzba)
        {
            using (var context = new EntitetiBaze())
            {
                var queryUNarudzbi = from d in context.Dijelovi
                                     where d.Narudzba.Any(n => n.ID_narudzbe == odabranaNarudzba.ID_narudzbe)
                                     select d;
                return queryUNarudzbi.ToList();
            }
        }

        public List<Dijelovi> DohvatiDijeloveOsimUNarudzbi(Narudzba odabranaNarudzba)
        {
            using (var context = new EntitetiBaze())
            {
                var queryUNarudzbi = from d in context.Dijelovi
                                     where !d.Narudzba.Any(n => n.ID_narudzbe == odabranaNarudzba.ID_narudzbe)
                                     select d;
                return queryUNarudzbi.ToList();
            }
        }

        public List<Dijelovi> FiltrirajDijelovePremaNazivuZaNarudzbu(string tekst, Narudzba odabranaNarudzba)
        {
            using (var context = new EntitetiBaze())
            {
                var dijeloviPremaNazivu = from d in context.Dijelovi
                                          where d.Naziv_dijela.Contains(tekst) && !d.Narudzba.Any(n => n.ID_narudzbe == odabranaNarudzba.ID_narudzbe)
                                          select d;
                return dijeloviPremaNazivu.ToList();
            }
        }

        public List<Dijelovi> FiltrirajDijelovePremaNazivuZaKupovinu(string tekst, Kupovina odabranaKupovina)
        {
            using (var context = new EntitetiBaze())
            {
                var dijeloviPremaNazivu = from d in context.Dijelovi
                                          where d.Naziv_dijela.Contains(tekst) && !d.Kupovina.Any(x => x.ID_kupovine == odabranaKupovina.ID_kupovine)
                                          select d;
                return dijeloviPremaNazivu.ToList();
            }
        }

        public List<Dijelovi> FiltrirajDijelovePremaSifriZaNarudzbu(string tekst, Narudzba odabranaNarudzba)
        {
            using (var context = new EntitetiBaze())
            {
                var dijeloviPremaSifri = from d in context.Dijelovi
                                         where d.Sifra_dijela.Contains(tekst) && !d.Narudzba.Any(n => n.ID_narudzbe == odabranaNarudzba.ID_narudzbe)
                                         select d;
                return dijeloviPremaSifri.ToList();
            }
        }

        public List<Dijelovi> FiltrirajDijelovePremaSifriZaKupovinu(string tekst, Kupovina odabranaKupovina)
        {
            using (var context = new EntitetiBaze())
            {
                var dijeloviPremaSifri = from d in context.Dijelovi
                                         where d.Sifra_dijela.Contains(tekst) && !d.Kupovina.Any(x => x.ID_kupovine == odabranaKupovina.ID_kupovine)
                                         select d;
                return dijeloviPremaSifri.ToList();
            }
        }

        public void DodajDioUKupovinu(Dijelovi odabraniDio, Kupovina odabranaKupovina)
        {
            using (var context = new EntitetiBaze())
            {
                context.Dijelovi.Attach(odabraniDio);
                context.Kupovina.Attach(odabranaKupovina);
                if (!odabraniDio.Kupovina.Contains(odabranaKupovina))
                {
                    odabraniDio.Kupovina = new List<Kupovina>();
                    odabraniDio.Kupovina.Add(odabranaKupovina);
                    odabranaKupovina.Ukupna_cijena += odabraniDio.Cijena;
                    context.SaveChanges();
                }
            }
        }

        public void DodajDioUNarudzbu(Dijelovi odabraniDio, Narudzba odabranaNarudzba)
        {
            using (var context = new EntitetiBaze())
            {
                context.Dijelovi.Attach(odabraniDio);
                context.Narudzba.Attach(odabranaNarudzba);
                
                if (!odabraniDio.Narudzba.Contains(odabranaNarudzba))
                {
                    odabraniDio.Narudzba = new List<Narudzba>();
                    odabraniDio.Narudzba.Add(odabranaNarudzba);
                    context.SaveChanges();
                }
            }
        }

        public void DodajNapredak(Narudzba odabranaNarudzba, Napredak napredak)
        {
            using (var context = new EntitetiBaze())
            {
                context.Narudzba.Attach(odabranaNarudzba);
                context.Napredak.Add(napredak);
                context.SaveChanges();
            }
        }

        public void KreirajKupovinu(Korisnik trenutniKorisnik)
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
        }

        public void ZavrsiKupovinu(Kupovina odabranaKupovina)
        {
            using (var context = new EntitetiBaze())
            {
                context.Kupovina.Attach(odabranaKupovina);
                odabranaKupovina.Status_kupovina = "Završena";
                context.SaveChanges();
            }
        }

        public List<Narudzba> PrikaziZavrseneNarudzbe()
        {
            using (var context = new EntitetiBaze())
            {
                var query = from n in context.Narudzba
                            where n.Zavrsena == 1
                            orderby n.Datum_narudzbe
                            select n;
                return query.ToList();
            }
        }

        public List<Narudzba> PrikaziOtkazaneNarudzbe()
        {
            using (var context = new EntitetiBaze())
            {
                var query = from n in context.Narudzba
                            where n.Otkazano == 1
                            orderby n.Datum_narudzbe
                            select n;
                return query.ToList();
            }
        }

        public List<Narudzba> PrikaziPotvrdeneNarudzbe()
        {
            using (var context = new EntitetiBaze())
            {
                var query = from n in context.Narudzba
                            where n.Potvrđeno == 1
                            orderby n.Datum_narudzbe
                            select n;
                return query.ToList();
            }
        }

        public List<Narudzba> PrikaziNepotvrdeneNarudzbe()
        {
            using (var context = new EntitetiBaze())
            {
                var query = from n in context.Narudzba
                            where n.Potvrđeno == 0
                            orderby n.Datum_narudzbe
                            select n;
                return query.ToList();
            }
        }

        public void DodajNarudzbu(Narudzba narudzba)
        {
            using (var context = new EntitetiBaze())
            {
                context.Narudzba.Add(narudzba);
                context.SaveChanges();
            }
        }
    }
}
