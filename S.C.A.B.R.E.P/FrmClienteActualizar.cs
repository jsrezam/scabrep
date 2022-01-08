using System;
using System.Windows.Forms;

namespace S.C.A.B.R.E.P
{
    public partial class FrmClienteActualizar : Form
    {
        Conexiones obconexionesActualizar = new Conexiones();
        int condicionVerificarIngresoActualizar;
        int Id;
        int IdActualizarDataGridView;
        int IdActualizarAyudante;
        string cedulaPredeterminado;
        string rucPredeterminado;
        string nombrePredeterminado;
        string apellidoPredeterminado;
        string telefonoCelularPredeterminado;
        string telefonoFijoPredeterminado;
        string DireccionPredeterminado;
        string MailPredeterminado;

        int flagSeleccion = 0;

        public FrmClienteActualizar()
        {
            InitializeComponent();
        }        

        private void rBtnCedulaActualizar_CheckedChanged(object sender, EventArgs e)
        {
            txtCedulaClienteBuscarActualizar.Enabled = true;
            txtRucClienteBuscarActualizar.Enabled = false;
            txtRucClienteBuscarActualizar.Text = string.Empty;
            txtNombreClienteBuscarActualizar.Enabled = false;
            txtNombreClienteBuscarActualizar.Text = string.Empty;
            condicionVerificarIngresoActualizar = 1;
        }

        private void rBtnRucActualizar_CheckedChanged(object sender, EventArgs e)
        {
            txtRucClienteBuscarActualizar.Enabled = true;
            txtCedulaClienteBuscarActualizar.Enabled = false;
            txtCedulaClienteBuscarActualizar.Text = string.Empty;
            txtNombreClienteBuscarActualizar.Enabled = false;
            txtNombreClienteBuscarActualizar.Text = string.Empty;
            condicionVerificarIngresoActualizar = 2;
        }
       
        private void rBtnNombreActualizar_CheckedChanged(object sender, EventArgs e)
        {
            txtNombreClienteBuscarActualizar.Enabled = true;
            txtCedulaClienteBuscarActualizar.Text = string.Empty;
            txtCedulaClienteBuscarActualizar.Enabled = false;
            txtRucClienteBuscarActualizar.Enabled = false;
            txtRucClienteBuscarActualizar.Text = string.Empty;
            condicionVerificarIngresoActualizar = 3;
        }

        private void txtCedulaClienteActualizar_TextChanged(object sender, EventArgs e)
        {
            lblAvisoCedulaClienteActualizar.Visible = true;
            lblAvisoCedulaClienteActualizar.Text = "AVISO: Ingrese solamente HASTA 10 DIGITOS";

            lblAvisoRucClienteActualizar.Visible = false;
            lblAvisoRucClienteActualizar.Text = string.Empty;
        }

        private void txtRucClienteActualizar_TextChanged(object sender, EventArgs e)
        {
            lblAvisoCedulaClienteActualizar.Visible = false;
            lblAvisoCedulaClienteActualizar.Text = string.Empty;
            lblAvisoRucClienteActualizar.Visible = true;
            lblAvisoRucClienteActualizar.Text = "AVISO: Ingrese solamente HASTA 13 DIGITOS";
        }

        private void txtCedulaClienteActualizar_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtRucClienteActualizar_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnBucarActualizarCliente_Click(object sender, EventArgs e)
        {
            buscarClienteActualizar();
        }

        public bool verificarIngeso()
        {
            bool resverificarIngeso = true;
            if (txtCedulaClienteBuscarActualizar.Text == "" && condicionVerificarIngresoActualizar == 1)
            {
                MessageBox.Show("Ingrese Cédula del Cliente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                resverificarIngeso = false;
            }
            else if (txtRucClienteBuscarActualizar.Text == "" && condicionVerificarIngresoActualizar == 2)
            {
                MessageBox.Show("Ingrese Ruc del Cliente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                resverificarIngeso = false;
            }
            else if (txtNombreClienteBuscarActualizar.Text == "" && condicionVerificarIngresoActualizar == 3)
            {
                MessageBox.Show("Ingrese Nombre del Cliente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                resverificarIngeso = false;
            }
            else if (rBtnCedulaActualizar.Checked == false && rBtnRucActualizar.Checked == false &&   rBtnNombreActualizar.Checked==false)
            {
                MessageBox.Show("Elija ingresar datos según: Cédula , RUC , Cédula/RUC o Nombre ", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                resverificarIngeso = false;
            }
            else
            {
                resverificarIngeso = true;
            }
            return resverificarIngeso;
        }

        private void btnCancelarActualizarCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombreClienteBuscarActualizar_TextChanged(object sender, EventArgs e)
        {
            lblAvisoCedulaClienteActualizar.Visible = false;
            lblAvisoCedulaClienteActualizar.Text = string.Empty;
            lblAvisoRucClienteActualizar.Visible = false;
            lblAvisoRucClienteActualizar.Text = string.Empty;
        }

        private void txtNombreClienteBuscarActualizar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '\'')
            {
                e.Handled = true;
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

        //evento permite recoger los datos del datagridview segun la fila donde se encuentra y los agrega a los diferentes campos 
        private void dgvBuscarClienteActualizar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indiceFila = 0;
            indiceFila = e.RowIndex;
            
            try
            {
                txtCedulaClienteActualizarAyudante.Text = dgvBuscarClienteActualizar.Rows[indiceFila].Cells[1].Value.ToString();
                txtRucClienteActualizarAyudante.Text = dgvBuscarClienteActualizar.Rows[indiceFila].Cells[2].Value.ToString();
                txtNombreClienteActualizarAyudante.Text = dgvBuscarClienteActualizar.Rows[indiceFila].Cells[3].Value.ToString();
                txtApellidoClienteActualizarAyudante.Text = dgvBuscarClienteActualizar.Rows[indiceFila].Cells[4].Value.ToString();
                txtTelefonoCelularClienteActualizarAyudante.Text = dgvBuscarClienteActualizar.Rows[indiceFila].Cells[5].Value.ToString();
                txtTelefonoFijoClienteActualizarAyudante.Text = dgvBuscarClienteActualizar.Rows[indiceFila].Cells[6].Value.ToString();
                txtDireccionClienteActualizarAyudante.Text = dgvBuscarClienteActualizar.Rows[indiceFila].Cells[7].Value.ToString();
                txtMailClienteActualizarAyudante.Text = dgvBuscarClienteActualizar.Rows[indiceFila].Cells[8].Value.ToString();

                cedulaPredeterminado = dgvBuscarClienteActualizar.Rows[indiceFila].Cells[1].Value.ToString();
                rucPredeterminado = dgvBuscarClienteActualizar.Rows[indiceFila].Cells[2].Value.ToString();
                nombrePredeterminado = dgvBuscarClienteActualizar.Rows[indiceFila].Cells[3].Value.ToString();
                apellidoPredeterminado = dgvBuscarClienteActualizar.Rows[indiceFila].Cells[4].Value.ToString();
                telefonoCelularPredeterminado = dgvBuscarClienteActualizar.Rows[indiceFila].Cells[5].Value.ToString();
                telefonoFijoPredeterminado = dgvBuscarClienteActualizar.Rows[indiceFila].Cells[6].Value.ToString();
                DireccionPredeterminado = dgvBuscarClienteActualizar.Rows[indiceFila].Cells[7].Value.ToString();
                MailPredeterminado = dgvBuscarClienteActualizar.Rows[indiceFila].Cells[8].Value.ToString();

                dgvBuscarClienteActualizar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                IdActualizarDataGridView = Convert.ToInt16(dgvBuscarClienteActualizar.Rows[indiceFila].Cells[0].Value);
                IdActualizarAyudante = Convert.ToInt16(dgvBuscarClienteActualizar.Rows[indiceFila].Cells[0].Value);
                Id =Convert.ToInt16(dgvBuscarClienteActualizar.Rows[indiceFila].Cells[0].Value);
                flagSeleccion = 1;

            }
            catch(ArgumentOutOfRangeException)
            {
                indiceFila = 0;
                flagSeleccion = 0;
            }

        }

        private void rBtnCedulaActualizarAyudante_CheckedChanged(object sender, EventArgs e)
        {
            txtCedulaClienteActualizarAyudante.Enabled = true;
            txtRucClienteActualizarAyudante.Enabled = false;
            txtRucClienteActualizarAyudante.Text = string.Empty;            
        }

        private void rBtnRucActualizarAyudante_CheckedChanged(object sender, EventArgs e)
        {
            txtCedulaClienteActualizarAyudante.Enabled = false;
            txtRucClienteActualizarAyudante.Enabled = true;
            txtCedulaClienteActualizarAyudante.Text = string.Empty;            
        }

        private void btnActualizarCliente_Click_1(object sender, EventArgs e)
        {
            FuncionesComplementarias obFuncionesComplenetariasActualizar = new FuncionesComplementarias(txtCedulaClienteActualizarAyudante.Text.Trim(), txtTelefonoCelularClienteActualizarAyudante.Text.Trim(), txtRucClienteActualizarAyudante.Text.Trim(), txtMailClienteActualizarAyudante.Text.Trim());
            if (flagSeleccion != 0)
            {
                if (obFuncionesComplenetariasActualizar.comprobarCedula())
                {
                    if (obFuncionesComplenetariasActualizar.comprobarRuc())
                    {
                        if (obFuncionesComplenetariasActualizar.comprobarTelefonoCelular())
                        {
                            if (obFuncionesComplenetariasActualizar.comprobarMail())
                            {
                                if (cedulaPredeterminado.Trim() == txtCedulaClienteActualizarAyudante.Text.Trim() && rucPredeterminado.Trim() == txtRucClienteActualizarAyudante.Text.Trim())
                                {
                                    string campos = "CEDULA_CLIENTE='" + this.txtCedulaClienteActualizarAyudante.Text.Trim() + "',RUC_CLIENTE='" + this.txtRucClienteActualizarAyudante.Text.Trim() + "',NOMBRE_CLIENTE='" + this.txtNombreClienteActualizarAyudante.Text.Trim() + "',APELLIDO_CLIENTE='" + this.txtApellidoClienteActualizarAyudante.Text.Trim() + "',TELEFONOCELULAR_CLIENTE='" + this.txtTelefonoCelularClienteActualizarAyudante.Text.Trim() + "',TELEFONOFIJO_CLIENTE='" + this.txtTelefonoFijoClienteActualizarAyudante.Text.Trim() + "',DIRECCION_CLIENTE='" + this.txtDireccionClienteActualizarAyudante.Text.Trim() + "',MAIL_CLIENTE='" + this.txtMailClienteActualizarAyudante.Text.Trim() + "'";
                                    if (obconexionesActualizar.actualizar("CLIENTE", campos, "ID_CLIENTE='" + Id + "'"))
                                    {
                                        MessageBox.Show("Registro Actualizado ", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                        cedulaPredeterminado = txtCedulaClienteActualizarAyudante.Text;
                                        rucPredeterminado = txtRucClienteActualizarAyudante.Text;
                                        nombrePredeterminado = txtNombreClienteActualizarAyudante.Text;
                                        apellidoPredeterminado = txtApellidoClienteActualizarAyudante.Text;
                                        telefonoCelularPredeterminado = txtTelefonoCelularClienteActualizarAyudante.Text;
                                        telefonoFijoPredeterminado = txtTelefonoFijoClienteActualizarAyudante.Text;
                                        DireccionPredeterminado = txtDireccionClienteActualizarAyudante.Text;
                                        MailPredeterminado = txtMailClienteActualizarAyudante.Text;
                                        actualizarDataGridView();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Por favor Elija un Cliente para actualizar ", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    }

                                }
                                else
                                {
                                    int resActualizar = obconexionesActualizar.verificarCedulaRepeticionActualizar(cedulaPredeterminado, rucPredeterminado, txtCedulaClienteActualizarAyudante.Text, txtRucClienteActualizarAyudante.Text, txtNombreClienteActualizarAyudante.Text, txtApellidoClienteActualizarAyudante.Text, txtTelefonoCelularClienteActualizarAyudante.Text, txtTelefonoFijoClienteActualizarAyudante.Text, txtDireccionClienteActualizarAyudante.Text, txtMailClienteActualizarAyudante.Text, IdActualizarAyudante);
                                    if (resActualizar == 1)
                                    {
                                        MessageBox.Show("Registro Actualizado ", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                        actualizarDataGridView();
                                    }
                                    else
                                    {
                                        MessageBox.Show("La cedula/Ruc ya se encuentra registrada con otro usuario,Por favor verifique ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("El E-Mail ingresado no cumple con en formato (texto@domino), Por favor verifique", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                lblAvisoTelefonoCelularClienteActualizarAyudante.ForeColor = System.Drawing.Color.Red;
                            }
                        }
                        else
                        {
                            MessageBox.Show("El número telefónico no debe ser MAYOR a 10 digitos, Por favor verifique", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            lblAvisoTelefonoCelularClienteActualizarAyudante.ForeColor = System.Drawing.Color.Red;

                        }
                    }
                    else
                    {
                        MessageBox.Show("El número de RUC debe ser de 13 digitos válidos, Por favor verifique", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lblAvisoRucClienteActualizarAyudante.ForeColor = System.Drawing.Color.Red;

                    }
                }
                else
                {
                    MessageBox.Show("La cédula es incorrecta.Debe tener 10 digitos válidos, Por favor verifique", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblAvisoCedulaClienteActualizarAyudante.ForeColor = System.Drawing.Color.Red;
                }
            }
            else 
            {
                MessageBox.Show("Escoja una cliente para actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNombreClienteActualizarAyudante_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '\'')
            {
                e.Handled = true;
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

        private void txtApellidoClienteActualizarAyudante_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '\'')
            {
                e.Handled = true;
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

        private void txtTelefonoCelularClienteActualizarAyudante_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtTelefonoFijoClienteActualizarAyudante_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCedulaClienteActualizarAyudante_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtRucClienteActualizarAyudante_KeyPress(object sender, KeyPressEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                txtCedulaClienteActualizarAyudante.Text = cedulaPredeterminado.Trim();
                txtRucClienteActualizarAyudante.Text = rucPredeterminado.Trim();
                txtNombreClienteActualizarAyudante.Text = nombrePredeterminado.Trim();
                txtApellidoClienteActualizarAyudante.Text = apellidoPredeterminado.Trim();
                txtTelefonoCelularClienteActualizarAyudante.Text = telefonoCelularPredeterminado.Trim();
                txtTelefonoFijoClienteActualizarAyudante.Text = telefonoFijoPredeterminado.Trim();
                txtDireccionClienteActualizarAyudante.Text = DireccionPredeterminado.Trim();
                txtMailClienteActualizarAyudante.Text = MailPredeterminado.Trim();
            }
            catch {
                MessageBox.Show("No se ha seleccionado ningun cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);    
            }
        }

        public void buscarClienteActualizar()
        {
            FuncionesComplementarias obFuncionesComplenetariasBuscarActualizar = new FuncionesComplementarias(txtCedulaClienteBuscarActualizar.Text.Trim(), "", txtRucClienteBuscarActualizar.Text.Trim(), "");
            if (verificarIngeso())
            {
                if (obFuncionesComplenetariasBuscarActualizar.comprobarCedula())
                {
                    if (obFuncionesComplenetariasBuscarActualizar.comprobarRuc())
                    {
                        if (condicionVerificarIngresoActualizar == 1)
                        {
                            obconexionesActualizar.consultar("Select * from CLIENTE WHERE CEDULA_CLIENTE='" + txtCedulaClienteBuscarActualizar.Text.Trim() + "'", "CLIENTE");
                            this.dgvBuscarClienteActualizar.DataSource = obconexionesActualizar.dataset.Tables["CLIENTE"];
                            this.dgvBuscarClienteActualizar.Refresh();
                        }
                        if (condicionVerificarIngresoActualizar == 2)
                        {
                            obconexionesActualizar.consultar("Select * from CLIENTE WHERE RUC_CLIENTE='" + txtRucClienteBuscarActualizar.Text.Trim() + "'", "CLIENTE");
                            this.dgvBuscarClienteActualizar.DataSource = obconexionesActualizar.dataset.Tables["CLIENTE"];
                            this.dgvBuscarClienteActualizar.Refresh();
                        }
                        if (condicionVerificarIngresoActualizar == 3)
                        {
                            obconexionesActualizar.consultar("Select * from CLIENTE WHERE RTRIM(NOMBRE_CLIENTE) +'"+" '"+"+RTRIM(APELLIDO_CLIENTE) like '%" + txtNombreClienteBuscarActualizar.Text.Trim() +"%'","CLIENTE");
                            this.dgvBuscarClienteActualizar.DataSource = obconexionesActualizar.dataset.Tables["CLIENTE"];
                            this.dgvBuscarClienteActualizar.Refresh();
                        }
                    }
                    else
                    {
                        MessageBox.Show("El número de RUC debe ser de 13 digitos válidos, Por favor verifique", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lblAvisoRucClienteActualizar.ForeColor = System.Drawing.Color.Red;
                    }
                }
                else
                {
                    MessageBox.Show("La cédula es incorrecta.Debe tener 10 digitos válidos, Por favor verifique", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblAvisoCedulaClienteActualizar.ForeColor = System.Drawing.Color.Red;
                }
            }
        }

        public void actualizarDataGridView()
        {
            obconexionesActualizar.consultar("Select * from CLIENTE WHERE ID_CLIENTE='" + IdActualizarDataGridView + "'", "CLIENTE");
            this.dgvBuscarClienteActualizar.DataSource = obconexionesActualizar.dataset.Tables["CLIENTE"];
            this.dgvBuscarClienteActualizar.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            obconexionesActualizar.consultar("SELECT * FROM CLIENTE", "CLIENTE");
            dgvBuscarClienteActualizar.DataSource = obconexionesActualizar.dataset.Tables["CLIENTE"];            
        }

        private void txtDireccionClienteActualizarAyudante_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\'')
            {
                e.Handled = true;
            }

        }
    }
}
