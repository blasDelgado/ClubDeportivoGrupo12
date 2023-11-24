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

insert into cliente(CLIENTE_ID,nombre,apellido,fec_nacimiento,domicilio,email,telefono,dni,aptoFisicoVigente,carnet_ID) values
(default,'Leo','Messi',19880101,'Siempreviva 123','leo10@gmail.com','10101010',33495009,true,400);

create table actividad(
ACTIVIDAD_ID int auto_increment,
nombre varchar (40),
frecuencia varchar (40),
precio long,
constraint pk_actividadID primary key(ACTIVIDAD_ID)
);

insert into actividad(ACTIVIDAD_ID, nombre , frecuencia , precio) values (default , "membresia" , "mensual" , 50000),(default , "futbol" , "semanal" , 20000),(default , "handball" , "mensual" , 30000);


create table socio(
Socio_ID int auto_increment,
Cliente_ID int,
FechaAlta date,
constraint pk_socioID primary key(Socio_ID),
constraint fk_cliente_socio foreign key(Cliente_ID) references cliente(CLIENTE_ID)
);

-- Insertar un registro en la tabla "Socio" con el único cliente existente
insert into socio(Socio_ID, Cliente_ID, FechaAlta) values (default, 1, current_date);

CREATE TABLE cuota (
    Cuota_ID INT AUTO_INCREMENT,
    FechaPago DATE,
    FormaPago VARCHAR(40),
    TipoCuota VARCHAR(40),
    Importe DECIMAL(10, 2),
    FechaEmision DATE,
    FechaVencimiento DATE,
    Cliente_ID INT,
    CONSTRAINT pk_cuotaID PRIMARY KEY (Cuota_ID),
    CONSTRAINT fk_cliente_cuota FOREIGN KEY (Cliente_ID) REFERENCES cliente (CLIENTE_ID)
);