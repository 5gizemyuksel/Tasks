--6.Her bir çalışanın sorumlu olduğu bölgedeki (Territory) toplam satış miktarını hesaplayın.

select
    e.FirstName,
    e.LastName,
    t.TerritoryID,
    count(OrderID) as [Toplam Satış Miktarı]
from Employees e join EmployeeTerritories et on e.EmployeeID=et.EmployeeID
    join ORders o On o.EmployeeID=et.EmployeeID
    join Territories t on et.TerritoryID=t.TerritoryID
group by e.FirstName,e.LastName,t.TerritoryID



--7. 1997 yılının en yüksek cirolu ayını bulun.

SELECT
    YEAR(OrderDate) AS Year,
    MONTH(OrderDate) AS Month,
    SUM(Freight) AS TotalRevenue
FROM Orders
WHERE YEAR(OrderDate) = 1997
GROUP BY YEAR(OrderDate), MONTH(OrderDate)
ORDER BY TotalRevenue DESC
;



--8. Siparişlerin ortalama teslimat süresini (ShippedDate - OrderDate) hesaplayın ve bu ortalamadan daha uzun sürede teslim edilen siparişleri listeleyin.

SELECT
    OrderID
,
    OrderDate,
    ShippedDate,
    DATEDIFF
(ShippedDate, OrderDate) AS DeliveryDays
FROM Orders
WHERE DATEDIFF
(ShippedDate, OrderDate) >
(
    SELECT AVG(DATEDIFF(ShippedDate, OrderDate))
FROM Orders
);


--9. Aynı gün içinde birden fazla sipariş veren müşterileri ve bu siparişlerin tarihlerini listeleyin.
SELECT CustomerID, OrderDate, COUNT(*) AS OrderCount
FROM Orders
GROUP BY CustomerID, OrderDate
HAVING COUNT(*) > 1;

--10. Çalışanların yaptığı satışları yıllık bazda karşılaştırın ve her yıl için en başarılı çalışanı bulun.
SELECT Year, EmployeeID, MAX(TotalSales) AS MaxSales
FROM (
    SELECT
        YEAR(OrderDate) AS Year,
        EmployeeID,
        SUM(Freight) AS TotalSales
    FROM Orders
    GROUP BY YEAR(OrderDate), EmployeeID
) AS SalesPerEmployee
GROUP BY Year, EmployeeID;

-- 11. Hem 1997 hem de 1998 yıllarında sipariş vermiş müşterileri listeleyin.

    SELECT CustomerID
    FROM Orders
    WHERE YEAR(OrderDate) = 1997
INTERSECT
    SELECT CustomerID
    FROM Orders
    WHERE YEAR(OrderDate) = 1998;

--12. Hiç sipariş almamış çalışanları bulun (eğer varsa).

SELECT EmployeeID, FirstName, LastName
FROM Employees
WHERE EmployeeID NOT IN (
    SELECT EmployeeID
FROM Orders
);

--13. Her bir ülke için, o ülkedeki müşterilerin verdiği siparişlerin ortalama tutarını hesaplayın, ancak  sadece toplam sipariş tutarı 5000'den fazla olan ülkeleri listeleyin.

SELECT Country, AVG(Freight) AS AvgOrderAmount
FROM Orders O
    JOIN Customers C ON O.CustomerID = C.CustomerID
GROUP BY Country
HAVING SUM(Freight) > 5000;

--14. En az 5 farklı ürün sipariş etmiş ve toplam sipariş tutarı 10000'den fazla olan müşterileri bulun.
SELECT O.CustomerID, COUNT(DISTINCT OD.ProductID) AS ProductCount, SUM(OD.Quantity * OD.UnitPrice) AS TotalAmount
FROM Orders O
    JOIN [Order Details] OD ON O.OrderID = OD.OrderID
GROUP BY O.CustomerID
HAVING ProductCount >= 5 AND TotalAmount > 10000;


-- 15. Her bir çalışan için, o çalışanın aldığı siparişlerin ortalama gecikme süresini hesaplayın (RequiredDate ve ShippedDate arasındaki fark).

SELECT
    EmployeeID,
    AVG(DATEDIFF(day, RequiredDate, ShippedDate)) AS AvgDelay
FROM Orders
WHERE ShippedDate IS NOT NULL
GROUP BY EmployeeID;

-- 16. Ürünleri, bulundukları kategorinin ortalama fiyatına göre "Ucuz", "Ortalama" veya "Pahalı" olarak sınıflandırın.

WITH
    CategoryAvgPrice
    AS
    (
        SELECT
            CategoryID,
            AVG(UnitPrice) AS AvgPrice
        FROM Products
        GROUP BY CategoryID
    )
SELECT
    p.ProductID,
    p.ProductName,
    p.UnitPrice,
    CASE
        WHEN p.UnitPrice < ca.AvgPrice THEN 'Ucuz'
        WHEN p.UnitPrice = ca.AvgPrice THEN 'Ortalama'
        ELSE 'Pahalı'
    END AS PriceCategory
FROM Products p
    JOIN CategoryAvgPrice ca ON p.CategoryID = ca.CategoryID;

-- 17. Her bir kargo şirketi için, taşıdıkları siparişlerin ortalama ağırlığını hesaplayın (Freight).
SELECT
    ShipperID,
    AVG(Freight) AS AvgFreight
FROM Orders
GROUP BY ShipperID;

--18. En az 10 farklı müşteriye satılmış ürünleri ve bu ürünlerin satıldığı benzersiz müşteri sayısını listeleyin.

SELECT
    p.ProductID,
    p.ProductName,
    COUNT(DISTINCT o.CustomerID) AS UniqueCustomers
FROM OrderDetails od
    JOIN Orders o ON od.OrderID = o.OrderID
    JOIN Products p ON od.ProductID = p.ProductID
GROUP BY p.ProductID, p.ProductName
HAVING COUNT(DISTINCT o.CustomerID) >= 10;

--19. Her bir çalışanın, her bir müşteriye yaptığı toplam satış tutarını bulun ve sadece 5000'den fazla satış yapılan müşteri-çalışan çiftlerini listeleyin.

SELECT
    o.EmployeeID,
    o.CustomerID,
    SUM(od.UnitPrice * od.Quantity) AS TotalSales
FROM Orders o
    JOIN OrderDetails od ON o.OrderID = od.OrderID
GROUP BY o.EmployeeID, o.CustomerID
HAVING SUM(od.UnitPrice * od.Quantity) > 5000;

--20. Her bir tedarikçinin sağladığı ürünlerin toplam satış miktarını hesaplayın ve tedarikçileri bu miktara göre sıralayın.

SELECT
    s.SupplierID,
    s.CompanyName,
    SUM(od.Quantity) AS TotalQuantitySold
FROM Suppliers s
    JOIN Products p ON s.SupplierID = p.SupplierID
    JOIN OrderDetails od ON p.ProductID = od.ProductID
GROUP BY s.SupplierID, s.CompanyName
ORDER BY TotalQuantitySold DESC;




