DELIMITER //
CREATE PROCEDURE AsociarCliente(
    IN pClienteID INT,
    IN pFechaAlta DATE
)
BEGIN
    INSERT INTO socio (Cliente_ID, FechaAlta)
    VALUES (pClienteID, pFechaAlta);
END //
DELIMITER ;