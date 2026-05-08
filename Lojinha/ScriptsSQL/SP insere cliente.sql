use dblojinha;
go

--if exists (select name from sysobjects where name = 'insere_cliente' and type = 'P')
--drop procedure insere_cliente

create procedure [dbo].[insere_cliente]
	@codigo int output,
	@nome varchar(100),
	@email varchar(100),
	@telefone varchar(20)
AS
	insert into cliente (nome, email, telefone)
	values(@nome, @email, @telefone)
set @codigo = (select @@IDENTITY)
