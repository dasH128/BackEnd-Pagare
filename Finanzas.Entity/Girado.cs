namespace Finanzas.Entity
{
    public class Girado
    {
        public int Id {get; set;}

        public string tipoCliente {get; set;}
        public string tipoDocumento {get; set;}
        public string Correo {get; set; }
        public string Telefono {get; set; }
        public string Domicilio {get; set; }

        public int DepartamentoId {get; set; }
        public Departamento Departamento {get; set;}
        // public int GiradoPersonaId {get; set;}
        // public GiradoPersona GiradoPersona {get; set;}
        // public int GiradoEmpresaId {get; set;}
        // public GiradoEmpresa GiradoEmpresa {get; set;}
    }
}