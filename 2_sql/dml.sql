use pizzaboxdb;
go

--select
select name
from crust
where price > 0
group by name, price
having price > 1.50
order by name desc;

--order of execution
-- FROM
-- WHERE
-- GROUP BY
-- HAVING
-- SELECT
-- ORDER BY
