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
        string miPartida;

        public PresentadorMesa(IMesa mesaView, Partida miPartida)
        {
            this.mesaView = mesaView;
            partida = miPartida;
        }

        public void InstanciarDelegadosYEventos()
        {
            //partida.mostrarTantosEnvido += CantarTantosEnvido;

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
            //if (lblTurnoJugador.InvokeRequired)
            //{
            //    SetTextCallback d = new SetTextCallback(Informacion);
            //    this.Invoke(d, new object[] { partidaActual });
            //}
            //else
            mesaView.MostrarCartasJ1Metodo(string.Empty);
            mesaView.MostrarCartasJ2Metodo(string.Empty);

        }

        public void MostrarCartas(string cartaj1, string cartaj2)
        {
            mesaView.MostrarCartasJ1Metodo(cartaj1);
            mesaView.MostrarCartasJ2Metodo(cartaj2);
        }

        //public void ControlarEstadoDelEnvido()
        //{
        //    if (partida.Jugador1.TantosEnvido != 0 && partida.Jugador2.TantosEnvido != 0 && partida.EnvidoFinalizado == false)
        //    {
        //        CantarTantosEnvido();
        //        partida.CompararTantosDelEnvido();
        //        MostrarLabelGanadorDelEnvido();
        //        partida.EnvidoFinalizado = true;
        //        partida.FlagSeEstaJugandoElEnvido = false;

        //    }
        //    else if (partida.EnvidoFinalizado == false && partida.FlagNoQuisoEnvido == true)
        //    {
        //        partida.FlagSeEstaJugandoElEnvido = false;
        //        partida.EnvidoFinalizado = true;
        //    }
        //}

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


        //public void ActualizarLabelPuntaje() 
        //{
        //    mesaView.MostrarPuntajeJ1 = String.Empty;
        //    mesaView.MostrarPuntajeJ1 = $"Puntaje de {partida.Jugador1.Usuario}: {partida.Jugador1.Puntaje} ";
        //    mesaView.MostrarPuntajeJ2 = String.Empty;
        //    mesaView.MostrarPuntajeJ2 = $"Puntaje de {partida.Jugador2.Usuario}: {partida.Jugador2.Puntaje} ";
        //}
       
    }
}
