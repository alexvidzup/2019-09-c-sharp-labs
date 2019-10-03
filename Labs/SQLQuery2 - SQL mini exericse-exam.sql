-- Exercise 1 - Query for northwind

--1.1
-- Include Customer ID, Company Name and all address fields.
SELECT CustomerID, ContactName, CompanyName, 
CONCAT(Address,', ', City, ', ', Country) AS 'Full Adress' 
FROM Customers WHERE City='Paris' OR City='London'

--1.2 1.2	List all products stored in bottle.

--1.3	Repeat question above, but add in the Supplier Name and Country.
--1.4	Write an SQL Statement that shows how many products there are in each category. 
--Include Category Name in result set and list the highest number first.
--select
--COUNT(Products.CategoryID) AS 'Number Of Items' 
--from [Products] P JOIN Categories C ON P.CategoryID = C.CategoryID
--GROUP BY P.CategoryID ORDER BY P.CategoryID DESC

SELECT COUNT(Products.CategoryID) AS 'Number Of Items' FROM Products 
inner join Categories on Products.CategoryID = Categories.CategoryID
select * from Categories
GROUP BY Products.CategoryID ORDER BY COUNT(Products.CategoryID) DESC

SELECT COUNT(Products.CategoryID) AS 'Number Of Items' 



select * from Categories
select * from Products


--1.5	List all UK employees using concatenation to join 
--their title of courtesy, first name and last name together. Also include their city of residence.
SELECT CONCAT(TitleOfCourtesy,' ',FirstName,' ',LastName) AS 'Full Name', City
FROM Employees WHERE Country='UK'


--1.6	List Sales Totals for all Sales Regions (via the Territories table using 4 joins) with a Sales Total greater than 1,000,000. Use rounding or FORMAT to present the numbers. 
--1.7	Count how many Orders have a Freight amount greater than 100.00 and either USA or UK as Ship Country.
--1.8	Write an SQL Statement to identify the Order Number of the Order with the highest amount of discount applied to that order.
