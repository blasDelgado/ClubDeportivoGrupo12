DELIMITER //
CREATE PROCEDURE GenerarCuota(
    IN pClienteID INT,
    IN pTipoCuota VARCHAR(40),
    IN pImporte DECIMAL(10, 2),
    IN pFechaEmision DATE,
    IN pFechaVencimiento DATE
)
BEGIN
    INSERT INTO cuota (Cliente_ID, TipoCuota, Importe, FechaEmision, FechaVencimiento)
    VALUES (pClienteID, pTipoCuota, pImporte, pFechaEmision, pFechaVencimiento);
END //
DELIMITER ;