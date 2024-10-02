-- Her bir kategorideki ürünlerin ortalama fiyatını bulun.
select
c.CategoryName,
AVG(od.UnitPrice) as [Kategorideki Ürünlerin Ortalama Fiyatı]
from Categories c join Products p on c.CategoryID=p.CategoryID
            join OrderDetails od on p.ProductID=od.ProductID
group by c.CategoryName