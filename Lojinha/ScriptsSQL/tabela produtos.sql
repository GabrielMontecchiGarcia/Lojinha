create table produtos (
[codigo] [int] identity(1,1) not null,
	nome varchar(100),
	preco decimal (10,2),
	 estoque int,
constraint [pk_produtos] primary key clustered
(
	[codigo]
	) on [primary], 
) on [primary]
go

insert into produtos (nome, preco, estoque) values ('computador gaymer', 15000.00, 15);
insert into produtos (nome, preco, estoque) values ('impressora 3D', 5000.00, 10);

select * from produtos