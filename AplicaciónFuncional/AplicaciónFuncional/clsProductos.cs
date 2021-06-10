using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace AplicaciónFuncional
{
    class clsProductos
    {
        Conexion conexion = new Conexion();
        string linea;

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

        public DataTable Importar(Stream st, char caracter, string ruta)
        {
            DataTable dtProductos = new DataTable();
            using (st)
            {
                StreamReader file = new System.IO.StreamReader(ruta);
                int colsCount = 0;
                int totalFilas = 0;
                int totalColumnas = 0;
                while ((linea = file.ReadLine()) != null)
                {
                    if (totalFilas == 0)
                    {
                        var obtenercol = linea.Split(caracter);
                        totalColumnas = obtenercol.Length;
                        foreach (string itemCol in obtenercol)
                        {
                            dtProductos.Columns.Add(itemCol.Split('\r')[0].Trim());
                        }
                        totalFilas++;
                    }
                    else
                    {
                        var obtenerfila = linea.Split(caracter);

                        DataRow drRow = dtProductos.NewRow();
                        foreach (var item in obtenerfila)
                        {
                            if (colsCount == 4)
                            {
                                colsCount = 0;
                            }
                            if (colsCount < totalColumnas)
                            {
                                drRow[colsCount] = item.Split('\r')[0].Trim();
                            }
                            colsCount++;
                        }
                        dtProductos.Rows.Add(drRow);
                    }
                }
                file.Close();
            }
            return dtProductos;
        }

        public void Guardar(DataGridView dgProd)
        {
            conexion.Abrir();
            string sql = "INSERT INTO Productos VALUES(@Codigo, @Descipcion, @Precio, @Unidades)";
            SqlCommand comando = new SqlCommand(sql, conexion.conexion);
            foreach (DataGridViewRow row in dgProd.Rows)
            {
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@Codigo", Convert.ToString(row.Cells["Código"].Value));
                comando.Parameters.AddWithValue("@Descipcion", Convert.ToString(row.Cells["Descripción"].Value));
                comando.Parameters.AddWithValue("@Precio", Convert.ToString(row.Cells["Precio"].Value));
                comando.Parameters.AddWithValue("@Unidades", Convert.ToString(row.Cells["Unidades"].Value));
                comando.ExecuteNonQuery();
            }
            conexion.Cerrar();
        }
    }
}
