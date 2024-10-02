--Her bir ülkedeki müşteri sayısını bulun ve müşteri sayısına göre azalan sırayla listeleyin.

select
c.Country,
count(CustomerID) as [Müşteri Sayısı]
from Customers c 
GROUP by c.Country
order by [Müşteri Sayısı] desc
