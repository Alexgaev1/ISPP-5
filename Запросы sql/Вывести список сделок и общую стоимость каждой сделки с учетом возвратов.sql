--**Вывести список сделок и общую стоимость каждой сделки с учетом возвратов:**
SELECT
a.AgreementID as [Код договора],
c.Surname AS [Фамилия клиента],
c.Names AS [Имя клиента],
c.Patronymic AS [Отчество клиента],
SUM(t.Cost - COALESCE(b.BackSum, 0)) AS [Общая стоимость с учетом возвратов]
FROM
Agreement a
JOIN Client c ON a.ClientID = c.ClientID JOIN Thing t ON a.ThingID = t.ThingID LEFT JOIN Back b ON c.ClientID = a.ClientID
GROUP BY a.AgreementID, c.Surname, c.Names, c.Patronymic