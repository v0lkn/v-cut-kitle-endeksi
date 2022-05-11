CREATE DATABASE BiletSatisi

CREATE TABLE KullaniciGiris(
KullaniciTc int primary key identity,
KullaniciIsim varchar(50),
KullaniciSoyad varchar(50),
KullaniciTel varchar(11),
KullaniciCinsiyet bit,
KullaniciPosta varchar(50),
KullaniciAd varchar(50),
KullaniciSifre varchar(50),
)
CREATE TABLE BiletAl(
MusteriTC int primary key identity,
MusteriAd varchar(50),
MusteriSoyad varchar(50),
MusteriTel varchar(11),
MusteriEposta varchar(50),
Cinsiyet bit,
Koltuk varchar(50)
)
CREATE TABLE Sube(
SubeKodu int primary key identity,
SubeAdi varchar(50),
SubeAdresi varchar(50)
)
CREATE TABLE Filo(
AracKodu int primary key identity,
AracMarka varchar(50),
AracModel varchar(50),
AracKilometre varchar(50),
)






delete from Sube where SubeAdi = 'olmazsa' and SubeAdresi = 'kendimi patlatcam'

