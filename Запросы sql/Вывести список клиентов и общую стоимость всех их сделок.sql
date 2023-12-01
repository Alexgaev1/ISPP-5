--Вывести список клиентов и общую стоимость всех их сделок:
SELECT
Client.ClientID,
Surname AS [Фамилия],
Names AS [Имя],
Patronymic AS [Отчество],
COUNT(AgreementID) AS [Количество договоров],
SUM(Cost) AS [Общая стоимость]
FROM
Client LEFT JOIN Agreement ON Client.ClientID = Agreement.ClientID LEFT JOIN Thing ON Thing.ThingID = Agreement.ThingID
GROUP BY Client.ClientID, Surname, Names, Patronymic