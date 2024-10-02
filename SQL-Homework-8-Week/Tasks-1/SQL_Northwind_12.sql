--Her bir siparişin toplam tutarını hesaplayın.

select
o.OrderID,
SUM((od.UnitPrice*od.Quantity)*(1-od.Discount))
from orders o join OrderDetails od on o.OrderID=od.OrderID
group by o.OrderID