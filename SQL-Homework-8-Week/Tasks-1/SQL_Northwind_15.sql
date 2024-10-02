--Hangi kargo şirketinin kaç sipariş taşıdığını listeleyin.

select
o.ShipName,
count(o.OrderID) as [Taşıdığı Sipariş Sayısı]
from Orders o 
group by o.ShipName
