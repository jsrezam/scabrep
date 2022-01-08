using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using InputKey;


namespace S.C.A.B.R.E.P
{
    public partial class FrmProducto : Form
    {
        public FrmProducto()
        {
            InitializeComponent();
        }
        Conexiones objetoconexion = new Conexiones();
        int rbtnEleccion;
        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            if (verificarIngreso())
            {
                if (rbtnEleccion == 1)
                {
                    objetoconexion.consultar("Select * from PRODUCTO WHERE CODIGO_PRODUCTO like '%" + txtCodigo.Text.Trim() + "%'", "PRODUCTO");
                    this.dgvBusqueda.DataSource = objetoconexion.dataset.Tables["PRODUCTO"];
                    this.dgvBusqueda.Refresh();
                }
                if (rbtnEleccion == 2)
                {
                    objetoconexion.consultar("Select * from PRODUCTO WHERE NOMBRE_PRODUCTO like '%" + txtNombre.Text.Trim() + "%'", "PRODUCTO");
                    this.dgvBusqueda.DataSource = objetoconexion.dataset.Tables["PRODUCTO"];
                    this.dgvBusqueda.Refresh();
                }
                if (rbtnEleccion == 3)
                {
                    objetoconexion.consultar("Select * from PRODUCTO WHERE CODIGO_PRODUCTO like '%" + txtCodigo.Text.Trim() + "%' and NOMBRE_PRODUCTO like '%" + txtNombre.Text.Trim() + "%'", "PRODUCTO");
                    this.dgvBusqueda.DataSource = objetoconexion.dataset.Tables["PRODUCTO"];
                    this.dgvBusqueda.Refresh();
                }

            }
        }
        bool  verificarIngreso() 
        {
            bool res;
            if (txtCodigo.Text == ""&& rbtnEleccion==1) 
            {
                MessageBox.Show("Ingrese el codigo del producto", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                res = false;
            }
            else if (txtNombre.Text == "" && rbtnEleccion == 2)
            {
                MessageBox.Show("Ingrese el nombre del producto", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                res = false;
            }
            else if (txtCodigo.Text == ""&& rbtnEleccion==3 || txtNombre.Text == "" && rbtnEleccion == 3)
            {
                MessageBox.Show("Ingrese el nombre del producto", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                res = false;
            }
            else if (rbtnCodigo.Checked == false && rbtnNombre.Checked == false && rbtnCodigoNombre.Checked == false)
            {
                MessageBox.Show("Escoja una opcion de busqueda", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                res = false;
            }
            else 
            {
                res = true;
            }
            return res;

        }
        private void rbtnCodigo_CheckedChanged(object sender, EventArgs e)
        {
            txtCodigo.Enabled = true;
            txtNombre.Enabled = false;
            txtNombre.Text = "";
            rbtnEleccion = 1;
        }
        private void rbtnNombre_CheckedChanged(object sender, EventArgs e)
        {
            txtCodigo.Enabled = false;
            txtCodigo.Text = "";
            txtNombre.Enabled = true;
            rbtnEleccion = 2;
        }
        private void rbtnCodigoNombre_CheckedChanged(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtCodigo.Enabled = true;
            txtNombre.Enabled = true;
            rbtnEleccion = 3;
        }
        private void btnBuscarTodos_Click_1(object sender, EventArgs e)
        {
            objetoconexion.consultar("SELECT * FROM PRODUCTO", "PRODUCTO");
            dgvBusqueda.DataSource = objetoconexion.dataset.Tables["PRODUCTO"];

        }
        private void dgvBusqueda_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvBusqueda.RowCount != 0)
            {
                txtDescripcionBusqueda.Text = dgvBusqueda.CurrentRow.Cells[2].Value.ToString().Trim();
                txtMostrarCodigo.Text = dgvBusqueda.CurrentRow.Cells[1].Value.ToString().Trim();
            }
        }
        private void dgvBusqueda_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (dgvBusqueda.Rows.Count != 0)
                {
                    int cantidad = Convert.ToInt32(InputDialog.mostrar("Cuantos desea:", "CANTIDAD", InputDialog.ACEPTAR_BOTON, InputDialog.MENSAJE_PREGUNTA));
                    //double porcentajeGanancia = (Convert.ToDouble(InputDialog.mostrar("Ingrese Porcentaje de Ganancia:", "GANANCIA", InputDialog.ACEPTAR_BOTON, InputDialog.MENSAJE_PREGUNTA)) / 100);
                    double porcentajeGanancia = 0;//CODIGO PRUEBA
                    if (cantidad > 0 && porcentajeGanancia >= 0)
                    {
                        double ganancia;
                        double importe;
                        double importeFinal;
                        string valorUnitario;
                        valorUnitario = dgvBusqueda.CurrentRow.Cells[3].Value.ToString().Trim();
                        importe = Math.Round(Convert.ToDouble(valorUnitario) * cantidad, 2);
                        ganancia = Math.Round(importe * porcentajeGanancia, 2);
                        importeFinal = importe + ganancia;
                        if (verificarIdDatagrid())
                        {
                            dgvSeleccion.Rows.Add(dgvBusqueda.CurrentRow.Cells[0].Value, dgvBusqueda.CurrentRow.Cells[1].Value, cantidad, dgvBusqueda.CurrentRow.Cells[2].Value, dgvBusqueda.CurrentRow.Cells[3].Value, porcentajeGanancia, importeFinal);
                        }
                        else
                        {
                            MessageBox.Show("Este registro ya esta en la lista", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("DEBE INTRODUCIR una Cantidad MAYOR A CERO y un Porcentaje de Ganacia MAYOR O IGUAL A CERO", "ATECION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }catch
            {
                MessageBox.Show("DEBE INTRODUCIR una Cantidad MAYOR A CERO y un Porcentaje de Ganacia MAYOR O IGUAL A CERO", "ATECION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        bool verificarIdDatagrid() 
        {
            bool res=true;
            int cont=0;
            for (int i = 0; i <= dgvSeleccion.Rows.Count; i++)
            {
                if (dgvSeleccion.RowCount == 0)
                {
                    res = true;
                }
                else if (i!=0)
                {
                    if (Convert.ToInt32(dgvBusqueda.CurrentRow.Cells[0].Value) == Convert.ToInt32(dgvSeleccion.Rows[cont].Cells[0].Value))
                    {
                        res = false;
                        cont++;
                    }
                    else 
                    {
                        cont++;
                    }
                    
                }
            }
            return res;
        }
        private void dgvSeleccion_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvSeleccion.RowCount != 0)
            {
                txtDescripcionBusqueda.Text = dgvSeleccion.CurrentRow.Cells[3].Value.ToString().Trim();
                txtMostrarCodigo.Text = dgvSeleccion.CurrentRow.Cells[1].Value.ToString().Trim();
            }
        }
        private void dgvSeleccion_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (dgvSeleccion.Rows.Count != 0)
                {
                    int cantidad = Convert.ToInt32(InputDialog.mostrar("Cuantos desea:", "CANTIDAD", InputDialog.ACEPTAR_BOTON, InputDialog.MENSAJE_PREGUNTA));
                    //double porcentajeGanancia = (Convert.ToDouble(InputDialog.mostrar("Ingrese Porcentaje de Ganancia:", "GANANCIA", InputDialog.ACEPTAR_BOTON, InputDialog.MENSAJE_PREGUNTA))) / 100;
                    double porcentajeGanancia = 0;//CODIGO PRUEBA
                    double ganancia;
                    double importe;
                    double importeFinal;
                    string valorUnitario;
                    valorUnitario = dgvSeleccion.CurrentRow.Cells[4].Value.ToString().Trim();
                    importe = Math.Round(Convert.ToDouble(valorUnitario) * cantidad, 2);
                    ganancia = Math.Round(importe * porcentajeGanancia, 2);
                    importeFinal = importe + ganancia;
                    dgvSeleccion.CurrentRow.SetValues(dgvSeleccion.CurrentRow.Cells[0].Value, dgvSeleccion.CurrentRow.Cells[1].Value, cantidad, dgvSeleccion.CurrentRow.Cells[3].Value, dgvSeleccion.CurrentRow.Cells[4].Value, porcentajeGanancia, importeFinal);
                }
            }
            catch 
            {
                MessageBox.Show("DEBE INTRODUCIR una Cantidad y un Porcentaje de Ganacia", "ATECION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);    
            }
        }

        private void btnAbrirProductoIngresar_Click(object sender, EventArgs e)
        {
            FrmProductoIngresar fProductoIngresar = new FrmProductoIngresar();
            fProductoIngresar.ShowDialog();
        }

        private void btnAbrirTrabajoIngresar_Click(object sender, EventArgs e)
        {
            FrmTrabajoIngresar fTrabajoIngresar = new FrmTrabajoIngresar();
            fTrabajoIngresar.ShowDialog();   
        }

        private void btnAbrirProductoActualizar_Click(object sender, EventArgs e)
        {
            FrmProductoActualizar fProductoActualizar = new FrmProductoActualizar();
            fProductoActualizar.ShowDialog();
        }

        private void btnAbrirTrabajoActualizar_Click(object sender, EventArgs e)
        {
            FrmTrabajoActualizar fTrabajoActualizar = new FrmTrabajoActualizar();
            fTrabajoActualizar.ShowDialog();
        }


    }
}
