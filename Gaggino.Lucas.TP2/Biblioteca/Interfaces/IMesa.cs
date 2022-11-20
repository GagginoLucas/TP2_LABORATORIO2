using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Interfaces
{
    public interface IMesa
    {

        public string MostrarCartasJ1 { get; set; }

        public void MostrarCartasJ1Metodo(string texto);

        public string MostrarCartasJ2 { get; set; }

        public void MostrarCartasJ2Metodo(string texto);

        public string MostrarPartida { get; set; }
        public void MostrarPartidaMetodo(string texto);


    }

}
