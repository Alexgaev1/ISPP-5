CREATE DATABASE УП11_ИСПП5_Демешко_ЕО	
ON PRIMARY (
	 NAME=up11_demeshko_eo_data,  
	 FILENAME='c:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\up11_demeshko_eo_data.mdf', 
	 SIZE=100MB,  
	 MAXSIZE=200, 
	 FILEGROWTH=20)
LOG ON ( 
	 NAME=up11_demeshko_eo_log, 
	 FILENAME='c:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\up11_demeshko_eo_log.ldf',  
	 SIZE=100MB,  
	 MAXSIZE=200, 
	 FILEGROWTH=20)
