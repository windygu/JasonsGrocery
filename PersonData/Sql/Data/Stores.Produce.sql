﻿--inserting products in the Dairy and Produce department
INSERT Stores.Product(StoreID, DepartmentID, UnitPrice, StockQuantity, ProductName)
SELECT S.StoreID, D.DepartmentID, Prod.UnitPrice, Prod.StockQuantity, Prod.ProductName
FROM 
	(
		VALUES
			(N'Dairy', 2, 70, N'Milk'),
			(N'Produce', 2, 30, N'Bananas'),
			(N'Produce', 3, 50, N'Apples'),
			(N'Dairy', 4, 40, N'Butter'),
			(N'Dairy', 3, 100, N'Yogurt')
	)Prod(DepartmentName, UnitPrice, StockQuantity, ProductName)
	INNER JOIN Stores.Department D ON D.DepartmentName = Prod.DepartmentName
	INNER JOIN Stores.Store S ON S.StoreID = D.StoreID;
/******************************************************************************/
--insert more products in the Deli and Bakery departments
INSERT Stores.Product(StoreID, DepartmentID, UnitPrice, StockQuantity, ProductName)
SELECT S.StoreID, D.DepartmentID, Prod.UnitPrice, Prod.StockQuantity, Prod.ProductName
FROM 
	(
		VALUES	
			(N'Deli', 3, 30, N'Ham'),
			(N'Deli', 3, 40, N'Turkey'),
			(N'Deli', 4, 35, N'Beef'),
			(N'Deli', 2, 30, N'Provolone Cheese'),
			(N'Deli', 3, 25, N'PepperJack Cheese'),
			(N'Deli', 2, 20, N'Swiss Cheese'),
			(N'Deli', 3, 40, N'Colby Jack Cheese'),
			(N'Deli', 4, 35, N'Chicken'),
			(N'Bakery', 2.50, 60, N'French Bread'),
			(N'Bakery', 3.50, 50, N'Wheat Bread'),
			(N'Bakery', 2, 75, N'White Bread'),
			(N'Bakery', 2.50, 100, N'Chocolate Chip Cookies'),
			(N'Bakery', 3.50, 80, N'Double Chocolate Chip Cookies'),
			(N'Bakery', 1.50, 120, N'Sugar Cookies'),
			(N'Bakery', 1.00, 30, N'Raisin Cookies'),
			(N'Bakery', 1.75, 55, N'Chocolate Chip Muffins'),
			(N'Bakery', 1.50, 45, N'Blueberry Muffins'),
			(N'Bakery', 2.00, 40, N'Banana Nut Muffins'),
			(N'Deli', 2.50, 45, N'California Roll'),
			(N'Deli', 4.50, 40, N'Dynamite Roll')
	)Prod(DepartmentName, UnitPrice, StockQuantity, ProductName)
	INNER JOIN Stores.Department D ON D.DepartmentName = Prod.DepartmentName
	INNER JOIN Stores.Store S ON S.StoreID = D.StoreID;

	--insert more products in Dairy and Produce Department
INSERT Stores.Product(StoreID, DepartmentID, UnitPrice, StockQuantity, ProductName)
SELECT S.StoreID, D.DepartmentID, Prod.UnitPrice, Prod.StockQuantity, Prod.ProductName
FROM 
	(
		VALUES
			(N'Dairy', 2.50, 60, N'Cottage Cheese'),
			(N'Dairy', 3, 130, N'Sour Cream'),
			(N'Dairy', 3.25, 20, N'Rocky Road Ice Cream'),
			(N'Dairy', 1.50, 40, N'Vanilla Ice Cream'),
			(N'Dairy', 1.75, 35, N'Chocolate Ice Cream'),
			(N'Dairy', 1.25, 15, N'Strawberry Ice Cream'),
			(N'Dairy', 3.50, 25, N'Chocolate Chip Cookie Dough Ice Cream'),
			(N'Dairy', 2.50, 40, N'Chobani Yogurt'),
			(N'Dairy', 1.75, 60, N'Orange Sherbet'),
			(N'Produce', 2, 50, N'Strawberries'),
			(N'Produce', 2.25, 50, N'Oranges'),
			(N'Produce', 1.15, 60, N'Kiwis'),
			(N'Produce', 2.25, 35, N'Corn'),
			(N'Produce', 2, 65, N'Broccoli'),
			(N'Produce', 1.75, 40, N'Cucumbers'),
			(N'Produce', 1.15, 45, N'Onions'),
			(N'Produce', 2.25, 60, N'Potatoes'),
			(N'Produce', 1.50, 45, N'Tomatoes'),
			(N'Produce', 1, 35, N'Peppers'),
			(N'Produce', 1, 100, N'Celery')
	)Prod(DepartmentName, UnitPrice, StockQuantity, ProductName)
	INNER JOIN Stores.Department D ON D.DepartmentName = Prod.DepartmentName
	INNER JOIN Stores.Store S ON S.StoreID = D.StoreID;