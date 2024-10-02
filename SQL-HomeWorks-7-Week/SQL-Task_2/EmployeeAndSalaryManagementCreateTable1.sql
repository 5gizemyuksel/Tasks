create table Personel(
    PersonelID int PRIMARY KEY IDENTITY(1,1) not null,
    Ad NVARCHAR(50) not null,
    Soyad NVARCHAR(50) not null,
    Pozisyon NVARCHAR(100) not null,
    BaslangicTarihi DATE not null
)


create table Maaslar(
    MaasID int primary key IDENTITY(1,1) not null,
    PersonelID int not null,
    MaasMiktari int not null,
    GuncellemeTarihi DATETIME not null
)