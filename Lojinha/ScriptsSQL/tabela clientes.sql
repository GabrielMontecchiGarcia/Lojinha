use dblojinha;

create table cliente (
[codigo] [int] identity(1,1) not null,
	nome varchar(100),
	email varchar(100),
	telefone varchar(20),
constraint [pk_clientes] primary key clustered
(
	[codigo]
	) on [primary], 
) on [primary]
go

insert into cliente(nome,email,telefone) values ('michael jackson', 'michael@gmail.com','+55 (69) 92347-0987')

select * from cliente