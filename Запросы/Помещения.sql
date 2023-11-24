CREATE TABLE Помещения
(	
	[Номер помещения]	tinyint	 IDENTITY(1,1) NOT NULL,
		Constraint PK1 primary key ([Номер помещения]),
	Этаж		tinyint,
	Площадь			DECIMAL(7,3),
	Отделка	varchar(50),
	Телефон		varchar(14) 
)
