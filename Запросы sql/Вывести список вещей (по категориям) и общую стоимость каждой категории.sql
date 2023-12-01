--**Вывести список вещей (по категориям) и общую стоимость каждой категории:**
SELECT
cat.Category as [Категория],
COUNT(t.ThingID) AS [Количество вещей],
SUM(t.Cost) AS [Общая стоимость]
FROM
Category cat LEFT JOIN Thing t ON cat.CategoryID = t.CategoryID
GROUP BY cat.Category