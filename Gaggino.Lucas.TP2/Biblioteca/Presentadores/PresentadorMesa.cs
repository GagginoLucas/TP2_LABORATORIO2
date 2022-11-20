using Biblioteca.Interfaces;
using Biblioteca.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Net.Mime.MediaTypeNames;
using Microsoft.VisualBasic;

namespace Biblioteca.Presentadores
{
    public class PresentadorMesa
    {
        IMesa mesaView;
        Partida partida;

        public PresentadorMesa(IMesa mesaView, Partida miPartida)
        {
            this.mesaView = mesaView;
            partida = miPartida;
        }

        public void InstanciarDelegadosYEventos()
        {

            partida.MostrarLabels = MostrarCartas;
            partida.jugarPartida += RefrescarTextBoxYLabels;
            partida.eventoReiniciarPartida += ReiniciarLabels;
        }

        public void IrAtras()
        {
            partida.MostrarLabels -= MostrarCartas;
            partida.jugarPartida -= RefrescarTextBoxYLabels;
            partida.eventoReiniciarPartida -= ReiniciarLabels;
        }

        public void ReiniciarLabels()
        {
 
            mesaView.MostrarCartasJ1Metodo(string.Empty);
            mesaView.MostrarCartasJ2Metodo(string.Empty);

        }

        public void MostrarCartas(string cartaj1, string cartaj2)
        {
            mesaView.MostrarCartasJ1Metodo(cartaj1);
            mesaView.MostrarCartasJ2Metodo(cartaj2);
        }

       

        public void EscribirPartidaEnString(string texto)
        {
            if (texto != "")
            {
                partida.Resumen += texto + System.Environment.NewLine;
            }
        }
        
        public void RefrescarTextBoxYLabels()
        {
            mesaView.MostrarPartidaMetodo(partida.Resumen);
        }
    }
}
