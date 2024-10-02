-- En az 5 sipariş veren müşterileri ve sipariş sayılarını listeleyin.

select top 5
c.CompanyName,
count(o.OrderID) as [Müşterinin Sipariş Sayısı]
from Customers c left join Orders o on c.CustomerID=o.CustomerID
group by c.CompanyName
order by [Müşterinin Sipariş Sayısı] 