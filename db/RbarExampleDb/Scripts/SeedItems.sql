declare @count int = 0;
while @count < 500000
begin
	insert into Items(Id, Description, StockCount)
	values(NEWID(), N'Item ' + cast(@count + 1 as nvarchar(10)), 100)
end