CREATE TABLE Арендаторы
(	
	[Идентификатор арендатора]		int  IDENTITY(1,1),
		Constraint PK2 primary key ([Идентификатор арендатора]),
	Фамилия	varchar(50),
	Имя		varchar(50),
	Отчество			varchar(50),
	Название	varchar(50),
	Телефон	char(11) 	not null,
	Руководитель varchar(50),
	ИНН int,
	[Юридический адрес] varchar(100) not null,
	Банк varchar(50),
	[Тип арендатора] varchar(25) not null
)
