--Hiç sipariş vermemiş müşterileri listeleyin.
select
c.CompanyName as [Sipariş Vermemiş Müşteriler]
from customers c left join orders o on c.CustomerID=o.CustomerID
group by c.CompanyName
having count(o.OrderID)=0


