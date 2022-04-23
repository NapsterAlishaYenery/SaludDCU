using SaludDCU.Layers.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludDCU.Layers.Business
{
    public class QueryTables
    {
        private SQL_Connection _connection = new SQL_Connection();
        SqlDataReader _reader;
        DataTable _table = new DataTable();
        SqlCommand _command = new SqlCommand();

        //Query TABLA DOCTORES
        public DataTable MostrarTablaDoctores()
        {
            //Mostrando Datos Por Procedimientos Almacenados
            //NOTA(Se deben crear en SQL Server Primero)
            _command.Connection = _connection.AbrirConexion();
            _command.CommandText = "Select_Doctores";
            _command.CommandType = CommandType.StoredProcedure;
            _reader = _command.ExecuteReader();
            _table.Clear();
            _table.Load(_reader);
            _connection.CerrarConexion();
            return _table;
        }

        public void InsertarDoctores(string user, string password, string name, string lastname, string specialty, DateTime fecha, string position, float salario)
        {

            //Insertar Datos Por Procedimientos Almacenado
            //NOTA(Se deben crear en SQL Server Primero)
            _command.Connection = _connection.AbrirConexion();
            _command.CommandText = "Insert_Doctores";
            _command.CommandType = CommandType.StoredProcedure;
            _command.Parameters.AddWithValue("@Users", user);
            _command.Parameters.AddWithValue("@Passwords", password);
            _command.Parameters.AddWithValue("@Names", name);
            _command.Parameters.AddWithValue("@LastNames", lastname);
            _command.Parameters.AddWithValue("@Specilaty", specialty);
            _command.Parameters.AddWithValue("@DateOfBirth", fecha);
            _command.Parameters.AddWithValue("@Position", position);
            _command.Parameters.AddWithValue("@Salary", salario);
            _command.ExecuteNonQuery();
            _command.Parameters.Clear();
        }

        public void EditarDoctors(string user, string password, string name, string lastname, string specialty, DateTime fecha, string position, float salario, int ID)
        {
            //Actualizar Datos Por Procedimientos Almacenado
            //NOTA(Se deben crear en SQL Server Primero)
            _command.Connection = _connection.AbrirConexion();
            _command.CommandText = "Update_Doctores";
            _command.CommandType = CommandType.StoredProcedure;
            _command.Parameters.AddWithValue("@Users", user);
            _command.Parameters.AddWithValue("@Passwords", password);
            _command.Parameters.AddWithValue("@Names", name);
            _command.Parameters.AddWithValue("@LastNames", lastname);
            _command.Parameters.AddWithValue("@Specilaty", specialty);
            _command.Parameters.AddWithValue("@DateOfBirth", fecha);
            _command.Parameters.AddWithValue("@Position", position);
            _command.Parameters.AddWithValue("@Salary", salario);
            _command.Parameters.AddWithValue("@Id", ID);
            _command.ExecuteNonQuery();
            _command.Parameters.Clear();
        }

        public void EliminarDoctor(int id)
        {
            //Eliminar Datos Por Procedimientos Almacenado
            //NOTA(Se deben crear en SQL Server Primero)
            _command.Connection = _connection.AbrirConexion();
            _command.CommandText = "Delete_Doctores";
            _command.CommandType = CommandType.StoredProcedure;
            _command.Parameters.AddWithValue("@Id", id);
            _command.ExecuteNonQuery();
            _command.Parameters.Clear();
        }


        //Query TABLA MEDICINA
        public DataTable MostrarTablaMedicamentos()
        {
            //Mostrando Datos Por Procedimientos Almacenados
            //NOTA(Se deben crear en SQL Server Primero)
            _command.Connection = _connection.AbrirConexion();
            _command.CommandText = "Select_Medicine";
            _command.CommandType = CommandType.StoredProcedure;
            _reader = _command.ExecuteReader();
            _table.Clear();
            _table.Load(_reader);
            _connection.CerrarConexion();
            return _table;
        }

        public void InsertarMedicamentos(string name, string lab, string typeMedicine, string Comentary, float price)
        {

            //Insertar Datos Por Procedimientos Almacenado
            //NOTA(Se deben crear en SQL Server Primero)
            _command.Connection = _connection.AbrirConexion();
            _command.CommandText = "Insert_Medicine";
            _command.CommandType = CommandType.StoredProcedure;
            _command.Parameters.AddWithValue("@Names", name);
            _command.Parameters.AddWithValue("@Laboratory", lab);
            _command.Parameters.AddWithValue("@TypeMedicine", typeMedicine);
            _command.Parameters.AddWithValue("@Comentary", Comentary);
            _command.Parameters.AddWithValue("@Prices", price);
            _command.ExecuteNonQuery();
            _command.Parameters.Clear();
        }

        public void EditarMedicamentos(string name, string lab, string typeMedicine, string Comentary, float price, int ID)
        {
            //Actualizar Datos Por Procedimientos Almacenado
            //NOTA(Se deben crear en SQL Server Primero)
            _command.Connection = _connection.AbrirConexion();
            _command.CommandText = "Update_Medicine";
            _command.CommandType = CommandType.StoredProcedure;
            _command.Parameters.AddWithValue("@Names", name);
            _command.Parameters.AddWithValue("@Laboratory", lab);
            _command.Parameters.AddWithValue("@TypeMedicine", typeMedicine);
            _command.Parameters.AddWithValue("@Comentary", Comentary);
            _command.Parameters.AddWithValue("@Prices", price);
            _command.Parameters.AddWithValue("@Id", ID);
            _command.ExecuteNonQuery();
            _command.Parameters.Clear();
        }

        public void EliminarMedicamentos(int id)
        {
            //Eliminar Datos Por Procedimientos Almacenado
            //NOTA(Se deben crear en SQL Server Primero)
            _command.Connection = _connection.AbrirConexion();
            _command.CommandText = "Delete_Medicine";
            _command.CommandType = CommandType.StoredProcedure;
            _command.Parameters.AddWithValue("@Id", id);
            _command.ExecuteNonQuery();
            _command.Parameters.Clear();
        }

    }
}
