DELIMITER //
CREATE PROCEDURE ObtenerCuotasPendientes (IN pClienteID INT)
BEGIN
    SELECT Cuota_ID, FechaPago, FormaPago, TipoCuota, Importe, FechaEmision, FechaVencimiento
    FROM cuota
    WHERE Cliente_ID = pClienteID
        AND FechaPago IS NULL;
END //
DELIMITER ;
