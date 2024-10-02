--Tüm kitapların adını, yazarını ve yayın yılını listeleyin. (`SELECT` ve `FROM`)
select 
KitapAdi,
Yazar,
YayınYili
from Kitaplar 



-- Yayın yılı 2000’den sonra olan kitapların isimlerini ve yazarlarını listeleyin. (`WHERE`)

select KitapAdi,Yazar,YayınYili
from Kitaplar
where YayınYili>2000




select*from Kitaplar 
select*from Ogrenciler 
select*from OduncAlmalar


---Hangi öğrencinin hangi kitapları ödünç aldığını gösteren bir liste oluşturun. (`JOIN`)

select
o.FullName as [Öğrenci],
k.KitapAdi as [Kitap]
from Kitaplar k join OduncAlmalar oa on k.KitapID=oa.KitapID
        join Ogrenciler o on o.Id=oa.OgrenciID 
        Where oa.KitapID is not null



-- En fazla sayfa sayısına sahip 5 kitabı sayfa sayısına göre azalan sırayla listeleyin. (`ORDER BY` ve `LIMIT`)
select top 5
k.SayfaSayisi as [Sayfa Sayısı]
from Kitaplar k 
order by k.SayfaSayisi desc 


-- "Orhan Pamuk" adlı yazarın kitaplarını listeleyin. (`WHERE`)
select
k.KitapAdi [Orhan Pamuk'un Kitapları]
from Kitaplar k 
where k.Yazar='Orhan Pamuk'
--  Öğrencilerin ödünç aldığı dergileri ve bu dergilerin yayıncılarını listeleyin. (`JOIN`)
select
d.DergiAdi as [Dergi],
d.Yayinci as [Yayıncı]
from 
ogrenciler o join OduncAlmalar oa on o.Id=oa.OgrenciID 
            join Dergiler d on oa.DergiID = d.DergiID 


--Henüz hiçbir materyal ödünç almayan öğrencileri listeleyin. (`LEFT JOIN` ve `IS NULL`)
select
o.FullName
from Ogrenciler o left join OduncAlmalar oa on o.Id = oa.OgrenciID
where oa.OgrenciID is null


--Her kitabın, derginin ve DVD'nin kaç kez ödünç alındığını gruplandırarak listeleyin. (`GROUP BY`)
select
k.KitapAdi,
d.DergiAdi,
dvd.DVDAdi,
count(OgrenciID) as [Ödünç Alınma Sayısı]
from OduncAlmalar oa left join Kitaplar k on oa.KitapID=k.KitapID
        left join Dergiler d on d.DergiID=oa.DergiID
        left join DVDler dvd on dvd.DVDID=oa.DVDID
GROUP by k.KitapAdi,d.DergiAdi,DVDAdi

--   Yayın tarihi en eski olan 3 kitabı listeleyin. (`ORDER BY` ve `LIMIT`)
select top 3
k.KitapAdi,
k.YayınYili
from Kitaplar k 
order by k.YayınYili 



-- "Ali Yılmaz" adlı öğrencinin ödünç aldığı tüm materyalleri listeleyin. (`WHERE` ve `JOIN`)
select
o.FullName,
k.KitapAdi,
d.DergiAdi,
dvd.DVDAdi
from Ogrenciler o left join OduncAlmalar oa on o.Id=oa.OgrenciID
       left join Kitaplar k on oa.KitapID=k.KitapID
       left join Dergiler d on oa.DergiID=d.DergiID
       left join DVDler dvd on oa.DVDID=dvd.DVDID
where o.FullName='Elif Aydin' 


   









 