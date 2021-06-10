CREATE DATABASE AplicacionFuncional
USE AplicacionFuncional

CREATE TABLE InicioSesion(
Usuario varchar(20) not null,
Contrasena varchar(20) not null,
Correo varchar(40) not null,
PRIMARY KEY(Usuario)
)

select * from InicioSesion
delete from InicioSesion where Correo = 'r' 

CREATE TABLE Productos(
Código bigint not null,
Descripción varchar(30) not null,
Precio float not null,
Unidades bigint not null,
PRIMARY KEY(Código)
)

select * from Productos