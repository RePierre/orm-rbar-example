if not exists (select 1 from Customers where FirstName = 'John' and LastName = 'Doe')
begin
	insert into Customers(Id, FirstName, LastName)
	values('8D2FB311-18F8-4851-B3C8-EE0BF668426C', N'John', N'Doe')
end