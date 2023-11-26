DELIMITER //

CREATE PROCEDURE PagarCuotas(IN pCuotaIDs VARCHAR(255), IN pFormaPago VARCHAR(255), IN pFechaPago DATE)
BEGIN
    UPDATE Cuota
    SET FormaPago = pFormaPago,
        FechaPago = pFechaPago
    WHERE FIND_IN_SET(Cuota_ID, pCuotaIDs) > 0;

END //

DELIMITER ;
