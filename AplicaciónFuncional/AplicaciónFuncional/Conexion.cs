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
        string cadena = "Data Source= localhost\\SQLEXPRESS;Initial Catalog=AplicacionFuncional ;Integrated Security=True";
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
                //System.Windows.Forms.MessageBox.Show("Abierta");
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al abrir la conexión" + ex.Message);
            }
        }

        public void Cerrar()
        {
            try
            {
                
                conexion.Close();
                //System.Windows.Forms.MessageBox.Show("Cerrada");
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al abrir la conexión" + ex.Message);
            }
        }
    }
}
