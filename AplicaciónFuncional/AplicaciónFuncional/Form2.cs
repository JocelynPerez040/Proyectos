using System;
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
    public partial class frmMenu : Form
    {
        int posX = 0;
        int posY = 0;
        frmVentas FVen = new frmVentas();
        frmProductos FProd = new frmProductos();
        frmEstadisticas FEst = new frmEstadisticas();
        frmInicioSesion FInSes = new frmInicioSesion();

        public frmMenu()
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

        /***BOTONES***/
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha cerrado su sesión");            
            this.Hide();
            FInSes.Show();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {            
            this.Hide();
            FVen.Show();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {            
            this.Hide();
            FProd.Show();
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {            
            this.Hide();
            FEst.Show();
        }

        private void picVentas_Click(object sender, EventArgs e)
        {
            this.Hide();
            FVen.Show();
        }

        private void picProductos_Click(object sender, EventArgs e)
        {
            this.Hide();
            FProd.Show();
        }

        private void picEstadisticas_Click(object sender, EventArgs e)
        {
            this.Hide();
            FEst.Show();
        }

        private void picCerrarSesion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha cerrado su sesión");
            this.Hide();
            FInSes.Show();
        }
    }
}
