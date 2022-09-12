using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baza
{
    public class KomunikacijaSBazom
    {
        public List<Vozilo> DohvatiVozilaKorisnika(Korisnik trenutniKorisnik)
        {
            using (var context = new PI2238_DBEntities())
            {
                var query = from v in context.Vozilo
                            where v.Vlasnistvo.Any(x => x.Registracija_vozila == v.Registracija_vozila)
                            && context.Vlasnistvo.Any(x => x.Korisnicko_ime == trenutniKorisnik.Korisnicko_ime)
                            select v;
                return query.ToList();
            }
        }

        //Vraća listu svih narudžbi u kojima je korisničko ime u narudžbi jednako korisničkom
        //imenu korisnika koji trenutno koristi aplikaciju
        public List<Narudzba> DohvatiNarudzbeKorisnika(Korisnik trenutniKorisnik)
        {
            using (var context = new PI2238_DBEntities())
            {
                var query = from n in context.Narudzba
                            where n.Korisnicko_ime == trenutniKorisnik.Korisnicko_ime
                            orderby n.Datum_narudzbe
                            select n;
                return query.ToList();
            }

        }

        

        //Vraća listu svih narudžbi sortirane prema datumu od sada prema prošlosti
        public List<Narudzba> DohvatiSveNarudzbeSortPoDatumu()
        {
            using (var context = new PI2238_DBEntities())
            {
                var narudzbe = from n in context.Narudzba
                               orderby n.Datum_narudzbe descending
                               select n;
                return narudzbe.ToList();
            }
        }

        //Vraća listu svih kupovina sortiranih prema datumu od sada prema prošlosti
        public List<Kupovina> DohvatiSveKupovineSortPoDatumu()
        {
            using (var context = new PI2238_DBEntities())
            {
                var kupovine = from k in context.Kupovina
                               orderby k.Datum_kupovine descending
                               select k;
                return kupovine.ToList();
            }
        }

        
        public object DohvatiNapredakZaOdabranuNarudzbu(Narudzba odabranaNarudzba)
        {
            using (var context = new PI2238_DBEntities())
            {
                context.Narudzba.Attach(odabranaNarudzba);
                var napredak = from tn in context.Tip_napretka
                               join nap in context.Napredak on tn.ID_tipa_napretka equals nap.ID_tipa_napretka
                               where nap.ID_narudzbe == odabranaNarudzba.ID_narudzbe
                               select new
                               {
                                   tn.Opis,
                                   nap.Datum_vrijeme
                               };
                               
                return napredak.ToList();
            }
        }

        //Vraća listu svih dijelova koji su pridruženi odabranoj narudžbi
        public List<Dijelovi> DohvatiDijeloveZaOdabranuNarudzbu(Narudzba odabranaNarudzba)
        {
            using (var context = new PI2238_DBEntities())
            {
                var dijelovi = from d in context.Dijelovi
                               where d.Sadrzi_dio.Any(n => n.ID_narudzbe == odabranaNarudzba.ID_narudzbe)
                               select d;
                return dijelovi.ToList();

            }
        }

        //U bazu podataka zapisuje da narudžba otkazana
        public void OtkaziNarudzbu(Narudzba odabranaNarudzba)
        {
            using (var context = new PI2238_DBEntities())
            {
                context.Narudzba.Attach(odabranaNarudzba);
                odabranaNarudzba.Otkazano = 1;
                context.SaveChanges();
            }
        }

        //U bazu podataka zapisuje da je narudžba potvrđena
        public void PotvrdiNarudzbu(Narudzba odabranaNarudzba, Korisnik zaposlenik)
        {
            using (var context = new PI2238_DBEntities())
            {
                context.Narudzba.Attach(odabranaNarudzba);
                odabranaNarudzba.Potvrđeno = 1;
                odabranaNarudzba.Zaposlenik = zaposlenik.Korisnicko_ime;
                context.SaveChanges();
            }
        }

        //U bazu podataka zapisuje da je narudžba završena
        public void ZavrsiNarudzbu(Narudzba odabranaNarudzba)
        {
            using (var context = new PI2238_DBEntities())
            {
                context.Narudzba.Attach(odabranaNarudzba);
                odabranaNarudzba.Zavrsena = 1;

                Korisnik zaposlenik = context.Korisnik.Find(odabranaNarudzba.Zaposlenik);
                context.Korisnik.Attach(zaposlenik);

                var query = from n in context.Napredak
                            where n.ID_tipa_napretka == 2 && n.ID_narudzbe == odabranaNarudzba.ID_narudzbe
                            select n;
                DateTime vrijemePocetka = query.ToList()[0].Datum_vrijeme;
                DateTime vrijemeKraja = DateTime.Now;

                int brojSatiRada = vrijemeKraja.Subtract(vrijemePocetka).Hours;
                double? cijenaRada = zaposlenik.Cijena * brojSatiRada;

                odabranaNarudzba.Ukupna_cijena += cijenaRada;
                context.SaveChanges();
            }
        }

        //Vraća listu svih dijelova iz baze podataka
        public List<Dijelovi> DohvatiSveDijelove()
        {
            using (var context = new PI2238_DBEntities())
            {
                var querySvi = from d in context.Dijelovi
                               select d;
                return querySvi.ToList();
            }
        }

        //Vraća listu svih dijelova koji su pridruženi odabranoj kupovini
        public object DohvatiDijeloveUKupovini(Kupovina odabranaKupovina)
        {
            using (var context = new PI2238_DBEntities())
            {
                var queryUKupovini = from d in context.Dijelovi
                                     join dk in context.Dio_u_kupovini on d.ID_dijela equals dk.ID_dijela
                                     where dk.ID_kupovine == odabranaKupovina.ID_kupovine
                                     select new
                                     {
                                         d.Naziv_dijela,
                                         d.Sifra_dijela,
                                         d.Cijena,
                                         dk.Kolicina,
                                         d.ID_dijela
                                     };
                return queryUKupovini.ToList();

            }
        }

        //Vraća listu svih dijelova koji nisu pridruženi odabranoj kupovini
        public List<Dijelovi> DohvatiDijeloveOsimUKupovini(Kupovina odabranaKupovina)
        {
            using (var context = new PI2238_DBEntities())
            {
                var queryUKupovini = from d in context.Dijelovi
                                     where !d.Dio_u_kupovini.Any(x => x.ID_kupovine == odabranaKupovina.ID_kupovine)
                                     select d;
                return queryUKupovini.ToList();

            }
        }

        //Vraća listu svih dijelova koji su pridruženi odabranoj narudžbi
        public object DohvatiDijeloveUNarudzbi(Narudzba odabranaNarudzba)
        {
            using (var context = new PI2238_DBEntities())
            {
                var queryUNarudzbi = from d in context.Dijelovi
                                     join sd in context.Sadrzi_dio on d.ID_dijela equals sd.ID_dijela
                                     where sd.ID_narudzbe == odabranaNarudzba.ID_narudzbe
                                     select new
                                     {
                                         d.Naziv_dijela,
                                         d.Sifra_dijela,
                                         d.Cijena,
                                         sd.Kolicina,
                                         d.ID_dijela
                                     };
                return queryUNarudzbi.ToList();
            }
        }

        //Vraća listu svih dijelova koji nisu pridruženi odabranoj narudžbi
        public List<Dijelovi> DohvatiDijeloveOsimUNarudzbi(Narudzba odabranaNarudzba)
        {
            using (var context = new PI2238_DBEntities())
            {
                var queryUNarudzbi = from d in context.Dijelovi
                                     where !d.Sadrzi_dio.Any(x => x.ID_narudzbe == odabranaNarudzba.ID_narudzbe)
                                     select d;
                return queryUNarudzbi.ToList();
            }
        }

        //Vraća listu dijelova koji u nazivu sadrže upisan tekst, a nisu već pridruženi narudžbi
        public List<Dijelovi> FiltrirajDijelovePremaNazivuZaNarudzbu(string tekst, Narudzba odabranaNarudzba)
        {
            using (var context = new PI2238_DBEntities())
            {
                var dijeloviPremaNazivu = from d in context.Dijelovi
                                          where d.Naziv_dijela.Contains(tekst) && !d.Sadrzi_dio.Any(x => x.ID_narudzbe == odabranaNarudzba.ID_narudzbe)
                                          select d;
                return dijeloviPremaNazivu.ToList();
            }
        }

        //Vraća listu dijelova koji u nazivu sadrže upisan tekst, a nisu već pridruženi kupovini
        public List<Dijelovi> FiltrirajDijelovePremaNazivuZaKupovinu(string tekst, Kupovina odabranaKupovina)
        {
            using (var context = new PI2238_DBEntities())
            {
                var dijeloviPremaNazivu = from d in context.Dijelovi
                                          where d.Naziv_dijela.Contains(tekst) && !d.Dio_u_kupovini.Any(x => x.ID_kupovine == odabranaKupovina.ID_kupovine)
                                          select d;
                return dijeloviPremaNazivu.ToList();
            }
        }

        //Vraća listu dijelova koji u šifri sadrže upisan tekst, a nisu već pridruženi narudžbi
        public List<Dijelovi> FiltrirajDijelovePremaSifriZaNarudzbu(string tekst, Narudzba odabranaNarudzba)
        {
            using (var context = new PI2238_DBEntities())
            {
                var dijeloviPremaSifri = from d in context.Dijelovi
                                         where d.Sifra_dijela.Contains(tekst) && !d.Sadrzi_dio.Any(x => x.ID_narudzbe == odabranaNarudzba.ID_narudzbe)
                                         select d;
                return dijeloviPremaSifri.ToList();
            }
        }

        //Vraća listu dijelova koji u šifri sadrže upisan tekst, a nisu već pridruženi kupovini
        public List<Dijelovi> FiltrirajDijelovePremaSifriZaKupovinu(string tekst, Kupovina odabranaKupovina)
        {
            using (var context = new PI2238_DBEntities())
            {
                var dijeloviPremaSifri = from d in context.Dijelovi
                                         where d.Sifra_dijela.Contains(tekst) && !d.Dio_u_kupovini.Any(x => x.ID_kupovine == odabranaKupovina.ID_kupovine)
                                         select d;
                return dijeloviPremaSifri.ToList();
            }
        }

        //Odabranoj kupovini pridružuje odabrani dio
        
        public int DodajDioUKupovinu(Dijelovi odabraniDio, Kupovina odabranaKupovina, int kolicina)
        {
            using (var context = new PI2238_DBEntities())
            {
                if (kolicina < 0) return 1;
                context.Dijelovi.Attach(odabraniDio);
                context.Kupovina.Attach(odabranaKupovina);
                Dio_u_kupovini dodaj = new Dio_u_kupovini
                {
                    ID_kupovine = odabranaKupovina.ID_kupovine,
                    ID_dijela = odabraniDio.ID_dijela,
                    Kolicina = kolicina
                };
                context.Dio_u_kupovini.Add(dodaj);
                odabranaKupovina.Ukupna_cijena += (odabraniDio.Cijena * kolicina);
                context.SaveChanges();
                return 0;
            }
        }
        

        //Odabranoj narudžbi pridružuje odabrani dio
        
        public int DodajDioUNarudzbu(Dijelovi odabraniDio, Narudzba odabranaNarudzba, int kolicina)
        {
            using (var context = new PI2238_DBEntities())
            {
                if (odabraniDio.Kolicina < kolicina) return 1;
                if (kolicina < 0) return 2;
                context.Dijelovi.Attach(odabraniDio);
                context.Narudzba.Attach(odabranaNarudzba);
                Sadrzi_dio dodaj = new Sadrzi_dio
                {
                    ID_narudzbe = odabranaNarudzba.ID_narudzbe,
                    ID_dijela = odabraniDio.ID_dijela,
                    Kolicina = kolicina
                };
                context.Sadrzi_dio.Add(dodaj);
                odabranaNarudzba.Ukupna_cijena += (odabraniDio.Cijena * kolicina);
                context.SaveChanges();
                return 0;
            }
        }

        public void PovecajKolicinuZaJedan(Narudzba odabranaNarudzba, string idDijela)
        {
            using (var context = new PI2238_DBEntities())
            {
                Sadrzi_dio zapis = context.Sadrzi_dio.Find(odabranaNarudzba.ID_narudzbe, int.Parse(idDijela));
                context.Sadrzi_dio.Attach(zapis);
                zapis.Kolicina += 1;

                Dijelovi dio = context.Dijelovi.Find(int.Parse(idDijela));
                context.Dijelovi.Attach(dio);
                dio.Kolicina -= 1;

                context.Narudzba.Attach(odabranaNarudzba);
                odabranaNarudzba.Ukupna_cijena += dio.Cijena;

                context.SaveChanges();
            }
        }

        public List<Tip_napretka> DohvatiTipoveNapretka(Narudzba odabranaNarudzba)
        {
            using (var context = new PI2238_DBEntities())
            {
                var tipoviNapretka = from tn in context.Tip_napretka
                                     where !tn.Napredak.Any(x => x.ID_narudzbe == odabranaNarudzba.ID_narudzbe)
                                     select tn;
                return tipoviNapretka.ToList();
            }

        }

        public int SmanjiKolicinuZaJedan(Narudzba odabranaNarudzba, string idDijela)
        {
            using (var context = new PI2238_DBEntities())
            {
                Sadrzi_dio zapis = context.Sadrzi_dio.Find(odabranaNarudzba.ID_narudzbe, int.Parse(idDijela));
                context.Sadrzi_dio.Attach(zapis);
                if(zapis.Kolicina > 0)
                {
                    zapis.Kolicina -= 1;

                    Dijelovi dio = context.Dijelovi.Find(int.Parse(idDijela));
                    context.Dijelovi.Attach(dio);
                    dio.Kolicina += 1;

                    context.Narudzba.Attach(odabranaNarudzba);
                    odabranaNarudzba.Ukupna_cijena -= dio.Cijena;

                    context.SaveChanges();
                }
                else
                {
                    return 1;
                }
                return 0;
                
                
            }
        }


        //Dodaje novi zapis u tablicu "Napredak"
        public void DodajNapredak(Napredak addNapredak)
        {
            using (var context = new PI2238_DBEntities())
            {
                context.Napredak.Add(addNapredak);
                context.SaveChanges();
            }
        }

        //Dodaje novi zapis u tablicu "Kupovina" s podacima:
        //korisničko ime trenutnog korisnika, ukupna cijena je na početku 0,
        //datum kreiranja kupovine je sada, a status kupovine "U tijeku"
        
        public void KreirajKupovinu(Korisnik trenutniKorisnik)
        {
            using (var context = new PI2238_DBEntities())
            {
                Kupovina kupovina = new Kupovina
                {
                    Zaposlenik_korime = trenutniKorisnik.Korisnicko_ime,
                    Ukupna_cijena = 0,
                    Datum_kupovine = DateTime.Now,
                    Status_kupovine = "U tijeku"
                };
                context.Kupovina.Add(kupovina);
                context.SaveChanges();
            }
        }
        
        //Postavlja odabranu kupovinu kao završenu
        public void ZavrsiKupovinu(Kupovina odabranaKupovina)
        {
            using (var context = new PI2238_DBEntities())
            {
                context.Kupovina.Attach(odabranaKupovina);
                odabranaKupovina.Status_kupovine = "Završena";

                var dijeloviUKUpovini = (from dk in context.Dio_u_kupovini
                                        where dk.ID_kupovine == odabranaKupovina.ID_kupovine
                                        select dk).ToList();
                foreach(var item in dijeloviUKUpovini)
                {
                    var dio = context.Dijelovi.Find(item.ID_dijela);
                    context.Dijelovi.Attach(dio);
                    dio.Kolicina += item.Kolicina;
                }
                context.SaveChanges();
            }
        }

        //Vraća listu narudžbi koje su postavljene kao završene
        public List<Narudzba> PrikaziZavrseneNarudzbe()
        {
            using (var context = new PI2238_DBEntities())
            {
                var query = from n in context.Narudzba
                            where n.Zavrsena == 1
                            orderby n.Datum_narudzbe
                            select n;
                return query.ToList();
            }
        }

        //Vraća listu narudžbi koje su postavljene kao otkazane
        public List<Narudzba> PrikaziOtkazaneNarudzbe()
        {
            using (var context = new PI2238_DBEntities())
            {
                var query = from n in context.Narudzba
                            where n.Otkazano == 1
                            orderby n.Datum_narudzbe
                            select n;
                return query.ToList();
            }
        }

        //Vraća listu narudžbi koje su postavljene kao potvrđene
        public List<Narudzba> PrikaziPotvrdeneNarudzbe()
        {
            using (var context = new PI2238_DBEntities())
            {
                var query = from n in context.Narudzba
                            where n.Potvrđeno == 1
                            orderby n.Datum_narudzbe
                            select n;
                return query.ToList();
            }
        }

        //Vraća listu narudžbi koje nisu potvrđene
        public List<Narudzba> PrikaziNepotvrdeneNarudzbe()
        {
            using (var context = new PI2238_DBEntities())
            {
                var query = from n in context.Narudzba
                            where n.Potvrđeno == 0
                            orderby n.Datum_narudzbe
                            select n;
                return query.ToList();
            }
        }

        public List<Narudzba> PrikaziNarudzbeUTijeku()
        {
            using (var context = new PI2238_DBEntities())
            {
                var query = from n in context.Narudzba
                            where n.Potvrđeno == 1 && n.Otkazano == 0 && n.Zavrsena == 0
                            orderby n.Datum_narudzbe
                            select n;
                return query.ToList();
            }
        }

        //Dodaje novi zapis u tablicu "Narudzba" s podacima koje je korisnik unio
        public void DodajNarudzbu(Narudzba narudzba)
        {
            using (var context = new PI2238_DBEntities())
            {
                context.Narudzba.Add(narudzba);
                context.SaveChanges();
            }
        }
        public object PregledOdradenihRadovaNaVozilu(Narudzba odabranaNarudzba)
        {
            using (var context = new PI2238_DBEntities())
            {
                context.Narudzba.Attach(odabranaNarudzba);
                var query = from n in context.Napredak.Include("Tip_napretka")
                            //join nap in context.Napredak on n.ID_tipa_napretka equals nap.ID_tipa_napretka
                            where n.Narudzba.ID_narudzbe == odabranaNarudzba.ID_narudzbe
                            select new
                            {
                                n.ID_tipa_napretka,
                                n.ID_narudzbe,
                                n.Datum_vrijeme,
                                n.Tip_napretka.Opis,
                                n.Narudzba
                            };
                return query.ToList();
            }
        }
    }
}