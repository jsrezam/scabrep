using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration.Assemblies;
using System.Configuration;
using System.Globalization;

namespace S.C.A.B.R.E.P
{
    public partial class FrmFactura : Form
    {
        Conexiones facuraConexion = new Conexiones();
        //Variables clientes
        public int IdFacturaCliente;
        public string cedulaFacturaCliente;
        public string rucFacturaCliente;
        public string nombreFacturaCliente;
        public string apellidoFacturaCliente;
        public string TelefonoCelularFacturaCliente;
        public string TelefonoFijoFacturaCliente;
        public string direccionFacturaCliente;
        public string mailFacturaCliente;
        //variables usuario
        public int IdFacturaUsuario;
        public string cedulaFacturaUsuario;
        public string nombreFacturaUsuario;
        public string apellidoFacturaUsuario;

        public string passwordFacturaUsuario;
        

        public FrmFactura(string nombreFacturaUsuario, string passwordFacturaUsuario)
        {
            InitializeComponent();
            this.nombreFacturaUsuario = nombreFacturaUsuario;
            this.passwordFacturaUsuario = passwordFacturaUsuario;
 
        }
        private void FrmFactura_Load(object sender, EventArgs e)
        {
            //DateTime dt = new DateTime();
            //this.dtpFechaFactura.Value = dt.Date;
            //this.dtpFechaFactura.Value.
            consultarNumeroFactura();
            txtIdUsuarioFactura.Text = "" + Convert.ToInt32(facuraConexion.consultar2("USUARIO", nombreFacturaUsuario, passwordFacturaUsuario).Rows[0][0]);
            txtNombreUsuarioFactura.Text = facuraConexion.consultar2("USUARIO", nombreFacturaUsuario, passwordFacturaUsuario).Rows[0][2].ToString() +" "+ facuraConexion.consultar2("USUARIO", nombreFacturaUsuario, passwordFacturaUsuario).Rows[0][3].ToString();
        }
        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            FrmBuscarCliente fbuscarCliente = new FrmBuscarCliente();
            DialogResult resp = fbuscarCliente.ShowDialog();
            if (resp == DialogResult.OK)
            {
                this.IdFacturaCliente = fbuscarCliente.Id;
                this.cedulaFacturaCliente=fbuscarCliente.cedulaCliente.Trim();
                this.rucFacturaCliente=fbuscarCliente.rucCliente.Trim();
                this.nombreFacturaCliente = fbuscarCliente.nombreCliente.Trim();
                this.apellidoFacturaCliente = fbuscarCliente.apellidoCliente.Trim(); 
                this.TelefonoCelularFacturaCliente = fbuscarCliente.telefonoCelularCliente.Trim();
                this.TelefonoFijoFacturaCliente = fbuscarCliente.telefonoFijoCliente.Trim();
                this.direccionFacturaCliente = fbuscarCliente.direccionCliente.Trim();
                this.mailFacturaCliente = fbuscarCliente.mailCliente.Trim();
                //Asignacion a los objetos textbox de las variales recojidas en la busqueda del cliente
                txtIdClienteFactura.Text = ""+IdFacturaCliente;
                txtNombreClienteFactura.Text = nombreFacturaCliente.Trim() + " " + apellidoFacturaCliente.Trim();
                txtDireccionClienteFactura.Text = direccionFacturaCliente.Trim();
                txtTelefonoClienteFactura.Text = TelefonoCelularFacturaCliente.Trim() + " / " + TelefonoFijoFacturaCliente.Trim();
                txtCedulaClienteFactura.Text = cedulaFacturaCliente.Trim();
                txtRucClienteFactura.Text = rucFacturaCliente.Trim();
            }
                       
        }
        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            FrmBuscarUsuario fbuscarUsuario = new FrmBuscarUsuario();
            DialogResult resp = fbuscarUsuario.ShowDialog();
            if (resp == DialogResult.OK)
            {
                this.IdFacturaUsuario = fbuscarUsuario.Id;
                this.cedulaFacturaUsuario = fbuscarUsuario.cedulaUsuario;
                this.nombreFacturaUsuario = fbuscarUsuario.nombreUsuario;
                this.apellidoFacturaUsuario = fbuscarUsuario.apellidoUsuario;
                //Asignacion a los objetos textbox de las variales recojidas en la busqueda del Usuario
                txtIdUsuarioFactura.Text = "" + IdFacturaUsuario;
                txtNombreUsuarioFactura.Text = nombreFacturaUsuario + " " + apellidoFacturaUsuario;
            }

        }
        private void dgvProductoFactura_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvProductoFactura.RowCount != 0)
            {
                txtMostrarCodigo.Text = dgvProductoFactura.CurrentRow.Cells[1].Value.ToString().Trim();
                txtMostrarDetalle.Text = dgvProductoFactura.CurrentRow.Cells[3].Value.ToString().Trim();
            }
        }
        private void btnAgregarModificarProductoFactura_Click(object sender, EventArgs e)
        {
            FrmProducto fbuscarProducto = new FrmProducto();
            for (int i = 0; i <= dgvProductoFactura.RowCount - 1; i++)
            {
                fbuscarProducto.dgvSeleccion.Rows.Add();
                for (int j = 0; j <= dgvProductoFactura.ColumnCount - 1; j++)
                {
                    fbuscarProducto.dgvSeleccion.Rows[i].Cells[j].Value = dgvProductoFactura.Rows[i].Cells[j].Value;
                }
            }
            DialogResult resp = fbuscarProducto.ShowDialog();
            if (resp == DialogResult.OK)
            {
                dgvProductoFactura.Rows.Clear();
                for (int i = 0; i <= fbuscarProducto.dgvSeleccion.RowCount - 1; i++)
                {
                    dgvProductoFactura.Rows.Add();
                    for (int j = 0; j <= fbuscarProducto.dgvSeleccion.ColumnCount - 1; j++)
                    {
                        dgvProductoFactura.Rows[i].Cells[j].Value = fbuscarProducto.dgvSeleccion.Rows[i].Cells[j].Value;
                    }
                }
            }
            else if (resp == DialogResult.Cancel)
            {
                fbuscarProducto.Close();   
            }
            calcular();
        }
        private void btnLimpiarProducto_Click(object sender, EventArgs e)
        {
            dgvProductoFactura.Rows.Clear();
            txtSubTotalDoce.Text = "";
            txtSubTotalCero.Text = "";
            txtDescuento.Text = "";
            txtSubTotal.Text = "";
            txtIVA.Text = "";
            txtValorTotal.Text = "";
            calcular();
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            calcular();
        }
        //calcula los detalle en la fatura
        public void calcular()
        {
            double sumaProducto = 0;
            double sumaEspecial = 0;
            double sumaTrabajo = 0;
            double subTotalDoce;
            double subTotalCero = 0;
            double Descuento = 0;
            double subTotal;
            double IVA;
            double valorTotal;
            //Verfica si todas los datagridViewEstan Vacios para realizar el calculo de la factura
            if (dgvProductoFactura.RowCount != 0)
            {

                if (dgvProductoFactura.RowCount != 0)
                {
                    for (int i = 0; i <= dgvProductoFactura.RowCount - 1; i++)
                    {
                        sumaProducto += Convert.ToDouble(dgvProductoFactura.Rows[i].Cells[6].Value);

                    }
                }
                subTotalDoce = Math.Round(sumaProducto + sumaEspecial + sumaTrabajo, 2);
                txtSubTotalDoce.Text = "" + subTotalDoce;
                txtSubTotalCero.Text = "" + subTotalCero;
                txtDescuento.Text = "" + Descuento;
                subTotal = subTotalDoce;
                txtSubTotal.Text = "" + subTotal;

                string sep = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;



                //IVA = Math.Round((subTotal * 0.12), 2);
                var ivaParm = Convert.ToDouble(ConfigurationManager.AppSettings["IVA"]);
                IVA = Math.Round((subTotal * ivaParm), 2);
                                   
                
                txtIVA.Text = "" + IVA;
                valorTotal = Math.Round(subTotal + IVA, 2);
                txtValorTotal.Text = "" + valorTotal;
            }
            else
            {
                MessageBox.Show("Debe Ingresar detalles", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }           
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Conexiones conexionDetalleProducto = new Conexiones();
            if (MessageBox.Show("¿Esta Seguro de Guardar la Factura?", "Guardar Factura", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //comprueba si ha ingresado Cliente y Usuario
                if (ComprobarClienteUsuario() )
                {
                    //comprueba si existe valores en la factura
                    if (ComprobarValorfinal())
                    {
                        //Guarda el detalle cuando tienen datos todos los datagridview 
                        if (dgvProductoFactura.RowCount != 0 )
                        {
                            if (dgvNumeroFactura.RowCount == 0)
                            {
                                for (int i = 0; i <= dgvProductoFactura.RowCount - 1; i++)
                                {
                                    conexionDetalleProducto.ingresoDetalleProducto(Convert.ToInt32(dgvProductoFactura.Rows[i].Cells[0].Value), 1, Convert.ToInt32(dgvProductoFactura.Rows[i].Cells[2].Value), Convert.ToDouble(dgvProductoFactura.Rows[i].Cells[4].Value), Convert.ToDouble(dgvProductoFactura.Rows[i].Cells[6].Value));
                                }
                                IngresarFactura();
                                MessageBox.Show("Factura Guardada Satisfactoriamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                btnBuscarCliente.Enabled = false;
                                btnAgregarModificarProductoFactura.Enabled = false;
                                btnLimpiarProducto.Enabled = false;
                                btnGuardar.Enabled = false;
                                btnNueva.Enabled = true;
                                btnImprimirFactura.Enabled = true;
                                

                            }
                            else 
                            {
                                for (int i = 0; i <= dgvProductoFactura.RowCount - 1; i++)
                                {
                                    conexionDetalleProducto.ingresoDetalleProducto(Convert.ToInt32(dgvProductoFactura.Rows[i].Cells[0].Value), Convert.ToInt32(dgvNumeroFactura.Rows[0].Cells[0].Value), Convert.ToInt32(dgvProductoFactura.Rows[i].Cells[2].Value), Convert.ToDouble(dgvProductoFactura.Rows[i].Cells[4].Value), Convert.ToDouble(dgvProductoFactura.Rows[i].Cells[6].Value));
                                }
                                IngresarFactura();
                                MessageBox.Show("Factura Guardada Satisfactoriamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                btnBuscarCliente.Enabled = false;
                                btnAgregarModificarProductoFactura.Enabled = false;
                                btnLimpiarProducto.Enabled = false;
                                btnGuardar.Enabled = false;
                                btnNueva.Enabled = true;
                                btnImprimirFactura.Enabled = true;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Debe Ingresar detalles", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else 
                    {
                        MessageBox.Show("No existen Valores a Calcular,Por favor verifique", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);    
                    }
                }
                else 
                {
                    MessageBox.Show("Falta determinar valores estos pueden ser:\nCliente,Usuario ó falta Calcular los Delalles de la factura.Por favor verifique","Atencion",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
                
            }

        }
        //METODO DEDICADO AL INGRESO DE LOS DATOS QUE NECESITA LA TABLA FACTURA
        public void IngresarFactura()
        {
            Conexiones conexionFactura = new Conexiones();
            if (dgvNumeroFactura.RowCount == 0)
            {
                conexionFactura.ingresoFactura(1,Convert.ToInt32(txtIdClienteFactura.Text.Trim()), Convert.ToInt32(txtIdUsuarioFactura.Text.Trim()), dtpFechaFactura.Value, Convert.ToDouble(txtSubTotalDoce.Text.Trim()), Convert.ToDouble(txtSubTotalCero.Text.Trim()), Convert.ToDouble(txtDescuento.Text.Trim()), Convert.ToDouble(txtSubTotal.Text.Trim()), Convert.ToDouble(txtIVA.Text.Trim()), Convert.ToDouble(txtValorTotal.Text.Trim()),"ACTIVA");
            }
            else 
            {
                conexionFactura.ingresoFactura(Convert.ToInt32(dgvNumeroFactura.Rows[0].Cells[0].Value), Convert.ToInt32(txtIdClienteFactura.Text.Trim()), Convert.ToInt32(txtIdUsuarioFactura.Text.Trim()), dtpFechaFactura.Value, Convert.ToDouble(txtSubTotalDoce.Text.Trim()), Convert.ToDouble(txtSubTotalCero.Text.Trim()), Convert.ToDouble(txtDescuento.Text.Trim()), Convert.ToDouble(txtSubTotal.Text.Trim()), Convert.ToDouble(txtIVA.Text.Trim()), Convert.ToDouble(txtValorTotal.Text.Trim()), "ACTIVA"); 
            }
        }
        //METOD QUE VERIFICA SI SE HAN REALIZADO LOS CALCULOS 
        bool ComprobarValorfinal() 
        {
            bool res=true;
            if (txtValorTotal.Text=="")
            {
                res = false;
            }
            return res;
        }
        //METODO QUE VERIFICA SI SE HA INGRESADO EL CLIENTE Y EL USUARIO
        bool ComprobarClienteUsuario() 
        {
            bool res=true;
            if (txtIdClienteFactura.Text == "")
            {
                res = false;
            }
            else if (txtIdUsuarioFactura.Text == "")
            {
                res = false;
            }
            else
            {
                res = true;
            }
            return res;
        }
        //funcion que limpia todo el formulario factura
        private void limpiar()
        {
            //text box Cliente
            txtIdClienteFactura.Text = "";
            txtNombreClienteFactura.Text = "";
            txtDireccionClienteFactura.Text = "";
            txtTelefonoClienteFactura.Text = "";
            txtCedulaClienteFactura.Text = "";
            txtRucClienteFactura.Text = "";
            //text box Usuario
            //txtIdUsuarioFactura.Text = "";
            //txtNombreUsuarioFactura.Text = ""; 
            //txt box factura
            txtSubTotalDoce.Text = "";
            txtSubTotalCero.Text = "";
            txtDescuento.Text = "";
            txtSubTotal.Text = "";
            txtIVA.Text = "";
            txtValorTotal.Text = "";
            //datagridview
            dgvProductoFactura.Rows.Clear();
        }
        //consulta el proximo numero de factura
        public void consultarNumeroFactura()
        {
            facuraConexion.consultar("Select TOP 1 SUM(NUMERO_FACTURA)+1 AS NUMERO_FACTURA from FACTURA GROUP BY NUMERO_FACTURA ORDER BY NUMERO_FACTURA DESC", "FACTURA");
            this.dgvNumeroFactura.DataSource = facuraConexion.dataset.Tables["FACTURA"];
        }

        private void btnImprimirFactura_Click(object sender, EventArgs e)
        {
            //Conexiones reporte = new Conexiones();
            string sql;
            if (dgvNumeroFactura.RowCount == 0)
            {
                sql = "select * from FACTURA A INNER JOIN CLIENTE B ON A.ID_CLIENTE=B.ID_CLIENTE WHERE A.NUMERO_FACTURA =" + 1 + ";" + "select * from DETALLE_FACTURA_PRODUCTO A inner join PRODUCTO B on B.ID_PRODUCTO=A.ID_PRODUCTO where a.NUMERO_FACTURA=" + 1 + ";";
            }
            else 
            {
                sql = "select * from FACTURA A INNER JOIN CLIENTE B ON A.ID_CLIENTE=B.ID_CLIENTE WHERE A.NUMERO_FACTURA =" + dgvNumeroFactura.Rows[0].Cells[0].Value.ToString().Trim() + ";" + "select * from DETALLE_FACTURA_PRODUCTO A inner join PRODUCTO B on B.ID_PRODUCTO=A.ID_PRODUCTO where a.NUMERO_FACTURA=" + dgvNumeroFactura.Rows[0].Cells[0].Value.ToString().Trim() + ";";
            }
            if (facuraConexion.consultarFactura(sql))
            {
                if (facuraConexion.dataset.Tables["FACTURA"].Rows.Count == 0)
                {
                    MessageBox.Show("No se encontro ningun registro");
                }
                else
                {
                    MessageBox.Show("Generado Vista preliminar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    System.IO.Directory.CreateDirectory(@"C:\XML");
                    string url = @"C:\XML\FACTURA.xml";
                    facuraConexion.dataset.WriteXml(url, XmlWriteMode.WriteSchema);
                    //FrmReporte fReporte = new FrmReporte();
                    //fReporte.ShowDialog();
                }
            }
            btnImprimirFactura.Enabled = false;
            //btnNueva.Enabled = true;
            //System.IO.Directory.Delete(@"C:\XML");
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            limpiar();
            consultarNumeroFactura();
            btnBuscarCliente.Enabled = true;
            //btnBuscarUsuario.Enabled = true;
            btnAgregarModificarProductoFactura.Enabled = true;
            btnLimpiarProducto.Enabled = true;
            btnGuardar.Enabled = true;
            btnImprimirFactura.Enabled = false;
            btnNueva.Enabled = false;

        }

        private void dgvProductoFactura_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            calcular();
        }

    }
}
