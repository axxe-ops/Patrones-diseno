using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronSingleton
{
    public class SESSIONMANAGER
    {
        public USUARIO usuarioLogueado;
        public DateTime fecha;

        private static SESSIONMANAGER instancia;
        private SESSIONMANAGER() { }

        public static SESSIONMANAGER ObtenerInstancia()
        {
            if (instancia == null)
            {
                throw new Exception("Sesion no iniciada.");
            }

            return instancia;
        }

        public USUARIO ObtenerUsuario()
        {
            return usuarioLogueado;
        }
        public static void Login(USUARIO usuario)
        {
            if(instancia == null)
            {
                instancia = new SESSIONMANAGER();
                instancia.usuarioLogueado = usuario;
                instancia.fecha = DateTime.Now;
            }
            else
            {
                throw new Exception("Ya hay una sesión activa.");
            }
        }

        public void Logout()
        {
            if (instancia != null)
            {
                instancia = null;
            }
            else
            {
                throw new Exception("Ya está cerrada tu sesion.");
            }

        }

        
    }
}
