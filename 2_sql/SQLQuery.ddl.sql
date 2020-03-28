use AdventureWorks2017;
go

create database PizzaBoxDb; --.mdf, .ndf, .ldf
go

create schema Pizza;
go

create table [Pizza.Pizza]
)
  PizzaId int not null primary key identity
(1,1)
    ,[Name] nvarchar
(50) not null
    ,[Date] datetime2
(7) check
(Date > = getdate
())
    ,[Active] bit default
(1)
)
create view vw_Pizza
with
  schemabinding
as
  (
  select *
  from Pizza.Pizza
);
go

create function fn_Pizza(@d datetime2, @n nvarchar)
returns nvarchar
as
begin
  return @n + ' ' + @d
end
go

create function fn_Pizza2(@id int)
returns table
as
  return
  select *
from Pizza.Pizza
where PizzaId = @id
go

create procedure  sp_Pizza(@name nvarchar)
begin
  begin transaction
  declare @checkname nvarchar;

  select @checkname = name
  from Pizza.Pizza
  where name = @name

  if(@checkname is null)
    begin
    insert into Pizza.Pizza
      (Name)
    values()
  end
  commit transaction

  else
  begin
    rollback transaction
  end
end