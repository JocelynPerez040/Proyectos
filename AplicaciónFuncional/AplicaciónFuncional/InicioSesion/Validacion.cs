using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicaciónFuncional
{
    class Validacion
    {
        Consulta consul = new Consulta();
        Recuperar rec = new Recuperar();


        /*Para validar registro*/
        public string valRegistro(Propiedades user)
        {
            string res = "";

            if (consul.ExistenciaReg(user.Usuario))
            {
                res = "¡El nombre de usuario que ingresaste ya existe! \n Intenta con otro.";
            }
            else
            {
                consul.Registro(user);
            }
            return res;
        }

        /*Para validar inicio sesion*/
        public string valIniciarSesion(string usuario, string contraseña)
        {
            string res = "";
            Propiedades user = null;
            user = consul.IniciarSesion(usuario);

            if (user == null)
            {
                res = "El usuario ingresado no existe";
            }
            else
            {
                if (user.Contraseña != contraseña)
                {
                    res = "El usuario y/o contraseña no coinciden";
                }
                else
                {
                    Mandar.user = user.Usuario;
                }
            }
            return res;
        }

        /*Para validar y enviar correo de recuperación*/
        public string valCorreo(string usuario)
        {
            string res = "";
            Propiedades user = null;
            user = consul.Correo(usuario);

            if (user == null)
            {
                res = "El usuario ingresado no existe";
            }
            else
            {
                rec.EnviarCorreo(user.Usuario, user.Contraseña, user.Correo);
            }
            return res;
        }
    }
}
