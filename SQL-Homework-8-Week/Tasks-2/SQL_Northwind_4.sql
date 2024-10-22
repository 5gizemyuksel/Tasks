--Her bir tedarikçinin sağladığı ürünlerin ortalama fiyatını hesaplayın, ancak sadece 10'dan fazla ürün sağlayan tedarikçileri listeleyin.

select
s.CompanyName,
avg(od.UnitPrice) as [Tedarikçinin sağladığı ürünlerin ortalama fiyatı]
from Suppliers s join Products p on p.SupplierID=s.SupplierID
                join OrderDetails od on od.ProductID=p.ProductID
group by s.CompanyName
having count(p.ProductID)>10 