# Feedback-Windows-Application


Feedback Windows aplikacija je Desktop aplikacija namjenjena za izvršavanje na WIndows tablet uređajima.

Alikacija ima ima sljedeće funkcionalnosti:

1. Inicijalizacija aplikacije kroz config meni  (svi podaci se trebaju podudatarti sa podacima na serveru) Parametri su: naziv, ip adresa CS servera, informacija da li app očekuje zavisna pitanja, ukoliko je odgovor na prethodnu savku „da“, svakih koliko sekundi da provjerava da li ih ima

2. Nakon pokretanja, FA povuče informacije o kampanji i pitanjima za koja treba prikupiti odgovore i počne sa radom u full-screen modu.

3. U jednom momentu na FA može biti aktivna samo jedna kampanja

4. FA prikazuje prvo pitanje kampanje i ponuđene odgovore (ili box za unos odgovora)

5. Ukoliko očekuje zavisna pitanja, svakih n sekundi radi upit na CS i povlači ta pitanj
 
  Ukoliko ima zavisnih pitanja, pauzira trenutnu kampanju i počinje feedback sesiju sa zavisnim pitanjem
  
  Nakon odgovora, nastavlja sa učitanom kampanjom, od početka, počinjući novu feedback sesiju
  
6. Nakon završetka svake feedback sesije, šalje podatke na CS:
 
  Ukoliko CS nije dostupan, čuva ih lokalnoj bazi dok ne postane CS dostupan, onda ih briše iz lokalne baze
