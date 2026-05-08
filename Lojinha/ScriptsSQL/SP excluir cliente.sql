use dblojinha;
go

create procedure [dbo].[exclui_cliente]
	@codigo int
AS
	delete from cliente where codigo = @codigo