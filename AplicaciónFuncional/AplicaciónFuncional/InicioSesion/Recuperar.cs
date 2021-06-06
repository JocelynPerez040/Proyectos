using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace AplicaciónFuncional
{
    class Recuperar
    {
        public void EnviarCorreo(string usuario, string contrasena, string correo)
        {
            string contraseña = this.Contrasena;
            string mensaje = string.Empty;
            string destinatario = correo;
            string remitente = "jocelynmischelp@gmail.com";
            string asunto = "Recuperación de contraseña Aplicación Contabiliza tu Tienda";
            string cuerpoDelMesaje = "Hola! \nHas solicitado recuperar tu contraseña en la aplicación " +
                "Contabiliza tu tienda. \nTe la hemos traido junto con tu nombre de usuario para que puedas " +
                "navegar por nuestra aplicación cuanto antes: \n Usuario: " + usuario + "\n Contraseña: " + contrasena +
                "\n \nEs un placer para nosotros servirte. \nQue tengas un feliz día"; ;
            MailMessage ms = new MailMessage(remitente, destinatario, asunto, cuerpoDelMesaje);

            SmtpClient smtp = new SmtpClient("smtp.live.com", 587);
            smtp.EnableSsl = true;
            smtp.Credentials = new NetworkCredential("jocelynmischelp@gmail.com", contraseña);

            try
            {
                Task.Run(() =>
                {
                    smtp.Send(ms);
                    ms.Dispose();
                }
                );
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al enviar correo electronico: " + ex.Message);
            }
        }

        public string Contrasena
        {
            get
            { return "Winy-2002"; }
        }
    }
}
