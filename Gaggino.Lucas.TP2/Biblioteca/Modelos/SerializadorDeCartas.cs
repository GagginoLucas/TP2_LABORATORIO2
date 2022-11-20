using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Modelos
{
    public class SerializadorDeCartas
    {
        List<Carta> cartas;

        public SerializadorDeCartas()
        {
            cartas = new List<Carta>();
        }

        public List<Carta> Cartas { get => cartas; set => cartas = value; }
    }
}
