CREATE TABLE Риелторы
(	
	[Идентификатор риелтора]	int		IDENTITY(1,1) NOT NULL,
		Constraint PK3 primary key ([Идентификатор риелтора]),
	Фамилия	varchar(50) not null,
	Имя		varchar(50) not null,
	Отчество varchar(50),
	Телефон	varchar(14) 	not null,
	ИНН int not null
)
