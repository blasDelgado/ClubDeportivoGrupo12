using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Entidades
{
    public class E_Cliente
    {
        public int ClienteID { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? FecNacimiento { get; set; }
        public string? Domicilio { get; set; }
        public string? Email { get; set; }
        public string? Telefono { get; set; }
        public long Dni { get; set; }
        public bool AptoFisicoVigente { get; set; }
        public int CarnetID { get; set; }
    }
}
