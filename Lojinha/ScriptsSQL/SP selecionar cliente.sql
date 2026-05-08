use dblojinha;
go

create procedure [dbo].[seleciona_cliente]
	@filtro varchar(100) = null
AS
BEGIN
	IF @filtro is null
	select * from cliente
	where nome like '%' + @filtro + '%'
	or email like '%' + @filtro + '%'
	or telefone like '%' + @filtro + '%'
end