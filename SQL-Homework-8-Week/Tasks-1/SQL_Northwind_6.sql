--Her bir kategorideki ürün sayısını bulun.

select
c.CategoryName,
count(ProductID) as [Ürün Sayısı]
from Products p right join Categories c on p.CategoryID=c.CategoryID
GROUP by c.CategoryName