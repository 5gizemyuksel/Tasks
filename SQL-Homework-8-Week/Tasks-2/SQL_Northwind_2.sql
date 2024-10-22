--Her bir ürün için, o ürünü sipariş eden benzersiz müşteri sayısını bulun.

select
p.ProductName,
count(distinct o.CustomerID) as [Benzersiz Müşteri Sayısı]
from Products p join OrderDetails od on p.ProductID=od.ProductID
            join Orders o on o.OrderID=od.OrderID
group by p.ProductName