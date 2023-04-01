create table evento
(
	idEvento int IDENTITY(10000,1) PRIMARY KEY not null,
	idCliente int not null ,
	fechaEvento DateTime not null,
	listaProductos varchar()
)