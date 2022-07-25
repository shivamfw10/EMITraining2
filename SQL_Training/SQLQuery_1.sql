create table Employees  
(  
   EmpId int identity(1,1) ,  
   FirstName varchar(100),  
   LastName varchar(100),  
   JoinDate datetime ,  
   Salary int ,  
   Department varchar(20)  
)  
insert into Employees(FirstName,LastName,JoinDate,Salary,Department)values('Rakesh','Kalluri','2012-07-01 10:00:00.000',20000,'Software')  
insert into Employees(FirstName,LastName,JoinDate,Salary,Department)values('Shabari','Vempati','2011-05-01 10:00:00.000',25000,'Software')  
insert into Employees(FirstName,LastName,JoinDate,Salary,Department)values('Venkatesh','Bodupaly','2013-04-01 10:00:00.000',15000,'Bpo')  
insert into Employees(FirstName,LastName,JoinDate,Salary,Department)values('Surjan','Peddineni','2011-07-01 10:00:00.000',25000,'Software')  

insert into Employees(FirstName,LastName,JoinDate,Salary,Department) values('Nani','Ch','2010-07-01 10:00:00.000',50000,'Software')  
insert into Employees(FirstName,LastName,JoinDate,Salary,Department) values('Raju','Chinna','2012-07-01 10:00:00.000',25000,'Software')  
insert into Employees(FirstName,LastName,JoinDate,Salary,Department) values('Kiran','Kumar','2011-07-01 10:00:00.000',20000,'Software')  
insert into Employees(FirstName,LastName,JoinDate,Salary,Department) values('Raki','Kumar','2012-07-01 10:00:00.000',17000,'Bpo')  
insert into Employees(FirstName,LastName,JoinDate,Salary,Department) values('Sri','Vidya','2011-07-01 10:00:00.000',30000,'Software')  
insert into Employees(FirstName,LastName,JoinDate,Salary,Department) values('Fehad','MD','2013-07-01 10:00:00.000',20000,'Bpo')  
insert into Employees(FirstName,LastName,JoinDate,Salary,Department)values('Anusha','Kumari','2011-07-01 10:00:00.000',35000,'Software')  
insert into Employees(FirstName,LastName,JoinDate,Salary,Department) values('Venky','Naidu','2013-07-01 10:00:00.000',20000,'Bpo')  
insert into Employees(FirstName,LastName,JoinDate,Salary,Department)values('Radha','Kumari','2012-07-01 10:00:00.000',10000,'Bpo')

SELECT * FROM Employees