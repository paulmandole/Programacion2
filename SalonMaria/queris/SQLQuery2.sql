CREATE TABLE clientes(
 	id int IDENTITY(10000,1) PRIMARY KEY not null,
    nombre varchar(255) not null,
	apellido varchar(255) not null,
	email varchar(255) not null,
	telefono varchar(255) not null,
    fecha date not null
);

select * from clientes;

insert into clientes (nombre,apellido,email,telefono,fecha) values ('paul','mandole','paulmandole@gmail.com','1140412028','09/05/2025');
insert into clientes (nombre,apellido,email,telefono,fecha) values ('rene','albarez','renealbarez@gmail.com','1131474188','11/24/2028');
insert into clientes (nombre,apellido,email,telefono,fecha) values ('mario','renzare','mario@gmail.com','1145656868','01/05/2024');

drop table clientes