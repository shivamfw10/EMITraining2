create database Constraints_Demo

use Constraints_Demo

create table Employee(id int constraint id_primary Primary Key, name varchar(24), salary money, leaves varchar(13))

sp_help Employee

select * from Employee

insert into Employee values(1,'Shivam',8756,'PL');
insert into Employee values(2,'Anurag',5678,'PL'), (3,'Anitha',4567.67,'SL');

create table EmployeeInfo(id int references Employee(id),department varchar(23));
select * from EmployeeInfo
sp_help EmployeeInfo
insert into EmployeeInfo values(1,'Tech');
insert into EmployeeInfo values(1,'Training');
insert into EmployeeInfo values(2,'Scrum');
insert into EmployeeInfo values(2,'Training');
insert into EmployeeInfo(department) values('Sales');
insert into EmployeeInfo  values(3,'Publishing');

insert into EmployeeInfo values(4,'HR')

--Foriegn Key Allow Null Values, Not allow those valuse whose not present in primary table/parent

delete from EmployeeInfo where id is null;
delete from EmployeeInfo where id=2;

--disable foriegn key
alter table EmployeeInfo nocheck constraint FK__EmployeeInfo__id__25869641
--this id not is not avaible in primary key
insert into EmployeeInfo values(4,'HR');
--enable foriegn key
alter table EmployeeInfo check constraint FK__EmployeeInfo__id__25869641
--value not inserted because restriction of Constraint
insert into EmployeeInfo values(5,'GM');

select * from Employee
--its constraint allow one null value
alter table Employee add constraint unique_name unique (name)

insert into Employee(id,salary,leaves) values(4,567889,'CL') -- inserted one value
insert into Employee(id,salary,leaves) values(5,56785,'SL') --not inserted

alter table Employee add constraint check_salary check(salary>8000)

select * from EmployeeInfo

alter table EmployeeInfo add constraint check_Dept check(department in('Tech','Training','HR','Publishing'))
alter table EmployeeInfo check constraint check_dept

update Employee set salary=9000.00 where id=2
update Employee set salary=10000.00 where id=3

alter table Employee add constraint default_leave default 'PL' for leaves
insert into Employee(id,name,salary) values(5,'John',90000)


--user should enter PL,CL,SL or take by default value as CL
--possible or not

sp_help EmployeeInfo

alter table EmployeeInfo drop constraint check_Dept

create rule rule_dept
as
@dept in('Tech','Training','Scrum','Publishing')

sp_bindrule 'rule_dept','EmployeeInfo.department'
sp_unbindrule 'EmployeeInfo.department'
