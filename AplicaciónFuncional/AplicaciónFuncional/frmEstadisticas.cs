using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AplicaciónFuncional
{
    public partial class frmEstadisticas : Form
    {
        int posX = 0;
        int posY = 0;

        public frmEstadisticas()
        {
            InitializeComponent();
        }

        /***PARA MOVER EL FORMULARIO***/
        private void pnlMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }
        }

        /***PARA CERRAR EL FORMULARIO***/
        private void picCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        /***PARA IR ATRAS***/
        private void picAtras_Click(object sender, EventArgs e)
        {
            frmMenu FMen = new frmMenu();
            this.Hide();
            FMen.Show();
        }

        private void frmEstadisticas_Load(object sender, EventArgs e)
        {
            clsEstadisticas estadisticas = new clsEstadisticas();
            cmbMes.Items.AddRange(estadisticas.LLenarMes().ToArray());
            cmbProducto.Items.AddRange(estadisticas.LLenarProducto().ToArray());
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            clsEstadisticas Est = new clsEstadisticas();
            string mes = cmbMes.Text;
            int prod = Est.TraerCodigo(cmbProducto.Text);
            crtEstadisticas.Series[0].Points.DataBindXY(Est.NombreProductos(mes, prod).ToArray(), Est.CantidadProductos(mes, prod));
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileCSV = new SaveFileDialog() { Filter = "Archivo CSV|*.csv" };
            if(saveFileCSV.ShowDialog() == DialogResult.OK)
            {
                ExportarArchivos EA = new ExportarArchivos();
                EA.ExportarCSV(saveFileCSV.FileName);
                MessageBox.Show("Se ha exportato la base de datos correctamente correctamente ");
            }
        }

      
    }
}
