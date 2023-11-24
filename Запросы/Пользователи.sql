CREATE TABLE Пользователи
(	[Код пользователя] int IDENTITY (1,1) NOT NULL,
		constraint PK6 primary key ([Код пользователя]),
	Фамилия	varchar(50),
	Имя		varchar(50),
	Отчество			varchar(50),
	Логин		varchar(16) not null,
	Пароль			varchar(16) not null,
	[Права доступа]	varchar(50) default 'Гость')