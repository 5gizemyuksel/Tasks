insert into Personel(Ad,Soyad,Pozisyon,BaslangicTarihi)
VALUES('Ahmet','Çakır','Müdür','2002-4-14'),
       ('Bekir','Dişbudak','Müdür Yardımcısı','2010-6-23'),
       ('Hülya','Akdoğan','İngilizce Öğretmeni','2015-3-25'),
       ('Gizem','Yüksel', 'Matematik Öğretmeni', '2020-9-16'),
       ('Mahmut','Durak','Fizik Öğretmeni', '2017-9-16'),
       ('Sevda','Yurt','Sekreter','2022-4-30'),
       ('Cihan','Toprak','Coğrafya Öğretmeni','2010-6-14'),
       ('Sedat','Çakır','Tarih Öğretmeni','2010-3-3'),
       ('Hilal','Göz','Kimya Öğretmeni','2011-8-10'),
       ('Menekşe','Atay','Türkçe Öğretmeni','2003-3-5')  



insert into Maaslar(PersonelID,MaasMiktari,GuncellemeTarihi)
VALUES(1,8000,GetDate()),
    (2,8200,GETDATE()),
    (3,8400,GETDATE()),
    (4,8600,GETDATE()),
    (5,8800,GETDATE()),
    (6,9000,GETDATE()),
    (7,9200,GETDATE()),
    (8,9400,GETDATE()),
    (9,9600,GETDATE()),
    (10,9800,GETDATE())


    insert into Maaslar(PersonelID,MaasMiktari,GuncellemeTarihi)
    Values (1,8200,GETDATE()),
        (2,8400,GETDATE()),
        (3,8600,GETDATE()),
        (4,8800,GETDATE()),
        (5,9000,GETDATE()),
        (6,9200,GETDATE()),
        (7,9400,GETDATE()),
        (8,9600,GETDATE()),
        (9,9800,GETDATE()),
        (10,10000,GETDATE())