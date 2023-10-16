

public class Socio : Cliente
{
    private List<Cuota> cuotas;
    private long numSocio;
    private Boolean socioActivo;

    public void inscribirse(Socio socio)
    {

    }

    public Boolean validarSocio(Socio socio)
    {
        return false;
    }

    public Boolean validarVencimiento(Cuota cuota)
    {
        return false;
    }
    public Boolean pagarSuscripcion(Socio socio, Cuota cuota , FormaDePagoEnum formaDePago)
    {
        return false;
    }

    public void solicitarCarnet(Socio socio)
    {
        
    }

    

    //Constructor
    public Socio(string nombre, string apellido, DateTime fec_nacimiento, string domicilio, string email, string telefono, long dni, bool aptoFisicoVigente, int carnet_ID, Boolean socioActivo, long numSocio , List<Cuota> cuotas) : base(nombre, apellido, fec_nacimiento, domicilio, email, telefono, dni, aptoFisicoVigente, carnet_ID)
    {
        this.cuotas = cuotas;
        this.socioActivo = socioActivo;
        this.numSocio = numSocio;
    }

    // Getters y Setters

    public List<Cuota> getCuotas()
    {
        return this.cuotas;
    }

    public void setCuotas(List<Cuota> cuotas)
    {
        this.cuotas = cuotas;
    }

    public long getNumSocio()
    {
        return this.numSocio;
    }

    public void setNumSocio(long numSocio)
    {
        this.numSocio = numSocio;
    }
}

