--Her bir çalışanın toplam sipariş sayısını bulun.

select

e.FirstName,
e.LastName,
COUNT(o.OrderID) as [Sipariş Sayısı]
from Employees e left join Orders o on o.EmployeeID=e.EmployeeID
group by e.FirstName,e.LastName 