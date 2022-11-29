using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Interfaces;
using Biblioteca.Modelos;

namespace Biblioteca.Presentadores
{
    public class PresentadorLogin
    {
        ILogin viewLogin;
        int autocompletar = 0;
        List<Administrador>? admin;
        public PresentadorLogin(ILogin viewLogin)
        {
            this.viewLogin = viewLogin;
        }

        public bool Verificar()
        {
            admin = Conexiones.ObtenerAdministradores();
            foreach (Administrador administrador in admin)
            {
                if (viewLogin.Nombre == administrador.Usuario && viewLogin.Password == administrador.Contraseña)
                {
                    return true;
                }
            }
            return false;
        }

        public void MostrarError()
        {
            viewLogin.LabelError = "Usuario o contraseña incorrectos.";
        }

        public void AutoCompletarDatos()
        {
            admin = Conexiones.ObtenerAdministradores();
            viewLogin.Nombre = admin[autocompletar].Usuario;
            viewLogin.Password = admin[autocompletar].Contraseña;
            autocompletar++;

            if (autocompletar == admin.Count)
            {
                autocompletar = 0;
            }
        }

    }
}
