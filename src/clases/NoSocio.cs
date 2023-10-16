
public class NoSocio : Cliente
{
    private List<Cuota> cuotas;
    private List<Actividad> actividadesRealizadas;

    //Metodos 
    public void inscribirse(NoSocio noSocio)
    {

    }
    public void contratarActividad(NoSocio noSocio)
    {

    }

    public Boolean validarActividad(NoSocio noSocio , Actividad actividad )
    {
        return false;
    }

    public Boolean pagarActividad (NoSocio noSocio , Actividad actividad)
    {
        return false;
    }




    //Constructor

    public NoSocio(string nombre, string apellido, DateTime fec_nacimiento, string domicilio, string email, string telefono, long dni, bool aptoFisicoVigente, int carnet_ID) : base(nombre, apellido, fec_nacimiento, domicilio, email, telefono, dni, aptoFisicoVigente, carnet_ID)
    {
    }

    //Getter y Setter

    public List<Cuota> getCuotas()
    {
        return this.cuotas;
    }

    public void setCuotas(List<Cuota> cuotas)
    {
        this.cuotas = cuotas;
    }

    public List<Actividad> getActividadesRealizadas()
    {
        return this.actividadesRealizadas;
    }

    public void setActividadesRealizadas(List<Actividad> actividadesRealizadas)
    {
        this.actividadesRealizadas = actividadesRealizadas;
    }

}