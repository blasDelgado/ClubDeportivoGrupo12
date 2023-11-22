drop database if exists ClubDeportivoGrupo12;
create database ClubDeportivoGrupo12;
use ClubDeportivoGrupo12;

create table roles(
RolUsu int,
NombreRol varchar(30),
constraint primary key(RolUsu)
);

insert into roles values
(001,'Administrador'),
(002,'Empleado');

create table usuario(
CodUsu int auto_increment,
NombreUsu varchar (20),
PassUsu varchar (15),
RolUsu int,
Activo boolean default true,
constraint pk_usuario primary key (CodUsu),
constraint fk_usuario foreign key(RolUsu) references roles(RolUsu)
);

insert into usuario(CodUsu,NombreUsu,PassUsu,RolUsu) values
(1,'adm','1234',001);

create table cliente(
CLIENTE_ID int auto_increment,
nombre varchar (40),
apellido varchar (40),
fec_nacimiento date,
domicilio varchar (40),
email varchar (40),
telefono varchar (20),
dni long,
aptoFisicoVigente bool,
carnet_ID int,
constraint pk_clienteID primary key(CLIENTE_ID)
);

create table actividad(
ACTIVIDAD_ID int auto_increment,
nombre varchar (40),
frecuencia varchar (40),
precio long,
constraint pk_actividadID primary key(ACTIVIDAD_ID)
);

insert into cliente(CLIENTE_ID,nombre,apellido,fec_nacimiento,domicilio,email,telefono,dni,aptoFisicoVigente,carnet_ID) values
(default,'Leo','Messi',19880101,'Siempreviva 123','leo10@gmail.com','10101010',33495009,true,400);

insert into actividad(ACTIVIDAD_ID, nombre , frecuencia , precio) values (default , "futbol" , "semanal" , 20000),(default , "handball" , "mensual" , 30000);
