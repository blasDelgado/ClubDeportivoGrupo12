public class Actividad
{

    private long Actividad_ID;
    private string nombreActividad;
    private float precioActividad;
    private string frecuencia;


    //Constructor
    public Actividad(long actividad_ID, string nombreActividad, float precioActividad, string frecuencia)
    {
        Actividad_ID = actividad_ID;
        this.nombreActividad = nombreActividad;
        this.precioActividad = precioActividad;
        this.frecuencia = frecuencia;
    }

    // Getter y Setter
    public long getActividad_ID()
    {
        return this.Actividad_ID;
    }

    public void setActividad_ID(long Actividad_ID)
    {
        this.Actividad_ID = Actividad_ID;
    }

    public string getNombreActividad()
    {
        return this.nombreActividad;
    }

    public void setNombreActividad(string nombreActividad)
    {
        this.nombreActividad = nombreActividad;
    }

    public float getPrecioActividad()
    {
        return this.precioActividad;
    }

    public void setPrecioActividad(float precioActividad)
    {
        this.precioActividad = precioActividad;
    }

    public string getFrecuencia()
    {
        return this.frecuencia;
    }

    public void setFrecuencia(string frecuencia)
    {
        this.frecuencia = frecuencia;
    }



}