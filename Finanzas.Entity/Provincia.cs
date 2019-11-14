namespace Finanzas.Entity
{
    public class Provincia
    {
        public int Id {get; set;}
        public string Nombre {get; set;}

        public int DepartamentoId {get; set;}
        public Departamento Departamento {get; set;}
    }
}