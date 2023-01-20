--create database stand_rsi_lab;
use stand_rsi_lab;
create table clientes(
	idcli int identity,
	nome nvarchar(50)not null,
	datanasc date default '2000-01-01',
	idade as datediff(day,datanasc,getdate()................),
	.......................
)
select * from clientes;
insert into clientes(nome, datanasc, tipo)values
	('Pato Donald','1964-02-01','Bravo'),
	('Tio Patinhas','1984-02-01','Alpha'),
	('Pateta','1904-02-01','Bravo'),
	('Margarida','2000-02-01','Charlie'),
	('Mikey','1969-02-01','Bravo');
