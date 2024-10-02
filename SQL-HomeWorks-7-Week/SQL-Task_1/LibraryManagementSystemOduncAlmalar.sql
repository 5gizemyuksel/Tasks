create table OduncAlmalar(
    OgrenciID int not null,
    KitapID int  null,
    DergiID int  null,
    DVDID int null,
    OduncTarhihi date not null,
    foreign key (OgrenciID) references Ogrenciler(Id),
    FOREIGN key (KitapID) references Kitaplar(KitapID),
    FOREIGN key (DergiID) REFERENCES Dergiler(DergiID),
    FOREIGN key (DVDID) REFERENCES DVDler(DVDID)

)

INSERT INTO OduncAlmalar (OgrenciID, KitapID, DergiID, DVDID, OduncTarhihi)
VALUES
    
    (1, 15, NULL, NULL, '2023-09-01'),   -- Öğrenci 1 kitap ödünç aldı
    (2, 7, NULL, NULL, '2023-09-02'),    -- Öğrenci 2 kitap ödünç aldı
    (3, 19, NULL, NULL, '2023-09-03'),   -- Öğrenci 3 kitap ödünç aldı
    (4, 2, NULL, NULL, '2023-09-04'),    -- Öğrenci 4 kitap ödünç aldı
    (5, NULL, 3, NULL, '2023-09-05'),    -- Öğrenci 5 dergi ödünç aldı
    (6, NULL, NULL, 4, '2023-09-06'),    -- Öğrenci 6 DVD ödünç aldı
    (7, 11, NULL, NULL, '2023-09-07'),   -- Öğrenci 7 kitap ödünç aldı
    (8, NULL, 4, NULL, '2023-09-08'),    -- Öğrenci 8 dergi ödünç aldı
    (9, NULL, NULL, 5, '2023-09-09'),    -- Öğrenci 9 DVD ödünç aldı
    (10, 18, NULL, NULL, '2023-09-10');  -- Öğrenci 10 kitap ödünç aldı

    
