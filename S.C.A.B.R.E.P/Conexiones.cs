using System;
using System.Data.SqlClient;
using System.Data;
using S.C.A.B.R.E.P.Properties;
using System.Configuration;

namespace S.C.A.B.R.E.P
{
    class Conexiones
    {
        public SqlConnection conector;
        public SqlCommandBuilder comamdoBuilder;
        public DataSet  dataset = new DataSet ();
        public SqlDataAdapter adaptador;
        public  SqlCommand comando;
        public string ultimoMensaje;
        

        public static string ObtenerCadenaDeConexion()
        {
            //return Settings.Default.VentasConnectionString;
            return ConfigurationManager.AppSettings.Get("DefaultConnectionString");
        }

        private string cadena = ObtenerCadenaDeConexion();

        private void conectar()
        {
            conector=new SqlConnection(cadena);
        }
        public Conexiones()
        {
            conectar();
        }
//**************************************************PROCEDIMIENTO ALMACENADOS MANTENIMIENTO**************************************************************************************************************************************************************
        //Procedimiento almacenado verificacion cedula O RUC REPETIDO
        public int verificarCedulaRepeticion(string CedulaIngresado, string RucIngresado, string nombreIngresado, string apellidoIngresado, string telefonoCelularIngresado, string telefonofijoIngresado, string direccionIngresado, string mailIngresado)
        {
            SqlCommand comando = new SqlCommand("verificacionCedulaCliente", conector);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@cedulaCliente", CedulaIngresado);
            comando.Parameters.AddWithValue("@rucCliente", RucIngresado);
            comando.Parameters.AddWithValue("@nombreCliente", nombreIngresado);
            comando.Parameters.AddWithValue("@apellidoCliente", apellidoIngresado);
            comando.Parameters.AddWithValue("@telefonoCelularCliente", telefonoCelularIngresado);
            comando.Parameters.AddWithValue("@telefonoFijoCliente", telefonofijoIngresado);
            comando.Parameters.AddWithValue("@direccionCliente", direccionIngresado);
            comando.Parameters.AddWithValue("@mailCliente", mailIngresado);
            conector.Open();
            int res=Convert.ToInt16(comando.ExecuteNonQuery());
            conector.Close();
            return res;
        }
        //Procedimiento almacenado verificacion cedula O RUC REPETIDO en ACTUALIZAR
        public int verificarCedulaRepeticionActualizar(string CedulaIngresado, string RucIngresado, string CedulaNueva, string RucNuevo, string nombreIngresado, string apellidoIngresado, string telefonoCelularIngresado, string telefonofijoIngresado, string direccionIngresado, string mailIngresado,int id)
        {
            SqlCommand comando = new SqlCommand("verificacionCedulaClienteActualizacion", conector);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@cedulaNuevaCliente", CedulaNueva.Trim());
            comando.Parameters.AddWithValue("@rucNuevoCliente", RucNuevo.Trim());
            comando.Parameters.AddWithValue("@cedulaViejaCliente", CedulaIngresado.Trim());
            comando.Parameters.AddWithValue("@rucViejoCliente", RucIngresado.Trim());
            comando.Parameters.AddWithValue("@nombreCliente", nombreIngresado.Trim());
            comando.Parameters.AddWithValue("@apellidoCliente", apellidoIngresado.Trim());
            comando.Parameters.AddWithValue("@telefonoCelularCliente", telefonoCelularIngresado.Trim());
            comando.Parameters.AddWithValue("@telefonoFijoCliente", telefonofijoIngresado.Trim());
            comando.Parameters.AddWithValue("@direccionCliente", direccionIngresado.Trim());
            comando.Parameters.AddWithValue("@mailCliente", mailIngresado.Trim());
            comando.Parameters.AddWithValue("@id", id);
            conector.Open();
            int res = Convert.ToInt16(comando.ExecuteNonQuery());
            conector.Close();
            return res;
        }
        //Procedimiento almacenado verificacion codigo del producto 
        public int verificarCodigoRepeticionProductoEspecial(string CodigoProducto, string NombreProducto, double precioProducto)
        {
            SqlCommand comando = new SqlCommand("InsertarProducto", conector);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@codigoProducto", CodigoProducto.Trim());
            comando.Parameters.AddWithValue("@nombreProducto", NombreProducto.Trim());
            comando.Parameters.AddWithValue("@precioProducto", precioProducto);
            conector.Open();
            int res = Convert.ToInt16(comando.ExecuteNonQuery());
            conector.Close();
            return res;
        }
        //Procedimiento almacenado verificacion codigo del producto al momento de actualizar 
        public int verificarCodigoRepeticionProductoEspecialActualizar(string CodigoProducto, string NombreProducto,double precioProducto,int id)
        {
            SqlCommand comando = new SqlCommand("actualizarProducto", conector);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@codigoNuevoProducto", CodigoProducto.Trim());
            comando.Parameters.AddWithValue("@nombreProducto", NombreProducto.Trim());
            comando.Parameters.AddWithValue("@precioProducto", precioProducto);
            comando.Parameters.AddWithValue("@id", id);
            conector.Open();
            int res = Convert.ToInt16(comando.ExecuteNonQuery());
            conector.Close();
            return res;
        }
        //Procedimiento almacenado verificacion codigo del Trabajo 
        public int verificarCodigoTrabajo (string CodigoTrabajo, string NombreTrabajo, double precioTrabajo)
        {
            SqlCommand comando = new SqlCommand("InsertarTrabajo", conector);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@codigoTrabajo ", CodigoTrabajo.Trim());
            comando.Parameters.AddWithValue("@nombreTrabajo", NombreTrabajo.Trim());
            comando.Parameters.AddWithValue("@precioTrabajo", precioTrabajo);
            conector.Open();
            int res = Convert.ToInt16(comando.ExecuteNonQuery());
            conector.Close();
            return res;
        }
        //Procedimiento almacenado verificacion codigo del TRABAJO al momento de actualizar 
        public int verificarCodigoTrabajoActualizar(string CodigoTrabajo, string NombreTrabajo, double precioTrabajo, int id)
        {
            SqlCommand comando = new SqlCommand("actualizarTrabajo", conector);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@codigoNuevoTrabajo", CodigoTrabajo.Trim());
            comando.Parameters.AddWithValue("@nombreTrabajo", NombreTrabajo.Trim());
            comando.Parameters.AddWithValue("@precioTrabajo", precioTrabajo);
            comando.Parameters.AddWithValue("@id", id);
            conector.Open();
            int res = Convert.ToInt16(comando.ExecuteNonQuery());
            conector.Close();
            return res;
        }
        //Procedimiento almacenado verificacion cedula del Usuario 
        public int verificarCedulaUsuario(string CedulaUsuario, string NombreUsuario, string ApellidoUsuario, string PasswordUsuario)
        {
            SqlCommand comando = new SqlCommand("verificacionCedulaUsuario", conector);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@cedulaUsuario", CedulaUsuario.Trim());
            comando.Parameters.AddWithValue("@nombreUsuario", NombreUsuario.Trim());
            comando.Parameters.AddWithValue("@apellidoUsuario", ApellidoUsuario.Trim());
            comando.Parameters.AddWithValue("@passwordUsuario", PasswordUsuario.Trim());
            conector.Open();
            int res = Convert.ToInt16(comando.ExecuteNonQuery());
            conector.Close();
            return res;
        }
        //Procedimiento almacenado verificacion cedula del Usuario al momento de actualizar 
        public int verificarCedulaUsuarioActualizar(string CedulaUsuario, string NombreUsuario, string ApellidoUsuario, string PasswordUsuario,int id)
        {
            SqlCommand comando = new SqlCommand("verificacionCedulaUsuarioActuralizar", conector);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@cedulaUsuario", CedulaUsuario.Trim());
            comando.Parameters.AddWithValue("@nombreUsuario", NombreUsuario.Trim());
            comando.Parameters.AddWithValue("@apellidoUsuario", ApellidoUsuario.Trim());
            comando.Parameters.AddWithValue("@passwordUsuario", PasswordUsuario.Trim());
            comando.Parameters.AddWithValue("@id", id);
            conector.Open();
            int res = Convert.ToInt16(comando.ExecuteNonQuery());
            conector.Close();
            return res;
        }
//**************************************************PROCEDIMIENTO ALMACENADOS FACTURA DETALLE**************************************************************************************************************************************************************
        //Procedimiento almacenado para ingresar el detalle de la factura con relacion al Producto
        public int ingresoDetalleProducto(int idProducto, int numeroFactura, int cantidadProducto, double precioUnitarioProducto, double importeProducto)
        {
            SqlCommand comando = new SqlCommand("ingresoDetalleProductoFactura", conector);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idProducto",idProducto);
            comando.Parameters.AddWithValue("@numeroFactura",numeroFactura);
            comando.Parameters.AddWithValue("@Cantidad",cantidadProducto);
            comando.Parameters.AddWithValue("@precioUnitario",precioUnitarioProducto);
            comando.Parameters.AddWithValue("@importe", importeProducto);
            conector.Open();
            int res = Convert.ToInt16(comando.ExecuteNonQuery());
            conector.Close();
            return res;
        }
//**************************************************PROCEDIMIENTO ALMACENADO FACTURA**************************************************************************************************************************************************************
        //Procedimiento almacenado para ingresar la factura 
        public int ingresoFactura(int numFactura, int idCliente, int idUsuario, DateTime fecha, double subTotalDoce, double subTotalCero, double descuento, double subTotal, double iva, double total,string estado)
        {
            SqlCommand comando = new SqlCommand("IngresarFactura", conector);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idCliente", idCliente);
            comando.Parameters.AddWithValue("@numFactura", numFactura);
            comando.Parameters.AddWithValue("@idUsuario", idUsuario);
            comando.Parameters.AddWithValue("@fecha", fecha);
            comando.Parameters.AddWithValue("@subTotalDoce", subTotalDoce);
            comando.Parameters.AddWithValue("@subTotalCero", subTotalCero);
            comando.Parameters.AddWithValue("@descuento", descuento);
            comando.Parameters.AddWithValue("@subTotal", subTotal);
            comando.Parameters.AddWithValue("@iva", iva);
            comando.Parameters.AddWithValue("@total", total);
            comando.Parameters.AddWithValue("@estado", estado);
            conector.Open();
            int res = Convert.ToInt16(comando.ExecuteNonQuery());
            conector.Close();
            return res;
        }
//**************************************************METODOS DE CONSULTA,ACTUALIZACION,BORRADO E INSERCION **************************************************************************************************************************************************************
        //Consulta factura
        public bool consultarFactura(string sql)
        {
            try
            {
                dataset.Tables.Clear();
                adaptador = new SqlDataAdapter(sql, conector);
                adaptador.TableMappings.Add("FACTURA1", "DETALLE_FACTURA_PRODUCTO");
                dataset = new DataSet("tablas1");
                adaptador.Fill(dataset,"FACTURA");
                conector.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
//**************************************************METODOS DE CONSULTA,ACTUALIZACION,BORRADO E INSERCION ***********************************
        //Consultar
        public void consultar(string sql, string tabla)
        {
            dataset.Tables.Clear();
            adaptador = new SqlDataAdapter(sql,conector);
            comamdoBuilder= new SqlCommandBuilder(adaptador);
            adaptador.Fill(dataset,tabla);
        }
        //Login 
        public bool Login(string sql)
        {
            bool resultado = false;
            this.comando = new SqlCommand(sql, conector);
            this.conector.Open();
            SqlDataReader reg = null;
            reg = this.comando.ExecuteReader();
            if (reg.Read())
            {
                resultado = true;
            }
            else {
                resultado = false;
            }
            this.conector.Close();
            return resultado;
        }
        //Eliminar
        public bool eliminar(string tabla,string condicion)
        {
            conector.Open();
            string sql ="DELETE FROM "+tabla+" WHERE " +condicion ;
            comando = new SqlCommand(sql,conector);
            int i =comando.ExecuteNonQuery();
            conector.Close();
            if(i>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //actualizar
        public bool actualizar(string tabla,string campos, string condicion )
        {
            conector.Open();
            string sql="UPDATE "+ tabla +" SET "+campos+" WHERE " +condicion ;
            comando=new SqlCommand(sql,conector);
            int i=comando.ExecuteNonQuery();
            conector.Close();
            if(i>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //consultar Segunda forma(Login pone Usuario automatico en la factura)
        public DataTable consultar2(string tabla,string nombre,string pass)
        {
            string sql = "select * from "+tabla+" where NOMBRE_USUARIO ='" + nombre + "'and PASSWORD_USUARIO ='" + pass + "'";
            adaptador = new SqlDataAdapter(sql, conector);
            DataSet dataset2 = new DataSet();
            adaptador.Fill(dataset2, tabla);
            DataTable dataTable = new DataTable();
            dataTable = dataset2.Tables[tabla];
            return dataTable;
        }
        //insertar
        public bool insertar(string sql)
        {
            try
            {
                conector.Open();
                comando = new SqlCommand(sql, conector);
                int i = comando.ExecuteNonQuery();
                conector.Close();
                if (i > 0)
                {
                    conector.Close();
                    return true;
                }
                else
                {
                    conector.Close();
                    return false;
                }
            }
            catch (SqlException ) 
            {
                ultimoMensaje = "Los datos ingresados generan conflicto con datos de otro cliente ya registrado\nPor favor, verifique si el usuario ya esta registrado";
                conector.Close();
                return false;
            }
        }
               
    }
}
