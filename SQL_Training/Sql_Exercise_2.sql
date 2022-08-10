use Employee

SELECT * FROM countries;
SELECT * FROM departments;
SELECT * FROM dependents;
SELECT * FROM employees;
SELECT * FROM jobs;
SELECT * FROM locations;
select * FROM jobs;
SELECT * FROM regions

--1. Display the maximum, minimum and average salary and commmision earned.
--Max Salary
Select Max(Salary) as MaxSalary from Employees
--Min Salary
Select Min(Salary) as MinSalary from Employees
--Average Salary
Select AVG(Salary) as AverageSalary from Employees

--2. Display the department number, total salary payout and total commision payout for each department
--Display No Of Department
Select department_id, SUM(Salary) as TotalPayout from Employees group by department_id

--Total Salary Payout
Select SUM(Salary) as TotalPayout from Employees

--3. Display the department number and total number of employees in each department
--Department and No_of Employee in Each Department
SELECT dep.department_name as 'Department', count(dep.department_name) as No_Of_Employees from employees emp
join departments dep ON dep.department_id=emp.department_id group by dep.department_name;

Select department_id, count(department_id) as No_Of_Employee from Employees group by department_id;

--4 Display the department and Total salary of employess in each department
--Department and Total Salary of each department
select department_id,sum(salary)from employees group by department_id

SELECT dep.department_name as 'Department', SUM(emp.salary) as No_Of_Employees from employees emp
join departments dep ON dep.department_id=emp.department_id group by dep.department_name;

--5 Dsiplay the employee's name who doesn't earn a commision. Order the result set without using the column name


--6 Display the employees name,department,id and commision. If an Employee doesn't earn the commision then display as 'No commision'.Name the columns appropriately


--7 Display the employee's name, salary and commision mulitplied by 2. If an Employee doesn't earn the commision then display as 'No commision'.Name the columns appropriately

--8 Display the employee's name, department, id who have the first name as another employee in the same department
select concat(first_name,last_name),department_id from employees

--9 Display the sum of salaries of the employees working under each Manager
select manager_id ,sum(salary) as total_salary from employees group by manager_id

--10 Select the Managers name, the count of employees working and the department Id of the Manager
select m.manager_id, count(*) as 'No_Of_Employee' from employees m, employees emp
where m.manager_id = emp.employee_id
group by m.manager_id order by m.manager_id asc
--Note : Name not mention in Table Only Employee ID is here

--11 Select the employee name, department id, and the salary. Group the result with the manager name and the employee last name should have second letter 'a';
select concat(m.first_name,m.last_name)as EmployeeName,m.department_id,m.salary,emp.first_name as manager_name
from employees m,employees emp where m.manager_id=emp.employee_id and m.last_name like '_a%' 

--12 Display the average of sum of the salaries and group the result with the department id. Order the result with the department id.
select department_id,avg(salary)as AvgSalary from dbo.employees group by department_id  order by department_id

--13 Select the maximum salary of each department along with department id.
select department_id,max(salary)as MaxSalary from employees group by department_id

--14 Display the commision, if not null display 10% fo salary, if null display a default value 1.
