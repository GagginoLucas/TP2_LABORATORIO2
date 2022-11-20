using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Interfaces;

namespace Biblioteca.Presentadores
{
    public class PresentadorAgregarPartida
    {
        
        IAgregarPartida viewAgregarPartida;

        public PresentadorAgregarPartida(IAgregarPartida viewAgregarPartida)
        {
            this.viewAgregarPartida = viewAgregarPartida;
        }

        public void MostrarError(string error)
        {
            viewAgregarPartida.LabelError = error;
        }

    }
}
