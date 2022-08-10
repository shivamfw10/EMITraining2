create database SqlTraining
use SqlTraining
CREATE TABLE Employee(Empid int identity(1001,1),Name nvarchar(50),Department nvarchar(50),HireDate date,Training int);
SELECT * FROM Employee;
insert into Employee values('J. Jones','Sales', '18-Jun-92',24);
insert into Employee values('S. Smith','Production', '12/02/1998',40);
insert into Employee values('S. Smith','Production', '12/02/1998',40);
insert into Employee values('A. Adams','Sales', '11/18/1998',60);
insert into Employee values('B. Bates','Advertising', '03/10/1985',16),('D. Davis','Production', '07/26/1999',56),
('C. Cole','Shipping', '05/18/1991',32),('E .Ellis','Sales', '07/15/1998',80),('F. Files','Advertising', '10/17/1990',24),
('G. Gates','Advertising', '03/15/1999',48);

--1. SQL Query to display unique Department names.
    select distinct Department from Employee;
--2. SQL Query to add Column Location and insert value for all the records(location)
	alter table Employee add Location nvarchar(50);
	update Employee set Location='Banglore' where Empid=1001;
	update Employee set Location='Pune' where Empid=1002;
	update Employee set Location='Banglore' where Empid=1003;
	update Employee set Location='Pune' where Empid=1004;
	update Employee set Location='Banglore' where Empid=1005;
	update Employee set Location='Pune' where Empid=1006;
	update Employee set Location='Banglore' where Empid=1007;
	update Employee set Location='Delhi' where Empid=1008;
	update Employee set Location='Chennai' where Empid=1009;
	update Employee set Location='Indore' where Empid=1010;
--3 SQL Query to change the column name from Empid to EmployeeID;
  sp_rename 'Employee.Empid','EmployeeId'
  
--4 SQL Query to fetch the records of Employees who work in Sales and Shipping
  select * from Employee where Department in('Sales','Shipping');

--5 SQL query to fetch the records who has joined after year 1991 and before 1998
   select * from Employee where HireDate between '01/01/1991' and '12/31/1997'       
            
--6 SQL query to create a new table with same table structure with no data in it.
    select * into NewEmployee from Employee where 1=2;
	--check new Table
    select * from NewEmployee

--7 SQL query to fetch records who has attended training more than 40.
    select * from Employee where Training>40

 --8 SQL Query to create a clone of above table.
     select * into CloneEmployee from Employee;
     select * from CloneEmployee;

 --9 SQL Query to delete the record who has attended training more than 60.
     delete from Employee where Training>60
      select * from Employee

--10 SQ Query to delete the column Hire Date
    alter table Employee drop column HireDate
    select * from Employee

--11 SQL Query to change the datatype of Department to varchar (34).
	alter table Employee alter column Department varchar(34)

   
 --12 SQL Query to insert one record for Name, Department and Training column.
	insert into Employee(Name,Department,Training) values('Pedro','Technology',30);