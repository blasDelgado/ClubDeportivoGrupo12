delimiter // 

drop procedure if exists GuardarNuevoCliente //
create procedure GuardarNuevoCliente(
    in pNombre varchar(40),
    in pApellido varchar(40),
    in pFec_nacimiento date,
    in pDomicilio varchar(40),
    in pEmail varchar(40),
    in pTelefono varchar(20),
    in pDni bigint,
    in pAptoFisicoVigente bool,
    in pCarnet_ID int
)
begin  
    insert into cliente (
        nombre,
        apellido,
        fec_nacimiento,
        domicilio,
        email,
        telefono,
        dni,
        aptoFisicoVigente,
        carnet_ID
    ) values (
        pNombre,
        pApellido,
        pFec_nacimiento,
        pDomicilio,
        pEmail,
        pTelefono,
        pDni,
        pAptoFisicoVigente,
        pCarnet_ID
    );
end 
//
