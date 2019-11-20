namespace Finanzas.Entity
{
    public class GiradoPersona
    {
        public int Id {get; set;}

        public int GiradoId {get; set;}
        public Girado Girado {get; set;}
        
        public string Nombre {get; set; }
        public string apellidoPaterno {get; set;}
        public string apellidoMaterno {get; set;}
        public string Dni {get; set; }
    }
}