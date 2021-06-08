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
            SqlConnection Conexion = new SqlConnection("server = localhost\\SQLEXPRESS; database = Funcional; Integrated Security = True");
            Conexion.Open();

            string ingresar = "insert into Productos values(@Código, @Descripción, @Precio, @Unidades)";
            SqlCommand sql = new SqlCommand(ingresar, Conexion);

            sql.Parameters.AddWithValue("@Código", this.Código);
            sql.Parameters.AddWithValue("@Descripción", this.Descripción);
            sql.Parameters.AddWithValue("@Precio", this.Precio);
            sql.Parameters.AddWithValue("@Unidades", this.Unidades);
            sql.ExecuteNonQuery();

            Conexion.Close();
            return true;
        }

        public bool Descontinuar(int Código)
        {
            SqlConnection Conexion = new SqlConnection("server = localhost\\SQLEXPRESS; database = Funcional; Integrated Security = True");
            Conexion.Open();

            this.Código = Código;
            string eliminar = "delete Productos where Código = @Código";
            SqlCommand sql = new SqlCommand(eliminar, Conexion);
            sql.Parameters.AddWithValue("@Código", this.Código);
            sql.ExecuteNonQuery();

            Conexion.Close();
            return true;
        }

        public bool Modificar()
        {
            SqlConnection Conexion = new SqlConnection("server = localhost\\SQLEXPRESS; database = Funcional; Integrated Security = True");
            Conexion.Open();

            string Modificar = "update Productos set Código = @Código, Descripción = @Descripción, Precio = @Precio, Unidades = @Unidades where Código = @Código";
            SqlCommand sql = new SqlCommand(Modificar, Conexion);

            sql.Parameters.AddWithValue("@Código", this.Código);
            sql.Parameters.AddWithValue("@Descripción", this.Descripción);
            sql.Parameters.AddWithValue("@Precio", this.Precio);
            sql.Parameters.AddWithValue("@Unidades", this.Unidades);
            sql.ExecuteNonQuery();

            Conexion.Close();
            return true;
        }

        public DataTable Consultar()
        {
            SqlConnection Conexion = new SqlConnection("server = localhost\\SQLEXPRESS; database = Funcional; Integrated Security = True");
            Conexion.Open();

            DataTable dataTable = new DataTable();
            string Consulta = "select Código, Descripción, Precio, Unidades from Productos";
            SqlCommand sql = new SqlCommand(Consulta, Conexion);

            SqlDataAdapter sqlData = new SqlDataAdapter(sql);
            sqlData.Fill(dataTable);

            Conexion.Close();
            return dataTable;

        }

        public DataTable Seleccionar(int Código)
        {
            SqlConnection Conexion = new SqlConnection("server = localhost\\SQLEXPRESS; database = Funcional; Integrated Security = True");
            Conexion.Open();

            this.Código = Código;
            DataTable data = new DataTable();
            string Seleccionar = "select Código, Descripción, Precio, Unidades from Productos where Código = @Código";
            SqlCommand sql = new SqlCommand(Seleccionar, Conexion);

            sql.Parameters.AddWithValue("@Código", this.Código);
            SqlDataAdapter sqlData = new SqlDataAdapter(sql);

            sqlData.Fill(data);

            Conexion.Close();
            return data;
        }
    }
}
