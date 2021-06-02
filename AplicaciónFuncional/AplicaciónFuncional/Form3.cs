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
    public partial class frmVentas : Form
    {
        int posX = 0;
        int posY = 0;

        public frmVentas()
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

        /***PARA IR ATRÁS***/
        private void picAtras_Click(object sender, EventArgs e)
        {
            frmMenu FMen = new frmMenu();
            this.Hide();
            FMen.Show();
        }        
    }
}
