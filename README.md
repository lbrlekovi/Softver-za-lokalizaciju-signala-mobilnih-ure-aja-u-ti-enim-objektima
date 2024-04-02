# Softver za lokalizaciju signala mobilnih uređaja u štićenim objektima

## Podaci o studentu

Ime i prezime | E-mail adresa (FOI) | JMBAG      | Github korisničko ime
------------  | ------------------- | ---------- | ---------------------
Luka Brleković| lbrlekovi20@foi.hr  | 0016148697 | lbrlekovi


## Opis domene
Razvoj sigurnosnog sustava za štićene objekte poput zatvora i kaznionica koji pronalazi i prijavljuje zabranjeno korištenje mobilnih uređaja.

## Specifikacija projekta
- Program treba dohvaćati podatke s više uređaja za skeniranje
- Program treba u stvarnom vremenu prikazati lokaciju pojedinih mobilnih uređaja (na tlocrtu) koristeći trilateraciju
- Program treba prikazati lokacije mobilnih uređaja kroz povijest (do godinu dana)
- Program treba prema sačuvanim podatcima simulirati kretanje mobilnih uređaja po prostorima zatvora ili kaznionice
- Osim ilegalno unešenih mobilnih uređaja aplikacija mora pratiti i uređaje zaštitara zatvora ili kaznionice
- Voditelj objekta mora moći odrediti u aplikaciji koji mobilni uređaji su posjedu zaštitara, a koji su potencijalno ilegalno unešeni
- Zaštitari objekta moraju moći vidjeti samo obavjest od aplikacije u slučaju da je pronađen nedozvoljeni moblini uređaj
- Voditelj objekta mora moći pratiti kretanja svojih zaštitara pomoću njihovih mobilnih uređaja ali zaštitari se međusobno ne smiju moći pratiti
- Aplikacija obavještava voditelja objekta i dežurne zaštitare o pronalasku potencijalnog zabranjenog uređaja putem maila i SMS poruke
- Voditelj objekta mora moći dizajnirati svoj objekt unutar aplikacije po katovima te na razini pojedine sobe u kojoj se nalazi uređaj za skeniranje
- Aplikacija mora sadržavati detalje pojedinih soba objekta kao što su opisni podatci i podatci stanara sobe
- Aplikacija se uglavnom koristi prikazom tlocrta objekta kojeg je voditelj objekta ručno dizajnirao

Podatci za log in: ime - admin, lozinka - pass
