using System;
using System.Windows.Forms;

namespace S.C.A.B.R.E.P
{
    public partial class FrmTrabajoIngresar : Form
    {
        public FrmTrabajoIngresar()
        {
            InitializeComponent();
        }

        private void btnIngresarTrabajo_Click(object sender, EventArgs e)
        {
            try
            {
                Conexiones TrabajoObjeto = new Conexiones();
                if (verificarIngreso())
                {
                    int res = TrabajoObjeto.verificarCodigoTrabajo(lblTrabajo.Text+txtCodigoTrabajo.Text.Trim(), txtNombreTrabajo.Text.Trim(), Convert.ToDouble(txtCostoTrabajo.Text));
                    if (res == 1)
                    {
                        MessageBox.Show("Producto registrado", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("El producto ya esta registrado o esta usando un codigo ya registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch 
            {
                MessageBox.Show("Verifique el formato de ingreso en el campo de costo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);   
            }

        }

        //VERIFICA EL INGRESO DE DATOS
        bool verificarIngreso()
        {
            bool res;
            if (txtCodigoTrabajo.Text == string.Empty)
            {
                MessageBox.Show("Ingrese el codigo del producto", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                res = false;
            }
            else if (txtNombreTrabajo.Text == string.Empty)
            {
                MessageBox.Show("Ingrese el nombre del producto", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                res = false;
            }
            else if (txtCostoTrabajo.Text == string.Empty)
            {
                MessageBox.Show("Ingrese el costo del producto", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                res = false;
            }
            else
            {
                res = true;
            }
            return res;

        }

        private void btnSalirTrabajo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCodigoTrabajo_TextChanged(object sender, EventArgs e)
        {
            lblAvisoCostoTrabajo.Visible = false;
            lblAvisoCostoTrabajo.Text = string.Empty; 
        }

        private void txtNombreTrabajo_TextChanged(object sender, EventArgs e)
        {
            lblAvisoCostoTrabajo.Visible = false;
            lblAvisoCostoTrabajo.Text = string.Empty;
        }

        private void txtDescripcionTrabajo_TextChanged(object sender, EventArgs e)
        {
            lblAvisoCostoTrabajo.Visible = false;
            lblAvisoCostoTrabajo.Text = string.Empty; 
        }
        
        //VERIFICA EL INGRESO DE DECIMALES SEGÚN SQL-SERVER (.)
        private void txtCostoTrabajo_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblAvisoCostoTrabajo.Visible = true;
            lblAvisoCostoTrabajo.Text = "Ingrese el costo del trabajo con el formato (.) para decimales";
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '.')
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
    }
}
