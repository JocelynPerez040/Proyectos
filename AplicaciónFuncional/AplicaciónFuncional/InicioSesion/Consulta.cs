using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicaciónFuncional
{
    class Consulta
    {
        Conexion conex = new Conexion();
        SqlDataReader reader;

        /*Para conexion en registro*/
        public int Registro(Propiedades user)
        {
            reader.Close();
            conex.Abrir();
            string sql = "INSERT INTO InicioSesion (Usuario, Contrasena, Correo) VALUES(@txtUsuario, @txtContraseña, @txtCorreo)";
            SqlCommand comando = new SqlCommand(sql, conex.conexion);
            comando.Parameters.AddWithValue("@txtUsuario", user.Usuario);
            comando.Parameters.AddWithValue("@txtContraseña", user.Contraseña);
            comando.Parameters.AddWithValue("@txtCorreo", user.Correo);

            int res = comando.ExecuteNonQuery();
            conex.Cerrar();
            return res;
        }

        /*Para verficar usuarios con el mismo nombre*/
        public bool ExistenciaReg(string usuario)
        {
            conex.Abrir();
            string sql = "SELECT * FROM InicioSesion WHERE Usuario = @txtUsuario";
            SqlCommand comando = new SqlCommand(sql, conex.conexion);
            comando.Parameters.AddWithValue("@txtUsuario", usuario);
            reader = comando.ExecuteReader();            

            if (reader.HasRows)
            {
                conex.Cerrar();
                return true;
            }
            else
            {
                conex.Cerrar();
                return false;
            }
        }

        /*Para conexion en inicio sesion*/
        public Propiedades IniciarSesion(string usuario)
        {
            conex.Abrir();
            string sql = "SELECT Usuario, Contrasena, Correo FROM InicioSesion WHERE Usuario = @txtUsuario";
            SqlCommand comando = new SqlCommand(sql, conex.conexion);
            comando.Parameters.AddWithValue("@txtUsuario", usuario);
            reader = comando.ExecuteReader();
            Propiedades user = null;

            while (reader.Read())
            {
                user = new Propiedades();
                user.Usuario = reader["Usuario"].ToString();
                user.Contraseña = reader["Contrasena"].ToString();
                user.Correo = reader["Correo"].ToString();
            }
            reader.Close();            
            conex.Cerrar();
            return user;
        }

        /*Para enviar correo validación*/
        public Propiedades Correo(string usuario)
        {
            conex.Abrir();
            string sql = "SELECT Usuario, Contrasena, Correo FROM InicioSesion WHERE Usuario= @txtUsuario";
            SqlCommand comando = new SqlCommand(sql, conex.conexion);
            comando.Parameters.AddWithValue("@txtUsuario", usuario);
            reader = comando.ExecuteReader();
            Propiedades user = null;

            while (reader.Read())
            {
                user = new Propiedades();
                user.Usuario = reader["Usuario"].ToString();
                user.Contraseña = reader["Contrasena"].ToString();
                user.Correo = reader["Correo"].ToString();
            }
            reader.Close();            
            conex.Cerrar();
            return user;
        }
    }
}
