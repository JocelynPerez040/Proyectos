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
        Conexion conex = new Conexion();
        Propiedades user = new Propiedades();
        Validacion val = new Validacion();

        public frmInicioSesion()
        {
            InitializeComponent();
            txtCorreo.Hide();
            txtCorreo.Enabled = false;
            picCorreo.Hide();
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
                conex.Cerrar();
                Application.Exit();
            }
        }

        /***LABEL LINK***/
        private void lbkOlvido_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                MessageBox.Show("El campo de usuario está vacío. \n" +
                    "Por favor digita tu usuario para enviar tu contraseña a tu correo electrónico.");
            }
            else
            {
                string usuario = txtUsuario.Text;
                try
                {
                    string res = val.valCorreo(usuario);
                    //Mira errores
                    if (res.Length > 0)
                    {
                        MessageBox.Show(res, "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtUsuario.Text = "";
                        conex.Cerrar();
                    }
                    else
                    {
                        MessageBox.Show("¡Correo enviado! \nRevise su bandeja de entrada ó su bandeja de spam.", "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conex.Cerrar();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error \n" + ex.Message);
                }
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

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            this.btnMostrar.BackgroundImage = global::AplicaciónFuncional.Properties.Resources.mostrar;
            this.btnMostrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            txtCorreo.Show();
            txtCorreo.Enabled = true;
            picCorreo.Show();
            btnIniciarSesion.Visible = false;
            btnRegistro.Visible = false;
            btnCrear.Visible = true;
            lbkOlvido.Visible = false;
            txtUsuario.Text = "";
            txtContraseña.Text = "";
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (("@txtUsuario.Text" == "") || ("@txtContraseña.Text" == "") || (txtCorreo.Text == ""))
            {
                MessageBox.Show("¡Campos vacíos! \nDiligencia todos los campos para continuar", "Aviso");
            }
            else
            {
                this.btnMostrar.BackgroundImage = global::AplicaciónFuncional.Properties.Resources.mostrar;
                this.btnMostrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                txtContraseña.PasswordChar = '*';

                user.Usuario = txtUsuario.Text;
                user.Contraseña = txtContraseña.Text;
                user.Correo = txtCorreo.Text;

                try
                {
                    string res = val.valRegistro(user);

                    //Mira si hay errores
                    if (res.Length > 0)
                    {
                        MessageBox.Show(res, "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtUsuario.Text = "";
                        conex.Cerrar();
                    }
                    else
                    {
                        MessageBox.Show("Usuario resgistrado exitosamente", "¡Aviso!", MessageBoxButtons.OK);
                        txtCorreo.Hide();
                        txtCorreo.Enabled = false;
                        picCorreo.Hide();
                        btnIniciarSesion.Visible = true;
                        btnRegistro.Visible = true;
                        btnCrear.Visible = false;
                        lbkOlvido.Visible = true;
                        txtCorreo.Text = "";
                        conex.Cerrar();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error \n" + ex.Message);
                }
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
                MessageBox.Show("¡Campos vacíos! \nDiligencia todos los campos para continuar", "Aviso");
            }
            else
            {
                string usuario = txtUsuario.Text;
                string contraseña = txtContraseña.Text;

                try
                {
                    string res = val.valIniciarSesion(usuario, contraseña);

                    //Mira si hay errores
                    if (res.Length > 0)
                    {
                        MessageBox.Show(res, "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtContraseña.Text = "";
                        txtUsuario.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Inicio exitoso");
                        frmMenu FMen = new frmMenu();
                        this.Hide();
                        FMen.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error \n" + ex.Message);
                }
            }
        }

        /***CAJAS DE TEXTO***/
        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtCorreo.Enabled == false)
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {                
                    btnIniciarSesion_Click(sender, e);  //llamar el metodo
                }
            }
            else
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    btnCrear_Click(sender, e);  //llamar el metodo
                }
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtCorreo.Enabled == false)
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    btnIniciarSesion_Click(sender, e);  //llamar el metodo
                }
            }
            else
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    btnCrear_Click(sender, e);  //llamar el metodo
                }
            }
        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtCorreo.Enabled == false)
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    btnIniciarSesion_Click(sender, e);  //llamar el metodo
                }
            }
            else
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    btnCrear_Click(sender, e);  //llamar el metodo
                }
            }
        }
    }
}
