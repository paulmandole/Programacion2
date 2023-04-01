create table Productos(
	idProducto int IDENTITY(10000,1) PRIMARY KEY not null,
	cantidad int default 0,
	nombre varchar(255) not null,
);

select * from Productos

insert into Productos (cantidad,nombre) values (10,'copas');
insert into Productos (cantidad,nombre) values (15,'manteles');
insert into Productos (cantidad,nombre) values (5,'vinos');

