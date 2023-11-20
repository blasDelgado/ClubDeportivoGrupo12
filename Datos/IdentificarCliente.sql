delimiter // 
/* creacion del procedimiento almacenado para verificar si existe cliente */ 
drop procedure if exists IdentificarCliente //
create procedure IdentificarCliente(
	in clienteDni long, 
    out cCLIENTE_ID int,
    out cNombre varchar (40),
    out cApellido varchar (40),
    out cFec_nacimiento date,
    out cDomicilio varchar (40),
	out cEmail varchar (40),
	out cTelefono varchar (20),
	out cDni long,
	out cAptoFisicoVigente bool,
	out cCarnet_ID int
)
begin  
	SET cCLIENTE_ID = (select CLIENTE_ID from cliente where dni = clienteDni);
	SET cNombre = (select nombre from cliente where dni = clienteDni);
	SET cApellido = (select apellido from cliente where dni = clienteDni);
    SET cFec_nacimiento = (select fec_nacimiento from cliente where dni = clienteDni);
	SET cDomicilio = (select domicilio from cliente where dni = clienteDni);
	SET cEmail = (select email from cliente where dni = clienteDni);
	SET cTelefono = (select telefono from cliente where dni = clienteDni);
	SET cDni = (select dni from cliente where dni = clienteDni);
	SET cAptoFisicoVigente = (select aptoFisicoVigente from cliente where dni = clienteDni);
	SET cCarnet_ID = (select carnet_ID from cliente where dni = clienteDni);

end 
//

/*prueba */
/*
call IdentificarCliente(33495009, @clienteNombre, @clienteApellido) //
SELECT @clienteNombre as 'Nombre del Cliente', @clienteApellido as 'Apellido del Cliente' //
*/

call IdentificarCliente(33495009, 
    @cCLIENTE_ID,
    @cNombre,
    @cApellido,
    @cFec_nacimiento,
    @cDomicilio,
	@cEmail,
	@cTelefono,
	@cDni ,
	@cAptoFisicoVigente ,
	@cCarnet_ID 
) //
SELECT   @cCLIENTE_ID,
    @cNombre,
    @cApellido,
    @cFec_nacimiento,
    @cDomicilio,
	@cEmail,
	@cTelefono,
	@cDni ,
	@cAptoFisicoVigente ,
	@cCarnet_ID  //
