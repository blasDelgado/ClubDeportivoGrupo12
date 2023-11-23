using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo
{
    public class Actividad
    {

        
        private string nombreActividad;
        private float precioActividad;
        private string frecuencia;


        //Constructor
        public Actividad( string nombreActividad, float precioActividad, string frecuencia)
        {
            
            this.nombreActividad = nombreActividad;
            this.precioActividad = precioActividad;
            this.frecuencia = frecuencia;
        }

        // Getter y Setter
             

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
}
