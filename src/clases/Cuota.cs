public class Cuota
{
    private long Cuota_id;
    private DateTime fechaDePago;
    private FormaDePagoEnum formaDePago;
    private TipoDeCuotaEnum cuota;
    private float importe;
    private DateTime fechaDeEmision;
    private DateTime fechaDeVencimiento;


    public void listarCuotasVencidas()
    {
        
    }


    // Constructor
    public Cuota(long cuota_id, DateTime fechaDePago, FormaDePagoEnum formaDePago, TipoDeCuotaEnum cuota, float importe, DateTime fechaDeEmision, DateTime fechaDeVencimiento)
    {
        Cuota_id = cuota_id;
        this.fechaDePago = fechaDePago;
        this.formaDePago = formaDePago;
        this.cuota = cuota;
        this.importe = importe;
        this.fechaDeEmision = fechaDeEmision;
        this.fechaDeVencimiento = fechaDeVencimiento;
    }

    //Getter y Setter
    public long getCuota_id()
    {
        return this.Cuota_id;
    }

    public void setCuota_id(long Cuota_id)
    {
        this.Cuota_id = Cuota_id;
    }

    public DateTime getFechaDePago()
    {
        return this.fechaDePago;
    }

    public void setFechaDePago(DateTime fechaDePago)
    {
        this.fechaDePago = fechaDePago;
    }

    public FormaDePagoEnum getFormaDePago()
    {
        return this.formaDePago;
    }

    public void setFormaDePago(FormaDePagoEnum formaDePago)
    {
        this.formaDePago = formaDePago;
    }

    public TipoDeCuotaEnum getCuota()
    {
        return this.cuota;
    }

    public void setCuota(TipoDeCuotaEnum cuota)
    {
        this.cuota = cuota;
    }

    public float getImporte()
    {
        return this.importe;
    }

    public void setImporte(float importe)
    {
        this.importe = importe;
    }

    public DateTime getFechaDeEmision()
    {
        return this.fechaDeEmision;
    }

    public void setFechaDeEmision(DateTime fechaDeEmision)
    {
        this.fechaDeEmision = fechaDeEmision;
    }

    public DateTime getFechaDeVencimiento()
    {
        return this.fechaDeVencimiento;
    }

    public void setFechaDeVencimiento(DateTime fechaDeVencimiento)
    {
        this.fechaDeVencimiento = fechaDeVencimiento;
    }


}