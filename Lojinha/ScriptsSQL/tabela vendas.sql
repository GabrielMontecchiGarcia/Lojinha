create table vendas (
[codigo] [int] identity(1,1) not null,
	data datetime,
	quantidade int,
	 faturado bit,
	 codcliente int,
	 codproduto int,
constraint [pk_vendas] primary key clustered
(
	[codigo]
	) on [primary], constraint [fk_Codigo_Cliente] foreign key
	(
	[codcliente]
	)references [cliente] ( [codigo]
	),
constraint [fk_codigo_produto] foreign key
(
	[codproduto]
)references [produtos] ( 
	[codigo]
)
) on [primary] 
go