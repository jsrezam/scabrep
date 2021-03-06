using System;
using System.Data;
using System.Windows.Forms;

namespace S.C.A.B.R.E.P
{
    public partial class FrmConsultasFactura : Form
    {
        public FrmConsultasFactura()
        {
            InitializeComponent();
        }

        Conexiones obconexionesEliminar = new Conexiones();
        FrmClienteIngresar fbiCliente = new FrmClienteIngresar();
        FrmClienteActualizar fbaCliente = new FrmClienteActualizar();
        Conexiones facuraDetallesConexion = new Conexiones();
        int condicionVerificarIngresoEliminar;
        public int Id = 0;
        public int numeroFactura=0;
        int ayudanteAnularIndice = 0;
        string ayudanteFechaInicial;
        string ayudanteFechaFinal;
        bool esFechaActualInicio = true;
        bool esFechaActualFinal = true;

        private void rBtnCedula_CheckedChanged(object sender, EventArgs e)
        {
            txtCedulaCliente.Enabled = true;
            txtRucCliente.Enabled = false;
            txtRucCliente.Text = string.Empty;
            txtNombreCliente.Enabled = false;
            txtNombreCliente.Text = string.Empty;
            txtNumFactura.Enabled = false;
            txtNumFactura.Text = string.Empty;

            lblAvisoNombre.Visible = false;
            this.gbFechas.Enabled = false;
            condicionVerificarIngresoEliminar = 1;
        }

        private void rBtnRuc_CheckedChanged(object sender, EventArgs e)
        {
            txtCedulaCliente.Enabled = false;
            txtCedulaCliente.Text = string.Empty;
            txtRucCliente.Enabled = true;
            txtRucCliente.Text = string.Empty;
            txtNombreCliente.Enabled = false;
            txtNombreCliente.Text = string.Empty;
            txtNumFactura.Enabled = false;
            txtNumFactura.Text = string.Empty;
            lblAvisoNombre.Visible = false;
            this.gbFechas.Enabled = false;
            condicionVerificarIngresoEliminar = 2;
        }

        private void rBtnNombre_CheckedChanged(object sender, EventArgs e)
        {
            txtNombreCliente.Enabled = true;
            txtCedulaCliente.Enabled = false;
            txtCedulaCliente.Text = string.Empty;
            txtRucCliente.Enabled = false;
            txtRucCliente.Text = string.Empty;
            txtNumFactura.Enabled = false;
            txtNumFactura.Text = string.Empty;

            lblAvisoNombre.Visible = true;
            this.gbFechas.Enabled = false;
            condicionVerificarIngresoEliminar = 3;
        }

        private void rbtnNumeroFactura_CheckedChanged(object sender, EventArgs e)
        {
            txtNumFactura.Enabled = true;
            txtNumFactura.Text = string.Empty;
            txtCedulaCliente.Text = string.Empty;
            txtRucCliente.Text = string.Empty;
            txtNombreCliente.Text = string.Empty;
            txtCedulaCliente.Enabled = false;
            txtRucCliente.Enabled = false;
            txtNombreCliente.Enabled = false;
            lblAvisoNombre.Visible = false;
            this.gbFechas.Enabled = false;
            condicionVerificarIngresoEliminar = 4;
        }

        private void rBtnFechas_CheckedChanged(object sender, EventArgs e)
        {
            this.gbFechas.Enabled = true;

            txtNumFactura.Text = string.Empty;
            txtCedulaCliente.Text = string.Empty;
            txtRucCliente.Text = string.Empty;
            txtNombreCliente.Text = string.Empty;
            txtNumFactura.Enabled = false;
            txtCedulaCliente.Enabled = false;
            txtRucCliente.Enabled = false;
            txtNombreCliente.Enabled = false;
            lblAvisoNombre.Visible = false;
            condicionVerificarIngresoEliminar = 5;
        }

        private void txtCedulaClienteEliminar_TextChanged(object sender, EventArgs e)
        {
            lblAvisoCedulaCliente.Visible = true;
            lblAvisoCedulaCliente.Text = "AVISO: Ingrese solamente HASTA 10 DIGITOS";
            lblAvisoRucCliente.Visible = false;
            lblAvisoRucCliente.Text = string.Empty;
        }

        private void txtRucClienteEliminar_TextChanged(object sender, EventArgs e)
        {
            lblAvisoCedulaCliente.Visible = false;
            lblAvisoCedulaCliente.Text = string.Empty;
            lblAvisoRucCliente.Visible = true;
            lblAvisoRucCliente.Text = "AVISO: Ingrese solamente HASTA 13 DIGITOS";
        }

        private void txtCedulaClienteEliminar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtRucClienteEliminar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        public bool verificarIngeso()
        {
            bool resverificarIngeso = true;
            //verifica si la Cedula esta en blanco
            if (txtCedulaCliente.Text == string.Empty && condicionVerificarIngresoEliminar == 1)
            {
                MessageBox.Show("Ingrese Cédula del Cliente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                resverificarIngeso = false;
            }
            //verifica si el RUC esta en blanco
            else if (txtRucCliente.Text == string.Empty && condicionVerificarIngresoEliminar == 2)
            {
                MessageBox.Show("Ingrese Ruc del Cliente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                resverificarIngeso = false;
            }
            //verifica si el nombre esta en blanco
            else if (txtNombreCliente.Text == string.Empty && condicionVerificarIngresoEliminar == 3)
            {
                MessageBox.Show("Ingrese Nombre/Apellido del Cliente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                resverificarIngeso = false;
            }
            //verifica si el nunmero de factura esta en blanco
            else if (txtNumFactura.Text == string.Empty && condicionVerificarIngresoEliminar == 4)
            {
                MessageBox.Show("Ingrese Numero de la Factura ", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                resverificarIngeso = false;
            }
            //verifica si no se ha elejido ningun radiobutton
            else if (rBtnCedula.Checked == false && rBtnRuc.Checked == false && rBtnNombre.Checked == false  &&  rbtnNumeroFactura.Checked==false && rBtnFechas.Checked==false)
            {
                MessageBox.Show("Elija ingresar datos según Cédula ,  RUC ó Nombre ", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                resverificarIngeso = false;
            }
            else
            {
                resverificarIngeso = true;
            }

            return resverificarIngeso;
        }

        private void btnCancelarEliminarCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void BuscarEliminar()
        {
            FuncionesComplementarias obFuncionesComplenetariasEliminar = new FuncionesComplementarias(txtCedulaCliente.Text.Trim(), "", txtRucCliente.Text.Trim(), "");
            if (verificarIngeso())
            {
                if (obFuncionesComplenetariasEliminar.comprobarCedula())
                {
                    if (obFuncionesComplenetariasEliminar.comprobarRuc())
                    {
                        if (condicionVerificarIngresoEliminar == 1)
                        {
                            obconexionesEliminar.consultar("select [NUMERO_FACTURA],[FECHA_FACTURA],[SUBTOTALDOCEPORCIENTO_FACTURA],[SUBTOTALCEROPORCIENTO_FACTURA],[DESCUENTO_FACTURA],[SUBTOTAL_FACTURA],[IVA_FACTURA],[TOTAL_FACTURA],[ESTADO_FACTURA]  from FACTURA A,CLIENTE B where A.ID_CLIENTE= B.ID_CLIENTE AND B.CEDULA_CLIENTE ='" + txtCedulaCliente.Text.Trim() + "' ORDER BY FECHA_FACTURA DESC ", "FACTURA A,CLIENTE B"); 
                            this.dgvBuscarCliente.DataSource = obconexionesEliminar.dataset.Tables["FACTURA A,CLIENTE B"];
                            this.dgvBuscarCliente.Refresh();
                        }
                        if (condicionVerificarIngresoEliminar == 2)
                        {
                            obconexionesEliminar.consultar("select [NUMERO_FACTURA],[FECHA_FACTURA],[SUBTOTALDOCEPORCIENTO_FACTURA],[SUBTOTALCEROPORCIENTO_FACTURA],[DESCUENTO_FACTURA],[SUBTOTAL_FACTURA],[IVA_FACTURA],[TOTAL_FACTURA],[ESTADO_FACTURA]  from FACTURA A,CLIENTE B where A.ID_CLIENTE= B.ID_CLIENTE AND B.RUC_CLIENTE ='" + txtRucCliente.Text.Trim() + "' ORDER BY FECHA_FACTURA DESC ", "FACTURA A,CLIENTE B");
                            this.dgvBuscarCliente.DataSource = obconexionesEliminar.dataset.Tables["FACTURA A,CLIENTE B"];
                            this.dgvBuscarCliente.Refresh();
                        }
                        if (condicionVerificarIngresoEliminar == 3)
                        {
                            obconexionesEliminar.consultar("select [NUMERO_FACTURA],[FECHA_FACTURA],[SUBTOTALDOCEPORCIENTO_FACTURA],[SUBTOTALCEROPORCIENTO_FACTURA],[DESCUENTO_FACTURA],[SUBTOTAL_FACTURA],[IVA_FACTURA],[TOTAL_FACTURA],[ESTADO_FACTURA]  from FACTURA A,CLIENTE B where A.ID_CLIENTE= B.ID_CLIENTE AND RTRIM(B.NOMBRE_CLIENTE) +'"+" '"+"+RTRIM(B.APELLIDO_CLIENTE) LIKE '%"+txtNombreCliente.Text.Trim() + "%' ORDER BY FECHA_FACTURA DESC ", "FACTURA A,CLIENTE B");
                            this.dgvBuscarCliente.DataSource = obconexionesEliminar.dataset.Tables["FACTURA A,CLIENTE B"];
                            this.dgvBuscarCliente.Refresh();
                        }
                        if (condicionVerificarIngresoEliminar == 4)
                        {
                            obconexionesEliminar.consultar("select [NUMERO_FACTURA],[FECHA_FACTURA],[SUBTOTALDOCEPORCIENTO_FACTURA],[SUBTOTALCEROPORCIENTO_FACTURA],[DESCUENTO_FACTURA],[SUBTOTAL_FACTURA],[IVA_FACTURA],[TOTAL_FACTURA],[ESTADO_FACTURA]  from FACTURA A where A.NUMERO_FACTURA =" + txtNumFactura.Text.Trim(), "FACTURA A");
                            this.dgvBuscarCliente.DataSource = obconexionesEliminar.dataset.Tables["FACTURA A"];
                            this.dgvBuscarCliente.Refresh();
                        }
                        if (condicionVerificarIngresoEliminar == 5)
                        {
                            ayudanteFechaInicial = (esFechaActualInicio) ? DateTime.Now.ToLocalTime().ToString("yyyy-MM-dd HH:mm:ss.fff").Trim() : dtpIncial.Value.Date.ToString("yyyy-MM-dd HH:mm:ss.fff").Trim();
                            ayudanteFechaFinal = (esFechaActualFinal) ? DateTime.Now.ToLocalTime().ToString("yyyy-MM-dd HH:mm:ss.fff").Trim() : dtpFinal.Value.Date.ToString("yyyy-MM-dd HH:mm:ss.fff").Trim();
                            obconexionesEliminar.consultar("select [NUMERO_FACTURA],[FECHA_FACTURA],[SUBTOTALDOCEPORCIENTO_FACTURA],[SUBTOTALCEROPORCIENTO_FACTURA],[DESCUENTO_FACTURA],[SUBTOTAL_FACTURA],[IVA_FACTURA],[TOTAL_FACTURA],[ESTADO_FACTURA] from FACTURA A where A.FECHA_FACTURA BETWEEN '" + ayudanteFechaInicial + "' AND '"+ayudanteFechaFinal+"' ORDER BY FECHA_FACTURA DESC ", "FACTURA A");
                            this.dgvBuscarCliente.DataSource = obconexionesEliminar.dataset.Tables["FACTURA A"];
                            this.dgvBuscarCliente.Refresh();
                        }
                    }
                    else
                    {
                        MessageBox.Show("El número de RUC debe ser de 13 digitos válidos, Por favor verifique", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lblAvisoRucCliente.ForeColor = System.Drawing.Color.Red;
                    }
                }
                else
                {
                    MessageBox.Show("La cédula es incorrecta.Debe tener 10 digitos válidos, Por favor verifique", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblAvisoCedulaCliente.ForeColor = System.Drawing.Color.Red;
                }
            }
        }

        private void dgvBuscarClienteEliminar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Evento para seleccionar el indice de la fila donde se encuentra el cliente a eliminar
            int indiceFiladgv = 0;
            indiceFiladgv = e.RowIndex;
            ayudanteAnularIndice = e.RowIndex;
            try
            {
                dgvBuscarCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                Id = Convert.ToInt16(dgvBuscarCliente.Rows[indiceFiladgv].Cells[0].Value);
                numeroFactura = Convert.ToInt32(dgvBuscarCliente.Rows[indiceFiladgv].Cells[0].Value.ToString());
            }
            catch (ArgumentOutOfRangeException)
            {
                indiceFiladgv = 0;
                ayudanteAnularIndice = 0;
            }            
        }

        private void btnBucarCliente_Click(object sender, EventArgs e)
        {
            lblAvisoNuevoIngreso.Visible = false;
            lblAvisoNuevoIngreso.Text = " ";
            BuscarEliminar();
        }
        private void btnBuscarIngresarCliente_Click_1(object sender, EventArgs e)
        {
            fbiCliente.ShowDialog();
            lblAvisoNuevoIngreso.Visible = true;
            lblAvisoNuevoIngreso.Text = "Busque el nuevo Cliente Ingresado -->";
            BuscarEliminar();
        }

        private void btnBuscarActualizarCliente_Click(object sender, EventArgs e)
        {
            fbaCliente.ShowDialog();
            BuscarEliminar();
        }

        private void txtNombreCliente_TextChanged(object sender, EventArgs e)
        {
            lblAvisoRucCliente.Text = string.Empty;
            lblAvisoCedulaCliente.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numeroFactura != 0)
            {
                using (var frmReporteFactura = new FrmReporteFactura(numeroFactura)) {
                    frmReporteFactura.ShowDialog();
                };
                
                numeroFactura = 0;
            }
            else 
            {
                MessageBox.Show("Debe Elejir una factura para observar los detalles.\nRealize un click sobre las opciones de la lista generada por la busqueda", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);   
            }
        }        

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buscarTodos();
        }

        void buscarTodos()
        {
            obconexionesEliminar.consultar("SELECT [NUMERO_FACTURA],[FECHA_FACTURA],[SUBTOTALDOCEPORCIENTO_FACTURA],[SUBTOTALCEROPORCIENTO_FACTURA],[DESCUENTO_FACTURA],[SUBTOTAL_FACTURA],[IVA_FACTURA],[TOTAL_FACTURA],[ESTADO_FACTURA] FROM FACTURA", "FACTURA");
            dgvBuscarCliente.DataSource = obconexionesEliminar.dataset.Tables["FACTURA"];
        }

        private void txtNombreCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == ' ')
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '.')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtApellidoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == ' ')
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '.')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtNumFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtCedulaCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtRucCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {           
            if (dgvBuscarCliente.RowCount != 0)
            {
                string temp = dgvBuscarCliente.Rows[ayudanteAnularIndice].Cells[8].Value.ToString();
                if (!temp.Equals("ANULADA"))
                {
                    if (MessageBox.Show("¿Esta Seguro de Guardar la Factura?", "Guardar Factura", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (numeroFactura != 0)
                        {
                            anularFactura(numeroFactura);
                            obconexionesEliminar.consultar("select [NUMERO_FACTURA],[FECHA_FACTURA],[SUBTOTALDOCEPORCIENTO_FACTURA],[SUBTOTALCEROPORCIENTO_FACTURA],[DESCUENTO_FACTURA],[SUBTOTAL_FACTURA],[IVA_FACTURA],[TOTAL_FACTURA],[ESTADO_FACTURA]  from FACTURA A where A.NUMERO_FACTURA =" + numeroFactura, "FACTURA A");
                            dgvBuscarCliente.DataSource = obconexionesEliminar.dataset.Tables["FACTURA A"];
                            numeroFactura = 0;
                        }
                        else
                        {
                            MessageBox.Show("Debe Elejir una factura para observar los detalles.\nRealize un click sobre las opciones de la lista generada por la busqueda", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("La factura ya se encuentra anulada", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else {
                MessageBox.Show("Debe ejecutar una busqueda", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);   
            }            
        }

        public void anularFactura(int numFacturaAnular)
        {
            obconexionesEliminar.actualizar("FACTURA", "[SUBTOTALDOCEPORCIENTO_FACTURA] = " + 0 + ",[SUBTOTALCEROPORCIENTO_FACTURA]= " + 0 + ",[DESCUENTO_FACTURA]=" + 0 + ",[SUBTOTAL_FACTURA]=" + 0 + ",[IVA_FACTURA]=" + 0 + ",[TOTAL_FACTURA]=" + 0 + ",[ESTADO_FACTURA]='ANULADA'", " NUMERO_FACTURA= " + numFacturaAnular);
        }

        private void dtpIncial_ValueChanged(object sender, EventArgs e)
        {
            esFechaActualInicio = !esFechaActualInicio;
        }

        private void dtpFinal_ValueChanged(object sender, EventArgs e)
        {
            esFechaActualFinal = !esFechaActualFinal;
        }
    }
}