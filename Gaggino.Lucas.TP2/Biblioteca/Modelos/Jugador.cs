using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Modelos
{
    public class Jugador : Persona
    {
        private int id;
        private int cantidadDePartidasJugadas = 0;
        private int cantidadDePartidasGanadas = 0;
        private int cantidadDePartidasPerdidas = 0;
        private int cantidadDeAnchosDeEspada = 0;
        private int cantidadDeAnchosDeBasto = 0;
        private int manosGanadas;
        private bool esMano;
        private bool cantóEnvido;
        private bool cantóTruco;
        private bool ganoElEnvido;
        private int puntaje;
        private int tantosEnvido;
        private Carta ultimaCartaJugada;
        private List<Carta> cartasEnMano;
        private bool estaEnPartida;

        public Jugador(int id, string nombre, string apellido, string usuario, int cantidadDePartidasGanadas, int cantidadDePartidasJugadas, int cantidadDePartidasPerdidas, int cantidadDeAnchosDeEspada, int cantidadDeAnchosDeBasto) : base(id, nombre, apellido, usuario)
        {

            Id = id;
            CantidadDePartidasJugadas = cantidadDePartidasJugadas;
            CantidadDePartidasGanadas = cantidadDePartidasGanadas;
            CantidadDePartidasPerdidas = cantidadDePartidasPerdidas;
            CantidadDeAnchosDeBasto = cantidadDeAnchosDeBasto;
            CantidadDeAnchosDeEspada = cantidadDeAnchosDeEspada;
            puntaje = 0;
        }

      

        public int CantidadDePartidasJugadas { get => cantidadDePartidasJugadas; set => cantidadDePartidasJugadas = value; }
        public int CantidadDePartidasGanadas { get => cantidadDePartidasGanadas; set => cantidadDePartidasGanadas = value; }
        public int CantidadDePartidasPerdidas { get => cantidadDePartidasPerdidas; set => cantidadDePartidasPerdidas = value; }
        public List<Carta> CartasEnMano { get => cartasEnMano; set => cartasEnMano = value; }
        public bool EsMano { get => esMano; set => esMano = value; }
        public int Puntaje { get => puntaje; set => puntaje = value; }

        public int ManosGanadas { get => manosGanadas; set => manosGanadas = value; }

        public bool CantóEnvido { get => cantóEnvido; set => cantóEnvido = value; }
        public Carta UltimaCartaJugada { get => ultimaCartaJugada; set => ultimaCartaJugada = value; }
        public int TantosEnvido { get => tantosEnvido; set => tantosEnvido = value; }
        public bool CantóTruco { get => cantóTruco; set => cantóTruco = value; }
        public bool GanoElEnvido { get => ganoElEnvido; set => ganoElEnvido = value; }
        public bool EstaEnPartida { get => estaEnPartida; set => estaEnPartida = value; }
        public int Id { get => id; set => id = value; }
        public int CantidadDeAnchosDeEspada { get => cantidadDeAnchosDeEspada; set => cantidadDeAnchosDeEspada = value; }
        public int CantidadDeAnchosDeBasto { get => cantidadDeAnchosDeBasto; set => cantidadDeAnchosDeBasto = value; }

        public override string ToString()
        {
            string jugador;
            jugador = usuario;
            return jugador;
        }

    }
}
