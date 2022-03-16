# Inicijalne upute za prijavu projekta iz Programskog inženjerstva

Poštovane kolegice i kolege, 

čestitamo vam jer ste uspješno prijavili svoj projektni tim na kolegiju Programsko inženjerstvo, te je za vas automatski kreiran repozitorij koji ćete koristiti za verzioniranje vašega koda, ali i za pisanje dokumentacije.

Ovaj dokument (README.md) predstavlja **osobnu iskaznicu vašeg projekta**. Vaš prvi zadatak, ukoliko niste odabrali da želite raditi na projektu sa nastavnicima ili u sklopu WBL-a je **prijaviti vlastiti projektni prijedlog** na način da ćete prijavu vašeg projekta, sukladno uputama danim u ovom tekstu, napisati upravo u ovaj dokument, umjesto ovoga teksta.

Za upute o sintaksi koju možete koristiti u ovom dokumentu i kod pisanje vaše projektne dokumentacije pogledajte [ovaj link](https://guides.github.com/features/mastering-markdown/).
Sav programski kod potrebno je verzionirati u glavnoj **master** grani i **obvezno** smjestiti u mapu Software. Sve artefakte (npr. slike) koje ćete koristiti u vašoj dokumentaciju obvezno verzionirati u posebnoj grani koja je već kreirana i koja se naziva **master-docs** i smjestiti u mapu Documentation.

Nakon vaše prijave bit će vam dodijeljen mentor s kojim ćete tijekom semestra raditi na ovom projektu. A sada, vrijeme je da prijavite vaš projekt. Za prijavu vašeg projektnog prijedloga molimo vas koristite **predložak** koji je naveden u nastavku, a započnite tako da kliknete na *olovku* u desnom gornjem kutu ovoga dokumenta :) 

# Naziv projekta
Aplikacija za kontrolu servisa za automobile.

## Projektni tim

Ime i prezime | E-mail adresa (FOI) | JMBAG | Github korisničko ime
------------  | ------------------- | ----- | ---------------------
Patrik Lovrek | plovrek@foi.hr | 0016142513 | PakoLoki
Ivan Kučan | ikucan@foi.hr | 0016142529 | ivankucan
Oton Lulić | olulic@foi.hr | 0016142630 | olulic

## Opis domene
Tema bi pokrila problem čekanja i problem nedostatka informacija o specifičnim dijelovima potrebnih za servisiranje automobila. Klijent kad doveze auto na servis nema pristup informacijama koliko će dugo morati čekati da servis završi i koliko će koštati nadoplata iskorištenih materijala u servisu. Aplikacija bi omogućila obrtu za servisiranje da može postaviti uvjete kako se servis odvija, postaviti korisniku detalje o utrošenom materijalu te mu javiti kada mu servis završi da dođe po vozilo. 

## Specifikacija projekta
Aplikacija bi sadržavala korisničku i obrtsku instancu. Preko korisničke instance, klijenti naručuju servis te primaju obavijesti o tome kako se servis odvija. Obrtska instanca može prihvatiti upit za servisiranjem te obavještavati korisnika o tijeku servisa i detaljima te također može naručiti potrebne dijelove koji su bili utrošeni prilikom servisa.

//Umjesto ovih uputa opišite zahtjeve za funkcionalnošću programskog proizvoda. Pobrojite osnovne funkcionalnosti i za svaku naznačite ime odgovornog člana tima. Opišite buduću arhitekturu programskog proizvoda. Obratite pozornost da bi arhitektura trebala biti višeslojna s odvojenom (dislociranom) bazom podatka. Također uzmite u obzir da bi svaki član tima treba biti odgovorana za otprilike 3 funkcionalnosti, te da bi opterećenje članova tima trebalo biti ujednačeno. Priložite odgovarajuće dijagrame i skice gdje je to prikladno. Funkcionalnosti sustava bobrojite u tablici ispod koristeći predložak koji slijedi: 

Oznaka | Naziv | Kratki opis | Odgovorni član tima
------ | ----- | ----------- | -------------------
F01 | Login | Korisnicima aplikacije potrebno se ulogirati u sustav radi autentifikacije | Patrik Lovrek
F02 | Baza podataka | Izrada baze podataka u koju će se spremati podaci (Npr. logirani korisnici, materijali itd.) | Patrik Lovrek
F03 | Primitak narudžbe servisa | Klijent može naručiti servis koji mu odgovorni djelatnik zatim prihvaća | Patrik Lovrek
F04 | Izvještaj o detaljima i napretku servisa | Izvještaj koji informira klijenta kako mu servis napreduje i ako mu je vozilo gotovo | Ivan Kučan
F05 | Dodavanje auto dijelova | Dodavanje potrebnih auto dijelova za servis radi evidencije da klijent i zaposlenici mogu vidjeti što se utrošilo | Ivan Kučan
F06 | Kupovina auto dijelova | Stavka za naručivanje dijelova koji su bili utrošeni u servisu | Ivan Kučan
F07 | Određivanje uloge zaposlenicima | Prilikom prijave, zaposlenik može odabrati koju ulogu će on imati (Mehaničar, limar, recepcionist itd.) | Oton Lulić
F08 | Lista čekanja | Dodavanje liste čekanja gdje korisnik može vidjeti koliko je vozila trenutno na servisu i kad bi njegovo vozilo moglo doći na red | Oton Lulić
F09 | Izdavanje računa | Izrada računa sa svim specifikacijama o izvršenom servisu | Oton Lulić

## Tehnologije i oprema
Koristili bismo MySQL Workbench, alat za izradu baze podataka te MySQL server preko koje bi se u Visual Studiu mogli spojiti na bazu podataka workbencha. Također koristili bi, već navedeni Visual Studio 2022 za razvoj programskog koda.

//Umjesto ovih uputa jasno popišite sve tehnologije, alate i opremu koju ćete koristiti pri implementaciji vašeg rješenja. Ne zaboravite planirati korištenje tehnologija u aktivnostima kao što su projektni menadžment ili priprema dokumentacije. Tehnologije koje ćete koristiti bi trebale biti javno dostupne, a ako ih ne budemo obrađivali na vježbama u vašoj dokumentaciji ćete morati navesti način preuzimanja, instaliranja i korištenja onih tehnologija koje su neopbodne kako bi se vaš programski proizvod preveo i pokrenuo. Pazite da svi alati koje ćete koristiti moraju imati odgovarajuću licencu.
