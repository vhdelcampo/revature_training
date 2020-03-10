use AdventureWorks2017;
go

-- select * 
-- from Person.Person
-- where FirstName='john' or LastName='john'

-- select *
-- from Person.Person
-- where FirstName<>'john' and LastName!='john'


-- select sum(counting) as Duplicates
-- from (
--   select lastname, count(lastname) as [counting]
--   from Person.Person
--   group by LastName
--   having count(*) > 1
-- ) as t;

-- select count(LastName) as [NameCount]
-- from Person.Person
-- group by LastName
-- having count(*) > 1
-- order by NameCount desc;

-- select firstname, lastname, MiddleName
-- from Person.Person
-- where LastName='adams' and len(MiddleName) is NULL;

-- select firstname, lastname
-- from person.person
-- where lastname!='adams' or len(MiddleName) like '%';

-- select *
-- from Person.Address;

select pp.FirstName, pp.lastName, pa.AddressLine1, pa.City
from Person.Address as pa
  inner join Person.BusinessEntityAddress as pbea ON pa.AddressID = pbea.AddressID
  join
  (
    select BusinessEntityID, firstname, lastname
  from Person.Person
  where LastName='adams'
  ) as pp on pp.BusinessEntityID = pbea.BusinessEntityID;


with
  persons
  as
  (
    select BusinessEntityID, firstname, lastname
    from Person.Person
    where LastName='adams'
  )

select persons.FirstName, persons.lastName, pa.AddressLine1, pa.City
from Person.Address as pa
  inner join Person.BusinessEntityAddress as pbea ON pa.AddressID = pbea.AddressID
  join persons on persons.BusinessEntityID = pbea.BusinessEntityID;
  