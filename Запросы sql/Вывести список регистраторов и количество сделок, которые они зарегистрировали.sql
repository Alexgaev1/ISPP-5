--*Вывести список регистраторов и количество сделок, которые они зарегистрировали:**
SELECT
r.RegistrarID as [Код приемщика],
r.Surname as [Фамилия приемщика],
r.Names as [Имя приемщика],
r.Patronymic as [Отчество приемщика],
COUNT(a.AgreementID) AS [Количество оформленных договоров]
FROM
Registrar r LEFT JOIN Agreement a ON r.RegistrarID = a.RegistrarID
GROUP BY r.RegistrarID, r.Surname, r.Names, r.Patronymic