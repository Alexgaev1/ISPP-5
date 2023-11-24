CREATE TABLE [Осмотр помещений]
(	
	[Код записи]	int		IDENTITY(1,1),
		Constraint PK4 primary key ([Код записи]),
	[Номер помещения]		tinyint					not null
		CONSTRAINT FK1 FOREIGN KEY ([Номер помещения])
			REFERENCES Помещения ([Номер помещения]),
	[Идентификатор арендатора]	int					not null
		CONSTRAINT FK2 FOREIGN KEY ([Идентификатор арендатора])
			REFERENCES Арендаторы ([Идентификатор арендатора]),
	[Идентификатор риелтора]	int					not null
		CONSTRAINT FK3 FOREIGN KEY ([Идентификатор риелтора])
			REFERENCES Риелторы ([Идентификатор риелтора]),
	[Дата осмотра]			Date 	not null
)
