using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludDCU.Layers.Datos
{
    internal class SQL_Connection
    {
        private SqlConnection Conexion = new SqlConnection("Data Source=DESKTOP-2SEPMPI;Initial Catalog=AliYenCareHospital_DB;Integrated Security=True");

        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == System.Data.ConnectionState.Closed)
            {
                Conexion.Open();
            }
            return Conexion;
        }

        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == System.Data.ConnectionState.Open)
            {
                Conexion.Close();
            }
            return Conexion;
        }
    }
}
