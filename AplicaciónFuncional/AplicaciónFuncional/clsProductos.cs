using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AplicaciónFuncional
{
    class clsProductos
    {
        public int Código { get; set; }
        public string Descripción { get; set; }
        public double Precio { get; set; }
        public int Unidades { get; set; }

        Conexion conexion = new Conexion();

        public clsProductos()
        {
        }

        public clsProductos(int Código, string Descripción, double Precio, int Unidades)
        {
            this.Código = Código;
            this.Descripción = Descripción;
            this.Precio = Precio;
            this.Unidades = Unidades;
        }

        public bool Ingresar()
        {
            conexion.Abrir();
            string ingresar = "insert into Productos values(@Código, @Descripción, @Precio, @Unidades)";
            SqlCommand sql = new SqlCommand(ingresar, conexion.conexion);

            sql.Parameters.AddWithValue("@Código", this.Código);
            sql.Parameters.AddWithValue("@Descripción", this.Descripción);
            sql.Parameters.AddWithValue("@Precio", this.Precio);
            sql.Parameters.AddWithValue("@Unidades", this.Unidades);
            sql.ExecuteNonQuery();

            conexion.Cerrar();
            return true;
        }

        public bool Descontinuar(int Código)
        {
            conexion.Abrir();

            this.Código = Código;
            string eliminar = "delete Productos where Código = @Código";
            SqlCommand sql = new SqlCommand(eliminar, conexion.conexion);
            sql.Parameters.AddWithValue("@Código", this.Código);
            sql.ExecuteNonQuery();

            conexion.Cerrar();
            return true;
        }

        public bool Modificar()
        {
            conexion.Abrir();

            string Modificar = "update Productos set Código = @Código, Descripción = @Descripción, Precio = @Precio, Unidades = @Unidades where Código = @Código";
            SqlCommand sql = new SqlCommand(Modificar, conexion.conexion);

            sql.Parameters.AddWithValue("@Código", this.Código);
            sql.Parameters.AddWithValue("@Descripción", this.Descripción);
            sql.Parameters.AddWithValue("@Precio", this.Precio);
            sql.Parameters.AddWithValue("@Unidades", this.Unidades);
            sql.ExecuteNonQuery();

            conexion.Cerrar();
            return true;
        }

        public DataTable Consultar()
        {
            conexion.Abrir();

            DataTable dataTable = new DataTable();
            string Consulta = "select Código, Descripción, Precio, Unidades from Productos";
            SqlCommand sql = new SqlCommand(Consulta, conexion.conexion);

            SqlDataAdapter sqlData = new SqlDataAdapter(sql);
            sqlData.Fill(dataTable);

            conexion.Cerrar();
            return dataTable;

        }

        public DataTable Seleccionar(int Código)
        {
            conexion.Abrir();

            this.Código = Código;
            DataTable data = new DataTable();
            string Seleccionar = "select Código, Descripción, Precio, Unidades from Productos where Código = @Código";
            SqlCommand sql = new SqlCommand(Seleccionar, conexion.conexion);

            sql.Parameters.AddWithValue("@Código", this.Código);
            SqlDataAdapter sqlData = new SqlDataAdapter(sql);

            sqlData.Fill(data);

            conexion.Cerrar();
            return data;
        }
    }
}
