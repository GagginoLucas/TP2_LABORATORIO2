using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Interfaces
{
    public interface IAgregarJugador
    {
        string Nombre { get; set; }
        string Apellido { get; set; }
        string Usuario { get; set; }
        string Error { get; set; }

    }
}
