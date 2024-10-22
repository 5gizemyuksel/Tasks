--En az 3 farklı kategoriden ürün sipariş etmiş müşterileri bulun.

select
c.CompanyName,
count (distinct cg.CategoryID) as [Kategori sayısı]
from Customers c join Orders o on o.CustomerID=c.CustomerID
            join OrderDetails od on od.OrderID=o.OrderID
            join products p on p.ProductID=od.ProductID
            join Categories cg on cg.CategoryID=p.CategoryID
group by c.CompanyName
having count(distinct cg.CategoryID)>=3
    


