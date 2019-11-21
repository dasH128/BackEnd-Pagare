using System;

namespace Finanzas.Entity
{
    public class HistorialLetra
    {
        public int Id {get; set;}

        public DateTime FechaCreacion {get; set;}
        public DateTime FechaGiro {get; set;}
        public DateTime FechaVencimiento {get; set;}
        public DateTime FechaDescuento {get; set;}
        public float ValorNominal {get; set;}
        public float ValorNeto {get; set;}
        public float ValorEntregado {get; set;}
        public float ValorRecivido {get; set;}
        public float Descuento {get; set;}
        public float CostoGastoInicial {get; set;}
        public float CostoGastoFinal {get; set;}
        public float DiasDescontar {get; set;}
        public float Tea {get; set;}
        public float Tcea {get; set;}

        public int LetraId {get; set;}
        public Letra Letra {get; set;}
        public int MonedaId {get; set;}
        public Moneda Moneda {get; set;}

    }
}