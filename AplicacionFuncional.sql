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
C�digo bigint not null,
Descripci�n varchar(30) not null,
Precio float not null,
Unidades bigint not null,
PRIMARY KEY(C�digo)
)

select * from Productos