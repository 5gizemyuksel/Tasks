--Her bir çalışanın toplam satış tutarını hesaplayın.

select
e.FirstName,
e.LastName,
Count(o.OrderID) as [Toplam Satış Sayısı],
sum((od.UnitPrice*Quantity)*(1-od.Discount)) as [Toplam Satış Tutarı]
from Employees e left join Orders o on e.EmployeeID=o.EmployeeID
                join OrderDetails od on od.OrderID=o.OrderID
group by e.FirstName,e.LastName