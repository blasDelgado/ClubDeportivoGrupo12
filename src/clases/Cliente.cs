





    public class Cliente
    {
        private long CLIENTE_ID;
        private string nombre;
        private string apellido;
        private DateTime fec_nacimiento;
        private string domicilio;
        private string email;
        private string telefono;
        private long dni;
        private Boolean aptoFisicoVigente;
        private int carnet_ID;


        //Metodos

        public Boolean identificarCliente(long dni)
        {
            return false;
        }




        //Constructor

        public Cliente(string nombre, string apellido, DateTime fec_nacimiento, string domicilio, string email, string telefono, long dni, Boolean aptoFisicoVigente, int carnet_ID)
        {



            this.nombre = nombre;
            this.apellido = apellido;
            this.fec_nacimiento = fec_nacimiento;
            this.domicilio = domicilio;
            this.email = email;
            this.telefono = telefono;
            this.dni = dni;
            this.aptoFisicoVigente = aptoFisicoVigente;
            this.carnet_ID = carnet_ID;


        }



        // Getters and setters
        public long getCLIENTE_ID()
        {
            return this.CLIENTE_ID;
        }

        public void setCLIENTE_ID(long CLIENTE_ID)
        {
            this.CLIENTE_ID = CLIENTE_ID;
        }

        public string getNombre()
        {
            return this.nombre;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string getApellido()
        {
            return this.apellido;
        }

        public void setApellido(string apellido)
        {
            this.apellido = apellido;
        }

        public DateTime getFec_nacimiento()
        {
            return this.fec_nacimiento;
        }

        public void setFec_nacimiento(DateTime fec_nacimiento)
        {
            this.fec_nacimiento = fec_nacimiento;
        }

        public string getDomicilio()
        {
            return this.domicilio;
        }

        public void setDomicilio(string domicilio)
        {
            this.domicilio = domicilio;
        }

        public string getEmail()
        {
            return this.email;
        }

        public void setEmail(string email)
        {
            this.email = email;
        }

        public string getTelefono()
        {
            return this.telefono;
        }

        public void setTelefono(string telefono)
        {
            this.telefono = telefono;
        }

        public long getDni()
        {
            return this.dni;
        }

        public void setDni(long dni)
        {
            this.dni = dni;
        }

        public Boolean getAptoFisicoVigente()
        {
            return this.aptoFisicoVigente;
        }

        public void setAptoFisicoVigente(Boolean aptoFisicoVigente)
        {
            this.aptoFisicoVigente = aptoFisicoVigente;
        }

        public int getCarnet_ID()
        {
            return this.carnet_ID;
        }

        public void setCarnet_ID(int carnet_ID)
        {
            this.carnet_ID = carnet_ID;
        }



    }

