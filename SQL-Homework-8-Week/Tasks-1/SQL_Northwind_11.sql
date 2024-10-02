--Ürünleri kategorileriyle birlikte listeleyin.

select
p.ProductName,
c.CategoryName
from Products p left join Categories c on p.CategoryID=c.CategoryID