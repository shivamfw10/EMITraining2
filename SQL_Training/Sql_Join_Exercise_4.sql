
create database Company1;
use Company1;

create table company(
com_id int primary key,com_name varchar(34))

insert into company values(11,'samsung'),(12,'iball'),
(13,'epsion'),(14,'zebronics'),(15,'asus'),(16,'frontech')

create table item_mast (
pro_id int primary key ,pro_name varchar(34), pro_price int,pro_com int 
FOREIGN KEY REFERENCES company(com_id))

insert into item_mast values(101,'mother board',3200,15),
(102,'key board',450,16),
(103,'ZIP drive', 250,14),
(104,'speaker',550,16),
(105,'Monitor',5000,11),
(106,'DVD drive',900,12),
(107,'CD drive',800,12),
(108,'Printer', 2600,13),
(109,'Refill cartridge',350,13),
(110,'Mouse',250,12)

create table emp_department(DPT_code int primary key,DPT_Name varchar(34),DPT_ALLOTMENT int)

insert into  emp_department values( 57,'IT',65000),(63,'Finance',15000),(47,'HR',240000),(27,'RD',55000),(89,'QC',75000)

create table emp_details (
emp_IDNO int primary key,emp_fname varchar(34),emp_lname varchar(34),emp_DPT int 
FOREIGN KEY REFERENCES emp_department(DPT_code))

insert into emp_details values (127323,'Michale','Robbin',57),
(526689,'carlos','snares',63),
(843795,'Enric','Dosio',57),
(328717,'Jhon','Snares',63),
(444527,'Joseph','Dosni',47),
(659831,'Zanifer','Emily',47),
(847674,'Kuleswar','Sitaraman',57),
(748681,'Henrey',' Gabreil',47),
(555935,'Alex','Manuel',57),
(539569,'George','Mardy',27),
(733843,'Mario','Saule',63),
(631548,'Alan','Snappy',27),
(839139,'Maria','Foster',57)

CREATE TABLE salesman (salesman_ID INT NOT NULL PRIMARY KEY, NAME varchar(43),city char(37),commission decimal(2,2));
select * from salesman

INSERT INTO salesman 
(salesman_id,name,city,commission) VALUES
(5001,'James Hoog','New York',0.15),
(5002,'Nail Knite','Paris ',0.13),
(5005,'Pit Alex','London ',0.11),
(5006,'Mc Lyon ','Paris ',0.14),
(5003,'Lauson Hen ','San Jose',0.12),
(5007,'Paul Adam ','Rome',0.13);

CREATE TABLE customer(customer_ID INT NOT NULL PRIMARY KEY ,cust_name varchar(43),city char(37),
grade int,
salesman_id int
FOREIGN KEY (salesman_id)
REFERENCES salesman(salesman_id)
);

INSERT INTO customer 
(customer_ID,cust_name,city,grade,salesman_id) VALUES
(3002,'Nick Rimando','New York',100,5001),
(3005,'Graham Zusi','California',200,5002),
(3004,'Fabian Johnson','Paris ',300,5006),
(3007,'Brad Davis ','New York',200,5001),
(3009,'Geoff Cameron ','Berlin',100,5003),
(3008,'Julian Green ','London',300,5002),
(3003,'Jozy Altidor','Moscow',200,5007);

CREATE TABLE orders(
   ord_no   integer PRIMARY KEY,
   purch_amt decimal(6,2),
   ord_date  Date not null,
   customer_id INT FOREIGN KEY (customer_id) 
   REFERENCES customer(customer_id),
   salesman_id int FOREIGN KEY (salesman_id) 
   REFERENCES salesman(salesman_id)         
);

INSERT INTO orders VALUES(70001,150.5,'2012/10/05', 3005,5002);
INSERT INTO orders VALUES(70009,270.65,  '2012-09-10', 3001,5005);
INSERT INTO orders VALUES(70002, 65.26,  '2012-10-05', 3002,5001);
INSERT INTO orders VALUES(70004,110.5, '2012-08-17', 3009,5003);
INSERT INTO orders VALUES(70007,948.5, '2012-09-10', 3005,5002);
INSERT INTO orders VALUES(70005,2400.6, '2012-07-27', 3007,5001);
INSERT INTO orders VALUES(70008,5760, '2012-09-10', 3002,5001);
INSERT INTO orders VALUES(70010,1983.43,'2012-10-10', 3004,5006);
INSERT INTO orders VALUES(70003,2480.4,'2012-10-10', 3009,5003);
INSERT INTO orders VALUES(70011, 75.29,'2012-08-17',3003,5007);
INSERT INTO orders VALUES(70013,3045.6, '2012-04-25',3002,5001);
INSERT INTO orders VALUES(70012,250.45, '2012-06-27',3008,5002);


select * from company;
select * from customer;
select * from emp_department;
select * from emp_details;
select * from item_mast;
select * from orders;
select * from salesman


--QUERIES:
--1. Write a SQL statement to make a list with order no, purchase amount, customer name and their cities for those orders 
--which order amount between 500 and 2000.
SELECT ord.ord_no as 'Order No', ord.purch_amt as 'Purchase Amount', c.cust_name as 'Customer Name', c.city as 'City'
FROM orders ord, customer c 
WHERE ord.customer_ID = c.customer_ID 
AND ord.purch_amt BETWEEN 500 AND 2000

--2 Write a SQL statement to know which salesman are working for which customer.
select c.cust_name as "Customer Name", s.name as "Salesman" from customer c
join salesman s on c.salesman_id=s.salesman_ID

--3. Write a SQL statement to find the list of customers who appointed a salesman for their jobs who gets a commission from
--the company is more than 12%.
select c.cust_name as "Customer Name",c.city as "City", s.name as "Salesman", s.commission as "Commission" from customer c
join salesman s on c.salesman_id=s.salesman_ID where s.commission>.12

--4. Write a SQL statement to find the list of customers who appointed a salesman for their jobs who does not live in
--the same city where their customer lives, and gets a commission is above 12%.
select c.cust_name as "Customer Name",c.city as "City", s.name as "Salesman", s.commission as "Commission" from customer c
join salesman s on c.salesman_id=s.salesman_ID where s.commission>.12 and c.city!=s.city

--5. Write a SQL statement to find the details of an order i.e. order number, order date, amount of order, which customer gives 
--the order and which salesman works for that customer and how much commission he gets for an order. 
SELECT a.ord_no as "Order No",a.ord_date as "Order Date",a.purch_amt as "Purchase Amount", c.cust_name AS "Customer Name", s.name AS "Salesman", s.commission FROM orders a 
JOIN customer c ON a.customer_id=c.customer_id JOIN salesman s ON a.salesman_id=s.salesman_id;

--6. Write a SQL query to display the item name, price, and company name of all the products
select item_mast.pro_name as "Product Name", item_mast.pro_price as "Product Price",  company.com_name as "Company Name" from item_mast join company
on item_mast.pro_com=company.com_id

--7. Write a SQL query to display the names of the company whose products have an average price larger than or equal to Rs. 350.
select AVG(pro_price) as "Average Price", company.com_name as "Company Name" from item_mast
join company on item_mast.pro_com=company.com_id
group by company.com_name HAVING AVG(pro_price)>=350;

--8. Write a query in SQL to display the first name and last name of each employee, along with the name and sanction amount for their department
SELECT emp_details.emp_fname AS "First Name", emp_lname AS "Last Name", emp_department.dpt_name AS "Department", dpt_allotment AS "Amount Allotted" FROM emp_details
JOIN emp_department ON emp_details.emp_DPT = emp_department.dpt_code;

