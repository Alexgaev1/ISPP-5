CREATE TABLE Редакторы
(	
	Код_Редактора	int	 NOT NULL,
		Constraint PK1 primary key (Код_Редактора),
	Фамилия		varchar(50) not null,
	Имя			varchar(50) not null,
	Отчество	varchar(50),
	Телефон		char(11) not null
)

CREATE TABLE Газеты
(	
	Код_Газеты		int  IDENTITY(1,1) NOT NULL,
		Constraint PK2 primary key (Код_Газеты),
	Индекс_издания	varchar(20)		NOT NULL,
	Название		CHAR(50)		NOT NULL,
	Цена			MONEY			NOT NULL,
	Дата_выпуска	Date 			not null,
	Код_Редактора	int				not null
		CONSTRAINT FK1 FOREIGN KEY (Код_Редактора)
			REFERENCES Редакторы (Код_Редактора)
)

CREATE TABLE Типографии
(	
	Код_Типографии	int		IDENTITY(1,1) NOT NULL,
		Constraint PK3 primary key (Код_Типографии),
	Название		CHAR(50)			NOT NULL,
	Адрес			varchar(80)			NOT NULL,
	Режим_работы	CHAR(7)				not null
)

CREATE TABLE Архив
(	
	Код_Архива		int		IDENTITY(1,1) NOT NULL,
		Constraint PK4 primary key (Код_Архива),
	Код_Газеты		int					not null
		CONSTRAINT FK2 FOREIGN KEY (Код_Газеты)
			REFERENCES Газеты (Код_Газеты),
	Код_Типографии	int					not null
		CONSTRAINT FK3 FOREIGN KEY (Код_Типографии)
			REFERENCES Типографии (Код_Типографии),
	Тираж			int 				not null
)

CREATE TABLE [Почтовые отделения]
(	
	Индекс_почты	int	 NOT NULL,
		Constraint PK5 primary key (Индекс_почты),
	Адрес		varchar(80)		NOT NULL,
	Телефон		char(11) not null
)

CREATE TABLE Отслеживание
(	
	Код_Записи		int		IDENTITY(1,1) NOT NULL,
		Constraint PK6 primary key (Код_Записи),
	Код_Архива		int		NOT NULL
		CONSTRAINT FK4 FOREIGN KEY (Код_Архива)
			REFERENCES Архив (Код_Архива),
	Индекс_почты	int,
		CONSTRAINT FK5 FOREIGN KEY (Индекс_почты)
			REFERENCES [Почтовые отделения] (Индекс_почты),
	Количество		int 	not null,
	Дата_продажи	Date 	not null
)