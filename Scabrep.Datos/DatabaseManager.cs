using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Scabrep.Datos
{
    public class DatabaseManager: IDisposable
    {
        private readonly string _connectionString = ConfigurationManager.AppSettings.Get("DefaultConnectionString");
        private SqlConnection _connection;

        public DatabaseManager()
        {
            if (_connection == null)
            {
                _connection = new SqlConnection(_connectionString);
                _connection.Open();
            }
        }

        public DataTable ConsultarDetalleFactura(int numeroFactura)
        {           
            using (var ds = new DataSet()) 
            {
                using (var command = new SqlCommand("CONSULTAR_DETALLE_FACTURA", _connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@NUMERO_FACTURA", numeroFactura);
                    using (var adapter = new SqlDataAdapter()) 
                    {
                        adapter.SelectCommand = command;
                        adapter.Fill(ds, "DetalleFactura");
                        return ds.Tables["DetalleFactura"];
                    }
                }
            }
        }
                
        public DataTable ConsultarCabeceraFactura(int numeroFactura)
        {
            using (var ds = new DataSet())
            {
                using (var command = new SqlCommand("CONSULTAR_CABECERA_FACTURA", _connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@NUMERO_FACTURA", numeroFactura);
                    using (var adapter = new SqlDataAdapter())
                    {
                        adapter.SelectCommand = command;
                        adapter.Fill(ds, "CabeceraFactura");
                        return ds.Tables["CabeceraFactura"];
                    }
                }
            }
        }

        public void Dispose()
        {
            _connection.Close();
            _connection.Dispose();
            _connection = null;
        }
    }
}
