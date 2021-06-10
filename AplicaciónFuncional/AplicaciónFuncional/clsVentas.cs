using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AplicaciónFuncional
{
    class clsVentas
    {
        Conexion conexion = new Conexion();

        public string Mes { get; set; }
        public int CanVendida { get; set; }
        public int Código { get; set; }
        public string Descripción { get; set; }        

        public clsVentas()
        {
        }

        public clsVentas(string Mes, int CanVendida, int Código)
        {
            this.Mes = Mes;
            this.CanVendida = CanVendida;
            this.Código = Código;
        }

        public bool AgregarVenta()
        {
            conexion.Abrir();
            string IngresarVenta = "insert into Venta values(@Mes, @CanVendida, @Código)";
            SqlCommand sql = new SqlCommand(IngresarVenta, conexion.conexion);

            sql.Parameters.AddWithValue("@Mes", this.Mes);
            sql.Parameters.AddWithValue("@CanVendida", this.CanVendida);
            sql.Parameters.AddWithValue("@Código", this.Código);
            sql.ExecuteNonQuery();

            conexion.Cerrar();
            return true;
        }

        public DataTable ConsultarVenta()
        {
            conexion.Abrir();

            DataTable dataTable = new DataTable();
            string ConsultaVenta = "VentaProd";
            SqlCommand sql = new SqlCommand(ConsultaVenta, conexion.conexion);

            SqlDataAdapter sqlData = new SqlDataAdapter(sql);
            sqlData.Fill(dataTable);

            conexion.Cerrar();
            return dataTable;

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


        public List<string> LlenarCbxProducto()
        {
            List<string> Productos = new List<string>();
            conexion.Abrir();
            SqlCommand cmd = new SqlCommand("SELECT Descripción FROM Productos", conexion.conexion);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Productos.Add(reader["Descripción"].ToString());
            }

            reader.Close();
            conexion.Cerrar();
            return Productos;
        }
    }
}
