namespace Finanzas.Entity
{
    public class GiradoEmpresa
    {
        public int Id {get; set;}

        public int GiradoId {get; set;}
        public Girado Girado {get; set;}
        
        public string RazonSocial {get; set; }
        public string Ruc {get; set; }
    }
}