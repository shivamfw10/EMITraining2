--create user type

create type zipcode from int not null
create table address (city varchar(20),zipcode zipcode)
sp_help address

-- if,while,nested if, exception
--declare @a int 
--set @a=4
--if @a%2=0
--begin print 'Number is even'
--end
--else
--begin
--print 'Number is odd'
--end

--declare @marks int
--set @marks =78
--if @marks>=78
--begin
--print 'Passed in distinction'
--end
--else
--begin 
--if @marks<78 and @marks>=60
--begin 
--print 'Passed in first division'
--end
--else
--print 'Passed in second division'
--end

--declare @counter int
--set @counter=1
--while (@counter<10)
--begin
--print @counter
--set @counter=@counter+1
--end

-- Exception Handling
/*
Error_Line()
Error_Message()
Error_Procedure()
Error_number()
Error_severity()
*/

--declare @b int
--declare @c int
--begin try
--set @b=24
--set @c=@b/0
--end try
--begin catch
--print 'Error Occured'
--print Error_message()
--print error_line()
--print error_procedure()
--print Error_number()
--print Error_severity()
--end catch

declare @a int
declare @result int
begin try
set @a=6
set @result =@a%2
if @result=1
print 'Error not occured, Its odd number'
else
begin
print 'Error Occured';
throw 60000,'Number is even',5
end
end try
begin catch
select ERROR_MESSAGE() as 'Error'
select ERROR_NUMBER() as 'ErrorNumber'
end catch
