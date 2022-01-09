using System;

namespace S.C.A.B.R.E.P.Entidades
{
    public class FacturaCabecera
    {
        public string NombreCliente { get; set; }
        public string IdCliente { get; set; }
        public string DireccionCliente { get; set; }
        public string EmailCliente { get; set; }
        public string CelularCliente { get; set; }
        public string TelefonoCliente { get; set; }
        public int NumeroFactura { get; set; }
        public DateTime FechaFactura { get; set; }        
        public double SubtotalFactura { get; set; }
        public double TotalFactura { get; set; }
    }
}
