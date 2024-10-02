--En pahalı 5 ürünü fiyatlarıyla birlikte listeleyin.

select top 5
p.ProductName,
p.UnitPrice
from products p 
order by p.UnitPrice desc 
