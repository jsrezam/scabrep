using S.C.A.B.R.E.P.Entidades;
using Scabrep.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace S.C.A.B.R.E.P
{
    public partial class FrmReporteFactura : Form
    {
        private readonly int numeroFactura;

        public FrmReporteFactura(int numeroFactura)
        {
            InitializeComponent();
            this.numeroFactura = numeroFactura;
        }

        private void FrmReporteFactura_Load(object sender, EventArgs e)
        {
            using (var db = new DatabaseManager()) 
            {
                var cabeceraFactura = db.ConsultarCabeceraFactura(numeroFactura);
                var detalleFactura = db.ConsultarDetalleFactura(numeroFactura);                
                var facturaDetalles = new List<FacturaDetalles>();
                var facturaCabecera = new FacturaCabecera();

                foreach (DataRow row in cabeceraFactura.Rows)
                {
                    facturaCabecera.NombreCliente = row["Nombre"].ToString();
                    facturaCabecera.IdCliente = row["Identificacion"].ToString();
                    facturaCabecera.DireccionCliente = row["Direccion"].ToString();
                    facturaCabecera.EmailCliente = row["Email"].ToString();
                    facturaCabecera.CelularCliente = row["Celular"].ToString();
                    facturaCabecera.TelefonoCliente = row["Telefono"].ToString();
                    facturaCabecera.NumeroFactura = Convert.ToInt32(row["NumeroFactura"]);
                    facturaCabecera.FechaFactura = Convert.ToDateTime(row["FechaFactura"]);
                    facturaCabecera.SubtotalFactura = Convert.ToDouble(row["SubtotalFactura"]);
                    facturaCabecera.TotalFactura = Convert.ToDouble(row["TotalFactura"]);                    
                }                

                foreach (DataRow row in detalleFactura.Rows)
                {
                    facturaDetalles.Add(new FacturaDetalles
                    {
                        NombreProducto = row["NombreProducto"].ToString(),
                        CantidadProducto = Convert.ToInt32(row["CantidadProducto"]),
                        PrecioUnitarioProducto = Convert.ToDouble(row["PrecioUnitarioProducto"]),
                        PrecioConIVAProducto = Convert.ToDouble(row["PrecioConIVAProducto"]),
                        ImporteProducto = Convert.ToDouble(row["ImporteProducto"])
                    });
                }

                invoice1.SetDataSource(facturaDetalles);
                invoice1.SetParameterValue("pNombreCliente", facturaCabecera.NombreCliente);
                invoice1.SetParameterValue("pIdCliente", facturaCabecera.IdCliente);
                invoice1.SetParameterValue("pDireccion", facturaCabecera.DireccionCliente);
                invoice1.SetParameterValue("pEmail", facturaCabecera.EmailCliente);
                invoice1.SetParameterValue("pCelular", facturaCabecera.CelularCliente);
                invoice1.SetParameterValue("pTelefono", facturaCabecera.TelefonoCliente);
                invoice1.SetParameterValue("pNumeroFactura", facturaCabecera.NumeroFactura);
                invoice1.SetParameterValue("pFechaFactura", facturaCabecera.FechaFactura);
                invoice1.SetParameterValue("pSubTotal", facturaCabecera.SubtotalFactura);
                invoice1.SetParameterValue("pTotal", facturaCabecera.TotalFactura);

                crystalReportViewer1.ReportSource = invoice1;
            }
        }
    }
}
