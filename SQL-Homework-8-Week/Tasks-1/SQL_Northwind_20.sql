--Siparişleri, sipariş tarihine göre yıllar ve aylar bazında gruplayarak toplam satış tutarlarını listeleyin.

select
YEAR(o.OrderDate) as [Sipariş Yılı],
Month(o.OrderDate) as [Sipariş Ayı],
sum((od.UnitPrice*od.Quantity)*(1-od.Discount)) as [Toplam Satış Tutarı]
from Orders o join OrderDetails od on o.OrderID=od.OrderID
group by Year(o.OrderDate), Month(o.OrderDate)
order by year(o.OrderDate),month(o.OrderDate)