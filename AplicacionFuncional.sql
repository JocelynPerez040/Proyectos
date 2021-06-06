CREATE DATABASE AplicacionFuncional
USE AplicacionFuncional

CREATE TABLE InicioSesion(
Usuario varchar(20) not null,
Contrasena varchar(20) not null,
Correo varchar(40) not null,
PRIMARY KEY(Usuario)
)

select * from InicioSesion
delete from InicioSesion where Usuario = 'v' 