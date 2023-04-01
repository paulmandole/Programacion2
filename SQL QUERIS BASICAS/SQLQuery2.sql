--Agregar un registro de un cliente
insert into Clientes (nombre,direccion) Values('Camila','Calle falsa 123'),('Nicolas','mitre 750')
insert into Clientes (nombre,direccion) Values('pablo','mexico 4100'),('pedro','sarmiento 520')
--Leer el nombre de un cliente
Select nombre from Clientes

--leer todos los datos de un cliente *representa todas las columnas
select * from Clientes order by id asc

--leer todas las columnas de un cliente por id
select * from Clientes where id = 1 or id = 2;

--Modificar un cliente por el id
update Clientes set nombre = 'Camila' where id = 2

--Modificar todos los clientes por nombre
update Clientes set	nombre = 'jorge' where nombre = 'jorgue'

--Eliminar por id siempre con where
Delete from Clientes where id = 1

--Eliminar Like(lo que empiese con pa y continue con cualquier cosa)
-- %o% que tenga una o
delete from Clientes  where nombre Like 'Pa%'

--Eliminar Like
-- _como segunda letra una (a) a partir de un caracter _ puede ser cualquier cosa
delete from Clientes  where nombre Like '_a%'


