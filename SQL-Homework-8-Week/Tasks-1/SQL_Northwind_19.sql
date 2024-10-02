--Her bir ülke için toplam satış tutarını hesaplayın.

select
c.Country,
sum((od.UnitPrice*od.Quantity)*(1-od.Discount)) as [Toplam Satış Tutarı]
from Customers c join Orders o on c.CustomerID=o.CustomerID
            join OrderDetails od on od.OrderID=o.OrderID
group by c.Country