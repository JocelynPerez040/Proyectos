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
    public partial class frmInicioSesion : Form
    {
        int posX = 0;
        int posY = 0;

        public frmInicioSesion()
        {
            InitializeComponent();
            txtCorreo.Hide();
            picCorreo.Hide();
            lblAdvertencia.Visible = false;
            btnCrear.Visible = false;
            this.picFondo.Location = new System.Drawing.Point(1, 88);
        }

        /***PARA MOVER EL FORMULARIO***/
        private void picUsuarios_MouseMove(object sender, MouseEventArgs e)
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

        /***PARA CERRAR EL FORMULARIO*/
        private void picCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        /***BOTONES***/
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (txtContraseña.PasswordChar == '*')
            {
                this.btnMostrar.BackgroundImage = global::AplicaciónFuncional.Properties.Resources.ocultar;
                this.btnMostrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                txtContraseña.PasswordChar = '\0';
            }
            else
            {
                this.btnMostrar.BackgroundImage = global::AplicaciónFuncional.Properties.Resources.mostrar;
                this.btnMostrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                txtContraseña.PasswordChar = '*';
            }
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            this.btnMostrar.BackgroundImage = global::AplicaciónFuncional.Properties.Resources.mostrar;
            this.btnMostrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            txtCorreo.Hide();
            picCorreo.Hide();

            if ((txtUsuario.Text == "") || (txtContraseña.Text == ""))
            {
                lblAdvertencia.Visible = true;
                lblAdvertencia.Text = "¡Campo de Usuario o Contraseña vacíos!";
            }
            else
            {
                lblAdvertencia.Visible = false;
                frmMenu FBien = new frmMenu();
                this.Hide();
                FBien.Show();
            }
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            this.btnMostrar.BackgroundImage = global::AplicaciónFuncional.Properties.Resources.mostrar;
            this.btnMostrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            txtCorreo.Show();
            picCorreo.Show();
            lblAdvertencia.Visible = false;
            btnIniciarSesion.Visible = false;
            btnRegistro.Visible = false;
            btnCrear.Visible = true;
            txtUsuario.Text = "";
            txtContraseña.Text = "";
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if ((txtUsuario.Text == "") || (txtContraseña.Text == "") || (txtCorreo.Text == ""))
            {
                this.lblAdvertencia.Location = new System.Drawing.Point(17, 313);
                lblAdvertencia.Visible = true;
                lblAdvertencia.Text = "¡Campo de Usuario, Contraseña o Correo vacíos!";
            }
            else
            {
                lblAdvertencia.Visible = false;
                this.btnMostrar.BackgroundImage = global::AplicaciónFuncional.Properties.Resources.mostrar;
                this.btnMostrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                txtCorreo.Hide();
                picCorreo.Hide();
                btnIniciarSesion.Visible = true;
                btnRegistro.Visible = true;
                btnCrear.Visible = false;
                txtContraseña.PasswordChar = '*';
            }
        }

        
    }
}
