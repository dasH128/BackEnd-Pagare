using System;

namespace Finanzas.Entity
{
    public class Letra
    {
        public int Id {get; set; }
        public float valorNominal {get; set;}
        public DateTime fechaGiro {get; set;}
        public DateTime fechaVencimiento {get; set;}
        
        public int GiradoId {get; set; }
        public Girado Girado {get; set;}
        public int UsuarioId {get; set; }
        public Usuario Usuario {get; set;}
        public int MonedaId {get; set; }
        public Moneda Moneda {get; set;}
        public int DepartamentoId {get; set; }
        public Departamento Departamento {get; set;}
    }
}