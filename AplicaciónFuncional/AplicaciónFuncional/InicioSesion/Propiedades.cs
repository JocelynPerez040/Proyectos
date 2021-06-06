using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicaciónFuncional
{
    class Propiedades
    {
        string usuario, contraseña, correo;

        public string Usuario
        {
            get => usuario; set => usuario = value;
        }
        public string Contraseña
        {
            get => contraseña; set => contraseña = value;
        }
        public string Correo
        {
            get => correo; set => correo = value;
        }
    }

    public class Mandar
    {
        public static string user;
    }
}
