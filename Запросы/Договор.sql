CREATE TABLE Договоры
(	
	[Код договора]		int		IDENTITY(1,1) NOT NULL,
		Constraint PK5 primary key ([Код договора]),
	[Номер помещения]		tinyint		NOT NULL
		CONSTRAINT FK4 FOREIGN KEY ([Номер помещения])
			REFERENCES Помещения ([Номер помещения]),
	[Идентификатор арендатора]	int NOT NULL,
		CONSTRAINT FK5 FOREIGN KEY ([Идентификатор арендатора])
			REFERENCES Арендаторы ([Идентификатор арендатора]),
	[Идентификатор риелтора]	int NOT NULL,
		CONSTRAINT FK6 FOREIGN KEY ([Идентификатор риелтора])
			REFERENCES Риелторы ([Идентификатор риелтора]),
	Статус CHAR(50) ,
	[Дата начала]	Date 	not null,
	[Дата окончания]	Date 	not null,
	[Периодичность оплаты]	VARCHAR(50) 	not null,
	[Сумма оплаты]	money 	not null,
	[Цель аренды] VARCHAR(50),
	[Штраф за нарушение] money,
	Примечания varchar(1000))
