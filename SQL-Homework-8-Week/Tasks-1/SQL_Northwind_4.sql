--Stok miktarı 10'dan az olan ürünleri listeleyin.

select
p.ProductName as [Stok Miktarı 10'dan Az Olan]
from Products p
where p.UnitsInStock<10