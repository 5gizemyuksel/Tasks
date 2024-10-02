--1998 yılında yapılan siparişleri listeleyin.

select
o.OrderID,
p.ProductName,
o.OrderDate
from Orders o join OrderDetails od on o.OrderID=od.OrderID
        join Products p on p.ProductID=od.ProductID
where o.OrderDate between '1998-01-01' and '1998-12-31'
order by o.OrderDate
