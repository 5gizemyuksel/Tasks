--Çalışanların yöneticilerini (FirstName ve LastName) listeleyin. Yöneticisi olmayan çalışanlar da listelenmelidir.

select
e.FirstName,
e.LastName,
m.FirstName as [Yönetici İsmi],
m.LastName as [Yönetici Soyismi]
from Employees e left join Employees m on e.ReportsTo=m.EmployeeID