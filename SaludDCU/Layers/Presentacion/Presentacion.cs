using SaludDCU.Layers.Business;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludDCU.Layers.Presentacion
{
    public class Presentacion
    {
        private QueryTables objetoGE = new QueryTables();

        //Metodos Para Tabla Doctores
        public DataTable MostrarTablaDoctores()
        {
            DataTable tabla;
            tabla = objetoGE.MostrarTablaDoctores();
            return tabla;
        }

        public void InsertarDoctores(string user, string password, string name, string lastname, string specialty, DateTime fecha, string position, float salario)
        {
            objetoGE.InsertarDoctores(user, password, name, lastname, specialty, fecha, position, salario);
        }

        public void EditarDoctores(string user, string password, string name, string lastname, string specialty, DateTime fecha, string position, float salario, int ID)
        {
            objetoGE.EditarDoctors(user, password, name, lastname, specialty, fecha, position, salario, ID);
        }

        public void EliminarDoctores(int id)
        {
            objetoGE.EliminarDoctor(id);
        }

        //Metodos Para Tabla Medicina
        public DataTable MostrarTablaMedicine()
        {
            DataTable tabla;
            tabla = objetoGE.MostrarTablaMedicamentos();
            return tabla;
        }
        public void InsertarMedicine(string name, string lab, string typeMedicine, string Comentary, float price)
        {
            objetoGE.InsertarMedicamentos(name, lab, typeMedicine, Comentary, price);
        }

        public void EditarMedicine(string name, string lab, string typeMedicine, string Comentary, float price, int ID)
        {
            objetoGE.EditarMedicamentos(name, lab, typeMedicine, Comentary, price, ID);
        }

        public void EliminarMedicine(int id)
        {
            objetoGE.EliminarMedicamentos(id);
        }
    }
}
