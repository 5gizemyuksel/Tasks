--En çok satılan 5 ürünü ve satış miktarlarını listeleyin.

select top 5
p.ProductName,
count(od.Quantity) as [Satış Miktarı]
from orders o join OrderDetails od on o.OrderID=od.OrderID
        join Products p on od.ProductID=p.ProductID
group by p.ProductName
order by [Satış Miktarı] desc