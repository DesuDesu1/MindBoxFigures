SELECT p.ProductName, ISNULL(c.CategoryName, '��� ���������') AS CategoryName
FROM Products p
LEFT JOIN ProductCategories pc ON p.ProductID = pc.ProductID
LEFT JOIN Categories c ON pc.CategoryID = c.CategoryID