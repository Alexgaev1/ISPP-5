CREATE DATABASE pawnshop
ON PRIMARY (
NAME= pawnshop,
FILENAME='\\sql\c$\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\pawnshop.mdf',
SIZE=100MB,MAXSIZE=200, FILEGROWTH=20
)
LOG ON (
NAME= pawnshop_log,
FILENAME='\\sql\c$\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\pawnshop.ldf',
SIZE=100MB,MAXSIZE=200,FILEGROWTH=20
)
