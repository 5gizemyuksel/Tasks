
create table Kitaplar(
KitapID int primary key  IDENTITY(1,1) not null,
KitapAdi NVARCHAR(MAX) not null,
Yazar NVARCHAR(100) not null,
YayınYili int not null,
SayfaSayisi int not null,
ISBN int not null
)

create table Dergiler(
    DergiID int primary key IDENTITY(1,1) not null,
    DergiAdi NVARCHAR(MAX) not null,
    Yayinci NVARCHAR(100) not null,
    YayınTarihi date not null,
    Sayi int not null
)

create table DVDler(
    DVDID int primary key IDENTITY(1,1) not null,
    DVDAdi NVARCHAR(100) not null,
    Yönetmen NVARCHAR(100) not null,
    YayinYili int not null,
    Süre int not null
)
create table Ogrenciler(
      Id  INT primary key  IDENTITY (1, 1) NOT NULL,
    FullName    NVARCHAR (100) NOT NULL,
    MembershipStatus NVARCHAR (50)  NOT NULL,
)
