create database BD_CD_Ejemplo1
use BD_CD_Ejemplo1

create table empleado
(
cedula varchar (20) primary key,
nombre varchar (30),
apellido varchar (30),
telefono varchar (20),
salario decimal (10,2)
)

--procedimiento para listar registros
create procedure SP_LISTAR
as
begin
select * from empleado
end
execute SP_LISTAR

--procedimiento para seleccionar un registro
create procedure SP_SELECCIONAR
as
begin
select '0' as cedula, 'Seleccione un empleado' as nombre
union
select cedula, nombre from empleado
end

--procedimiento para insertar registro
create procedure SP_INSERTAR
@cedula varchar (20),
@nombre varchar (30),
@apellido varchar (30),
@telefono varchar (20),
@salario decimal (10,2)
as
begin
	insert into empleado (cedula,nombre,apellido,telefono,salario) values
	(@cedula,@nombre,@apellido,@telefono,@salario)
end
execute SP_INSERTAR '1000755422','Juan','Gonzales','4576523', 2.000000

--procedimiento para actualizar un registro
create procedure SP_ACTUALIZAR
@cedula varchar (20),
@nombre varchar (30),
@apellido varchar (30),
@telefono varchar (20),
@salario decimal (10,2)
as
begin
	Update empleado set nombre = @nombre, apellido = @apellido, telefono = @telefono, salario = @salario
	where cedula = @cedula 
end
execute SP_ACTUALIZAR '1000755422','Jose','Quintero','4511521', 1.000000

--procedimiento para eliminar un registro en especifico
create procedure SP_BORRAR
@cedula varchar (20)
as
begin
	delete empleado where cedula=@cedula
end 
execute SP_BORRAR '1000755422'

--procedimiento para consultar un registro es especifico
create procedure SP_CONSULTAR
@cedula varchar (20)
as
begin
	select * from empleado where cedula=@cedula
end
execute SP_CONSULTAR '1000755422'

