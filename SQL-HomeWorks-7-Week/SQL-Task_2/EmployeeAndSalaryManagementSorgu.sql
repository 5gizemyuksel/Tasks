
--Her personelin mevcut maaşını listeleyin (En son güncelleme tarihine göre).
select top 10
p.Ad as [İsim],
p.Soyad as [Soyisim],
m.MaasMiktari
from Personel p join Maaslar m on p.PersonelID=m.PersonelID
order by m.GuncellemeTarihi desc

-- Tüm personelin ortalama maaşını hesaplayan bir sorgu yazın.
select
 avg(m.MaasMiktari) as [Ortalama Maaş]
from Maaslar m
 
 -- Aynı pozisyonda çalışan personelin maaşlarını karşılaştırarak en yüksek ve en düşük maaşları getirin.
--Aynı Pozisyonda çalışan eğitmen yok o yüzden en yüksek ve en düşük maaş

select 
MAX(m.MaasMiktari) as [En büyük],
MIN(m.MaasMiktari) as [En düşük]
from Personel p join Maaslar m on p.PersonelID=m.PersonelID
Where m.GuncellemeTarihi>'2024-09-30 21:42:34.587'

-- Tüm personelin adını, soyadını ve pozisyonunu listeleyin. (`SELECT` ve `FROM`)
SELECT top 10
p.Ad,
p.Soyad,
p.Pozisyon
from Personel p

-- Hangi pozisyonda kaç personel çalıştığını gösteren bir liste oluşturun. (`GROUP BY` ve `COUNT`)
select 
p.Pozisyon,
count(PersonelID) as [Çalışan Sayısı]
from personel p
group by p.Pozisyon

--Her personelin en son maaş miktarını ve güncelleme tarihini listeleyin. (`JOIN` ve `MAX`)
select top 10
p.Ad,
p.Soyad,
m.MaasMiktari ,
m.GuncellemeTarihi as [En Son Maaş Güncelleme]
from personel p join Maaslar m on p.PersonelID=m.PersonelID
group by p.Ad,p.Soyad,m.MaasMiktari,m.GuncellemeTarihi
order by m.GuncellemeTarihi desc

