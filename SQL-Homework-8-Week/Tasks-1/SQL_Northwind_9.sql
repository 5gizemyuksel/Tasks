--Nakliye ücreti 50'den fazla olan siparişleri listeleyin.

select
o.OrderID as [Sipariş Numarası],
p.ProductName as [Ürün Adı],
o.Freight as [Nakliye Ücreti]
from Orders o join OrderDetails od on o.OrderID=od.OrderID
        join Products p on p.ProductID=od.ProductID
where Freight>50
order by o.Freight