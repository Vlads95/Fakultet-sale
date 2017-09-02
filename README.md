# Septembar-2015
Fakultet 


Prvi dio – Kreirati biblioteku klasa i u njoj klase:
 Osoba – polje ime u formi (ime,ime roditelja,prezime) i datum rođenja
 Kandidat – nasljeđuje osobu,sadrži broj prijave i broj mobilnog
 Lokacija – polje fakultet (enumeracija sa elementima FON,FPN,SF,VSER) i broj raspoloživih sala
 Sala – broj,kapacitet,lokacija (tipa Lokacija),odgovorno lice (tipa Osoba) i spisak kandidata
U svakoj od klasa potrebno je obezbjediti i metodu za prikaz (Prikaži) koja vraca sledeće:
 u klasi Osoba – formatiran string sa svim podacima o osobi
 u klasi Lokacija – formatiran string sa svim podacima o lokaciji
 u klasi Kandidat – formatiran string kao broj prijave,osoba i broj mobilnog telefona
 u klasi Sala – formatiran string kao lokacija,broj,odgovorno lice i broj popunjenih mjesta
Kreirati konzolnu aplikaciju i u njoj klasu:
 Raspored polaganja – godina,spisak sala i spisak neraspoređenih kandidata,oba spiska će na početku biti prazna i ova klasa sadrži Main metodu
______________________________________________________________________________
Drugi dio – Za potrebe učitavanja potrebno je obezbjediti sledeće:
 U klasi Sala implementirati metodu UcitajSalu kojom se sa tastature učitava i vraća sala.Metoda kao parametre prima prethodno kreiranu lokaciju i spisak neraspoređenih kandidata.
 Brojevi sala mogu se kretati od 1 do broja raspoloživih sala za datu lokaciju.Potrebno je obezbjediti da se učitaju i dodaju kandidati koji će polagati prijemni ispit u datoj sali.Broj kandidata koji će polagati prijemni u datoj sali ne može biti veći od kapaciteta date sale.
 Obraditi grešku koja bi nastala ukoliko se,prilikom unosa sale sa tastature,unese tekst umjesto broja,na taj način će se vraćati na unos dok se zaista ne unese broj.Unos pokušati 10 puta pa odustati.
 Ukoliko na kraju unosa kapacitet sale nije popunjen,potrebno je popuniti salu kandidatima iz spiska neraspoređenih kandidata,a zatim izbaciti raspoređene kandidate iz spiska neraspoređenih kandidata.
 Ukoliko ime roditelja i prezime kandidata odgovaraju imenu i prezimenu lica koje je odgovorno za tu salu,kandidata nije moguće rasporediti u datu salu.
 Ako kandidata nije bilo moguće rasporediti u datu salu usljed potencijalnog konfilkta interesa,potrebno ga je dodati u spisak neraspoređenih kandidata,ukoliko se on već ne nalazi na tom spisku.Za realizaciju ovog zahtjeva koristiti događaj.
______________________________________________________________________________
Treći dio – U Main metodi je potrebno realizovati sledeće:
 Učitati i kreirati Raspored Polaganja
 Učitati lokacije: FON, 20 i SF, 15
 Učitati po dvije sale za svaku od lokacija pozivanjem metode UcitajSalu i dodati ih u spisak sala
 Prikazati raspored polaganja po lokacijama,sa ukupnim brojem kandidata i samo sa salama koje imaju više od deset kandidata.
______________________________________________________________________________
Četvrti dio - Obezbjediti mogućnost (preko odgovarajućih metoda) pretraživanja kandidata po sledećim kriterijumima:
 Sve sale čiji kapacitet nije popunjen.
 Svi kandidati koji polažu prijemni ispit na određenom fakultetu.
 Sala sa najvećim kapacitetom.
 Procenat kandidata koji će polagati prijemni ispit na SF-u.
 Sve sale za koje je odgovorno lice čije prezime sadrži određeno slovo.
 Procenat popunjenosti sala na SF-u.Obraditi grešku koja bi nastala prilikom računanja procenta popunjenosti sala ukoliko nijedan od kandidata nije unešen na datu lokaciju,na taj način što će se ispisati poruka o tome da nije moguće izračunati zahtjevano.
