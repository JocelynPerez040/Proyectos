using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;

namespace AplicaciónFuncional
{
    class clsEstadisticas
    {
        Conexion conexion = new Conexion();
        public clsEstadisticas() { }
        public List<string> LLenarMes()
        {
            List<string> meses = new List<string>();
            conexion.Abrir();
            SqlCommand cmd = new SqlCommand("SELECT DISTINCT mes FROM Venta ", conexion.conexion);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                meses.Add(reader["mes"].ToString());
            }

            reader.Close();
            conexion.Cerrar();
            return meses;
        }

        public List<string> LLenarProducto()
        {
            List<string> meses = new List<string>();
            conexion.Abrir();
            SqlCommand cmd = new SqlCommand("SELECT Descripción FROM Productos", conexion.conexion);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                meses.Add(reader["Descripción"].ToString());
            }

            reader.Close();
            conexion.Cerrar();
            return meses;
        }
        public ArrayList CantidadProductos(string mes, int prod)
        {
            conexion.Abrir();

            ArrayList Cantidad = new ArrayList();
            SqlCommand command = new SqlCommand($"VentasMes '{mes}','{prod}'", conexion.conexion);
            SqlDataReader rd = command.ExecuteReader();

            while (rd.Read())
            {
                Cantidad.Add(rd.GetInt32(1));
            }
            conexion.Cerrar();
            rd.Close();
            return Cantidad;
        }
        public ArrayList NombreProductos(string mes, int prod)
        {
            conexion.Abrir();

            ArrayList Nombre = new ArrayList();
            SqlCommand command = new SqlCommand($"VentasMes '{mes}', '{prod}'", conexion.conexion);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Nombre.Add(reader.GetString(0));
            }
            conexion.Cerrar();
            reader.Close();
            return Nombre;
        }

        public int TraerCodigo(string Descripción)
        {
            int CodProducto = -1;
            conexion.Abrir();
            SqlCommand cmd = new SqlCommand("SELECT Código FROM Productos where Descripción = @Descripción", conexion.conexion);
            cmd.Parameters.AddWithValue("@Descripción", Descripción);
            cmd.ExecuteNonQuery();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                CodProducto = Convert.ToInt32(reader["Código"]);
            }

            reader.Close();
            conexion.Cerrar();
            return CodProducto;
        }

    }
}
