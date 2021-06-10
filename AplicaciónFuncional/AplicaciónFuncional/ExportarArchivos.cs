using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using SpreadsheetLight;
using System.Windows.Forms;

namespace AplicaciónFuncional
{
    class ExportarArchivos 
    {
        Conexion conexion = new Conexion();

        public void ExportarCSV(string ruta)
        {
            conexion.Abrir();
            SqlDataAdapter adap = new SqlDataAdapter("SELECT * FROM Productos",conexion.conexion);
            DataTable tabla = new DataTable();
            adap.Fill(tabla);

            List<string> lineas = new List<string>(), columnas = new List<string>();

            foreach (DataColumn col in tabla.Columns) columnas.Add(col.ColumnName);

            lineas.Add(string.Join(",",columnas));
            
            foreach(DataRow fila in tabla.Rows)
            {
                List<string> celdas = new List<string>();
                foreach (object celda in fila.ItemArray) celdas.Add(celda.ToString());

                lineas.Add(string.Join(",", celdas));
            }

            File.WriteAllLines(ruta, lineas);
            conexion.Cerrar();
        }
       
    }
}
