using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AplicaciónFuncional
{
    class Conexion
    {
        string cadena = "Data Source= ;Initial Catalog= ;Integrated Security=True";
        public SqlConnection conexion = new SqlConnection();

        public Conexion() 
        {
            conexion.ConnectionString = cadena;
        }

        public void Abrir() 
        {
            try
            {
                conexion.Open();
                System.Windows.Forms.MessageBox.Show("Conexión abierta");
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al abrir la conexión"+ex.Message);
                throw;
            }
        }

        public void Cerrar() 
        {
            conexion.Close();
        }
    }
}
