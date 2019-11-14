namespace Finanzas.Entity
{
    public class Usuario
    {
        public int Id {get; set; }
        public string Clave {get; set; }
        public string RazonSocial {get; set;}
        public string Ruc {get; set; }
        public string Direccion {get; set; }
        public string Correo {get; set; }
        public string Telefono {get; set; }

        public int IdDistrito {get; set;}
        public Distrito Distrito {get; set;}
    }
}