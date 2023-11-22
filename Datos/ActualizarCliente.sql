DELIMITER //
CREATE PROCEDURE ActualizarCliente(
    IN pDni INT,
    IN pDomicilio VARCHAR(40),
    IN pEmail VARCHAR(40),
    IN pTelefono VARCHAR(20)
)
BEGIN
    UPDATE Cliente
    SET Domicilio = pDomicilio, Email = pEmail, Telefono = pTelefono
    WHERE Dni = pDni;
END //
DELIMITER ;