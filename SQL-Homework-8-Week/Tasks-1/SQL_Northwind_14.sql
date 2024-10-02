--Her bir müşterinin verdiği sipariş sayısını bulun
select
c.CompanyName,
COUNT(o.OrderID) as [Sipariş sayısı]
from customers c left join Orders o on o.CustomerID=c.CustomerID
group by c.CompanyName
order by [Sipariş sayısı] 


