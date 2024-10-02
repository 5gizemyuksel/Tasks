-- Çalışanların ad ve soyadlarını birleştirerek tam isimlerini listeleyin.

select
e.FirstName+ ' '+e.LastName as [Çalışan İsimleri]
from Employees e


 