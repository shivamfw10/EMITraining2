SELECT * FROM company;
SELECT * FROM customer;
SELECT * FROM emp_department;
SELECT * FROM emp_details;
SELECT * FROM item_mast;
SELECT * FROM orders;
SELECT * FROM salesman;

--1. Write a SQL statement to make a list with order no, purchase amount, 
--customer name and their cities for those orders which order amount between 500 and 2000.
select o.ord_no as 'Order_No', o.purch_amt as 'Purchase_Amount',c.cust_name as 'Customer_Name',
c.city as 'City' from orders o, customer c WHERE o.customer_id=c.customer_id
AND o.purch_amt BETWEEN 500 AND 2000;

--2.Write a SQL statement to know which salesman are working for which customer.
select c.cust_name as 'Customer_Name', c.city as 'City',
s.name as 'Salesman', s.commission as 'Commission' from customer c
JOIN salesman s ON c.salesman_id = s.salesman_id

--3.Write a SQL statement to find the list of customers who appointed a salesman
--for their jobs who gets a commission from the company is more than 12%.
select c.cust_name as 'Customer_Name', c.city as 'City',
s.name as 'Salesman', s.commission as 'Commission' from customer c
join salesman s on c.salesman_id=s.salesman_id 
WHERE s.commission>.12

--4. Write a SQL statement to find the list of customers who appointed a salesman for their jobs who does not live in
--the same city where their customer lives, and gets a commission is above 12%.
select c.cust_name as 'Customer_Name', c.city as 'City',
s.name as 'Salesman', s.commission as 'Commission' from customer c
join salesman s on c.salesman_id=s.salesman_id 
WHERE s.commission>.12 AND c.city!=s.city

--5.Write a SQL statement to find the details of an order i.e. order number, order date, amount of order, which customer gives 
--the order and which salesman works for that customer and how much commission he gets for an order. 
select o.ord_no as 'Order_Numer', o.ord_date as 'Order_Date',o.purch_amt as 'Purchase_Amount',
c.cust_name as 'Customer_Name', c.grade as 'Grade',
s.name as 'Salesman',s.commission as 'Commission' from orders o
JOIN customer c ON o.customer_id = c.customer_id
JOIN salesman s ON o.salesman_id = s.salesman_id


--6. Write a SQL query to display the item name, price, and company name of all the products
select item_mast.pro_name as 'Product Name', pro_price as 'Price', company.com_name as 'Company Name' from item_mast
join company on item_mast.pro_com=company.com_id

--7. Write a SQL query to display the names of the company whose products have an average price 
--larger than or equal to Rs. 350.
select AVG(pro_price) as 'Average Price', company.com_name as 'Company Name' from item_mast
JOIN company ON item_mast.pro_com=company.com_id
GROUP BY company.com_name HAVING AVG(pro_price)>=350

--8. Write a query in SQL to display the first name and last name of each employee, 
--along with the name and sanction amount for their department
select emp_details.emp_fname as 'First Name', emp_lname as 'Last Name',
emp_department.dpt_name AS 'Department', dpt_allotment AS 'Amount'
FROM emp_details
JOIN emp_department ON emp_details.emp_DPT = emp_department.DPT_code



