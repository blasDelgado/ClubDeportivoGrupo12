public class ActividadCliente
{
    private Actividad actividad;
    private NoSocio cliente;
    private DateTime vigenciaActividad;

    //Constructor
    public ActividadCliente(Actividad actividad, NoSocio cliente, DateTime vigenciaActividad)
    {
        this.actividad = actividad;
        this.cliente = cliente;
        this.vigenciaActividad = vigenciaActividad;
    }
    //Getter y Setter

    public Actividad getActividad()
    {
        return this.actividad;
    }

    public void setActividad(Actividad actividad)
    {
        this.actividad = actividad;
    }

    public NoSocio getCliente()
    {
        return this.cliente;
    }

    public void setCliente(NoSocio cliente)
    {
        this.cliente = cliente;
    }

    public DateTime getVigenciaActividad()
    {
        return this.vigenciaActividad;
    }

    public void setVigenciaActividad(DateTime vigenciaActividad)
    {
        this.vigenciaActividad = vigenciaActividad;
    }

}