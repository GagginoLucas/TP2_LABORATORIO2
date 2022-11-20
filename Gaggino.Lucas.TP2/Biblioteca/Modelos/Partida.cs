using Biblioteca.Presentadores;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Modelos
{
    public class Partida
    {
        private List<Carta> mazoDeCartas = new List<Carta>();
        private Jugador jugador1;
        private Jugador jugador2;
        private string ganador;
        private string resumen = "";

        private string ganadorDeLaPartida;
        private string perdedorDeLaPartida;
        private DateTime fecha;


        private Jugador ganadorPrimerMano;
        private bool primerManoParda;
        private bool segundaManoParda;
        private bool tercerManoParda;
        private int cantidadDeTurnos;


        public event Action eventoReiniciarPartida;
        public Action jugarPartida;
        public Action<string> MostrarTextos;
        public Action<string, string> MostrarLabels;

        public Task tarea;

        bool flagSeCantoElEnvido = false;
        bool flagSeCantóTruco = false;
        bool flagSeEstaJugandoElEnvido = false;
        bool envidoFinalizado = false;
        bool trucoFinalizado = false;
        bool flagNoQuisoEnvido = false;
        bool terminoLaPartida = false;

        public Jugador Jugador1 { get => jugador1; set => jugador1 = value; }
        public Jugador Jugador2 { get => jugador2; set => jugador2 = value; }
        public string Ganador { get => ganador; set => ganador = value; }
        public int CantidadDeTurnos { get => cantidadDeTurnos; set => cantidadDeTurnos = value; }
        public bool PrimerManoParda { get => primerManoParda; set => primerManoParda = value; }
        public bool SegundaManoParda { get => segundaManoParda; set => segundaManoParda = value; }
        public bool TercerManoParda { get => tercerManoParda; set => tercerManoParda = value; }
        public bool FlagSeCantoElEnvido { get => flagSeCantoElEnvido; set => flagSeCantoElEnvido = value; }
        public bool FlagSeCantóTruco { get => flagSeCantóTruco; set => flagSeCantóTruco = value; }
        public bool FlagSeEstaJugandoElEnvido { get => flagSeEstaJugandoElEnvido; set => flagSeEstaJugandoElEnvido = value; }
        public bool EnvidoFinalizado { get => envidoFinalizado; set => envidoFinalizado = value; }
        public bool TrucoFinalizado { get => trucoFinalizado; set => trucoFinalizado = value; }
        public bool FlagNoQuisoEnvido { get => flagNoQuisoEnvido; set => flagNoQuisoEnvido = value; }
        public List<Carta> MazoDeCartas { get => mazoDeCartas; set => mazoDeCartas = value; }
        public string Resumen { get => resumen; set => resumen = value; }
        public bool TerminoLaPartida { get => terminoLaPartida; set => terminoLaPartida = value; }
        public string GanadorDeLaPartida { get => ganadorDeLaPartida; set => ganadorDeLaPartida = value; }
        public string PerdedorDeLaPartida { get => perdedorDeLaPartida; set => perdedorDeLaPartida = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }

        public Partida(Jugador jugador1, Jugador jugador2, string ganador)
        {
            ganador = "false";
            cantidadDeTurnos = 0;
            PrimerManoParda = false;
            MazoDeCartas = Carta.CargarCartas();
            Jugador1 = jugador1;
            Jugador2 = jugador2;
            Ganador = ganador;
            InstanciarDelegadosYEventos();
            tarea = new Task(JugarPartida);
            fecha = DateTime.Now;

        }

        public Partida(string ganadorDeLaPartida, string perdedorDeLaPartida, DateTime fecha)
        {
            GanadorDeLaPartida = ganadorDeLaPartida;
            PerdedorDeLaPartida = perdedorDeLaPartida;
            Fecha = fecha;
        }


        public async Task EmpezarTarea()
        {
            tarea.Start();
        }

        public void IniciarPartida()
        {
            Jugador1.EsMano = true;
            repartirMano();
            Jugador1.EstaEnPartida = true;
            Jugador2.EstaEnPartida = true;
        }

        public static List<Carta> RepartirCartas(List<Carta> mazo)
        {
            List<Carta> manoDelJugador = new();
            int indiceCartaRandom;
            Carta auxCarta;
            Random rand = new Random();
            for (int i = 0; i < 3; i++)
            {
                indiceCartaRandom = rand.Next(0, mazo.Count);
                auxCarta = mazo[indiceCartaRandom];
                manoDelJugador.Add(auxCarta);
                mazo.Remove(auxCarta);
            }
            return manoDelJugador;
        }

        public void repartirMano()
        {
            jugador1.CartasEnMano = RepartirCartas(MazoDeCartas);
            jugador2.CartasEnMano = RepartirCartas(MazoDeCartas);
            MazoDeCartas.Clear();
            MazoDeCartas = Carta.CargarCartas();
        }



        public void AsignarTurnoYSumarManosGanadas(bool flagEstaJugandoEnvido)
        {
            if (flagEstaJugandoEnvido == false)
            {
                if (Jugador1.UltimaCartaJugada.Valor > Jugador2.UltimaCartaJugada.Valor)
                {
                    if (jugador1.ManosGanadas == 0)
                    {
                        ganadorPrimerMano = jugador1;
                    }
                    Jugador1.EsMano = true;
                    Jugador2.EsMano = false;
                    Jugador1.ManosGanadas++;
                }
                else if (Jugador1.UltimaCartaJugada.Valor < Jugador2.UltimaCartaJugada.Valor)
                {
                    if (jugador2.ManosGanadas == 0)
                    {
                        ganadorPrimerMano = jugador2;
                    }
                    Jugador1.EsMano = false;
                    Jugador2.EsMano = true;
                    Jugador2.ManosGanadas++;
                }
                else
                {
                    if (jugador1.ManosGanadas == 0 && jugador2.ManosGanadas == 0)
                    {
                        //PrimerManoParda = VerificarParda();
                        jugador1.ManosGanadas++;
                        jugador2.ManosGanadas++;
                    }
                    else
                    {
                        Ganador = ganadorPrimerMano.Usuario;
                        ganadorPrimerMano.ManosGanadas++;
                    }


                }

            }

        }

        public void SumarPuntosDelTruco()
        {

            if (Jugador1.ManosGanadas > Jugador2.ManosGanadas)
            {
                if (Jugador1.CantóTruco == true && Jugador2.CantóTruco == true)
                {
                    Jugador1.Puntaje += 2;

                }
            }
            else if (Jugador2.ManosGanadas > Jugador1.ManosGanadas)
            {
                if (Jugador1.CantóTruco == true && Jugador2.CantóTruco == true)
                {
                    Jugador2.Puntaje += 2;

                }

            }

        }

        public bool VerificarSiHayGanador()
        {
            bool retorno = false;


            if (jugador1.Puntaje >= 15)
            {
                Jugador1.CantidadDePartidasGanadas++;
                Jugador2.CantidadDePartidasPerdidas++;
                Ganador = jugador1.Usuario;
                GanadorDeLaPartida = jugador1.Usuario;
                PerdedorDeLaPartida = jugador2.Usuario;
                retorno = true;
            }
            else if (jugador2.Puntaje >= 15)
            {
                Jugador2.CantidadDePartidasGanadas++;
                Jugador1.CantidadDePartidasPerdidas++;
                Ganador = jugador2.Usuario;
                GanadorDeLaPartida = jugador2.Usuario;
                PerdedorDeLaPartida = jugador1.Usuario;
                retorno = true;
            }

            return retorno;
        }

        public string JugarTruco(Jugador jugador1, Jugador jugador2)
        {
            string retorno = "";

            if ((FlagSeCantóTruco == false || jugador2.CantóTruco == true) && CantidadDeTurnos >= 2)
            {
                verificarTruco(jugador1, jugador2);
                if (jugador1.CantóTruco == true && jugador2.CantóTruco == false)
                {
                    retorno = $"{jugador1.Usuario} cantó TRUCO!";
                    FlagSeCantóTruco = true;


                }
                else if (jugador2.CantóTruco == true && jugador1.CantóTruco == true)
                {
                    retorno = $"{jugador1.Usuario} respondió QUIERO!";
                    TrucoFinalizado = true;

                }
                else if (jugador2.CantóTruco == true && jugador1.CantóTruco == false)
                {
                    retorno = $"{jugador1.Usuario} respondió NO QUIERO UwU :(";
                    jugador2.Puntaje += 1;
                    TrucoFinalizado = true;
                    Jugador1.CantóTruco = false;
                    Jugador2.CantóTruco = false;
                    Ganador = Jugador2.Nombre;

                }
            }
            return retorno;
        }

        public bool TerminoLaRonda()
        {
            bool retorno = false;
            if (Jugador1.ManosGanadas == 2 || Jugador2.ManosGanadas == 2 || Ganador != "false")
            {
                SumarPuntosDelTruco();
                if (Jugador1.CartasEnMano.Count == 1 || Jugador2.CartasEnMano.Count == 1)
                {
                    if (Jugador1.EsMano == true)
                    {
                        Jugador1.EsMano = false;
                        Jugador2.EsMano = true;
                    }
                    else
                    {
                        Jugador1.EsMano = true;
                        Jugador2.EsMano = false;
                    }
                }
                retorno = true;
            }
            return retorno;
        }


        public string JugarEnvido(Jugador jugador1, Jugador jugador2)
        {

            string retorno = "";
            if (FlagSeCantoElEnvido == false || jugador2.CantóEnvido == true)
            {
                verificarEnvido(jugador1);
                if (jugador1.CantóEnvido == true && jugador2.CantóEnvido == false)
                {
                    retorno = $"{jugador1.Usuario} cantó ENVIDO!";
                    jugador1.TantosEnvido = cantarTantosDelEnvido(jugador1);
                    FlagSeCantoElEnvido = true;
                    FlagSeEstaJugandoElEnvido = true;

                }

                else if (jugador2.CantóEnvido == true && jugador1.CantóEnvido == true)
                {
                    retorno = $"{jugador1.Usuario} respondió QUIERO!\n";
                    jugador1.TantosEnvido = cantarTantosDelEnvido(jugador1);
                    retorno += CantarTantosEnvido();


                }
                else if (jugador2.CantóEnvido == true && jugador1.CantóEnvido == false)
                {

                    retorno = $"{jugador1.Usuario} respondió NO QUIERO UwU :(";
                    jugador2.Puntaje += 1;
                    Jugador1.CantóEnvido = false;
                    Jugador2.CantóEnvido = false;
                    FlagNoQuisoEnvido = true;
                }
            }
            return retorno;

        }

        public void CompararTantosDelEnvido()
        {

            if (Jugador1.TantosEnvido > Jugador2.TantosEnvido)
            {
                Jugador1.GanoElEnvido = true;
                Jugador1.Puntaje += 2;
            }
            else if (Jugador1.TantosEnvido < Jugador2.TantosEnvido)
            {
                Jugador2.GanoElEnvido = true;
                Jugador2.Puntaje += 2;


            }

            if (Jugador1.TantosEnvido == Jugador2.TantosEnvido)
            {
                if (Jugador1.EsMano == true)
                {
                    Jugador1.GanoElEnvido = true;
                    Jugador1.Puntaje += 2;

                }
                else
                {
                    Jugador2.GanoElEnvido = true;
                    Jugador2.Puntaje += 2;

                }
            }
        }

        public void ControlarTurnos() //Controla si es necesario realizar el cambio de turno.
        {
            if (Jugador1.CartasEnMano.Count == Jugador2.CartasEnMano.Count &&
                Jugador1.CartasEnMano.Count < 3 && Jugador2.CartasEnMano.Count < 3) //
            {
                AsignarTurnoYSumarManosGanadas(FlagSeEstaJugandoElEnvido);
            }
        }

        public bool VerificarParda()
        {
            bool retorno = false;

            if (jugador1.UltimaCartaJugada.Valor == jugador2.UltimaCartaJugada.Valor)
            {
                retorno = true;
            }
            return retorno;
        }

        public Carta JugarUnaCarta(Jugador jugadorEnTurno, Carta cartaDelContrincante)
        {
            Carta cartaAjugar = new Carta("null", 4, Valor.Cuatros);
            Carta peorCarta = new Carta("null", 4, Valor.Cuatros);
            Carta cartaARetornar = new Carta("null", 4, Valor.Cuatros);


            bool flagPeorCarta = true;
            if (jugadorEnTurno.EsMano == true && CantidadDeTurnos == 0)
            {
                cartaAjugar = JugarMejorCartaDeLaMano(jugadorEnTurno.CartasEnMano);
                jugadorEnTurno.UltimaCartaJugada = cartaAjugar;
            }
            else
            {
                foreach (Carta carta in jugadorEnTurno.CartasEnMano)
                {
                    if (cartaDelContrincante.Valor >= carta.Valor)
                    {
                        if (flagPeorCarta == true || carta.Valor < peorCarta.Valor)
                        {
                            cartaAjugar = JugarPeorCartaDeLaMano(jugadorEnTurno.CartasEnMano);
                            jugadorEnTurno.UltimaCartaJugada = cartaAjugar;
                            flagPeorCarta = false;
                        }
                        peorCarta = cartaAjugar;

                    }
                    else if (carta.Valor > cartaDelContrincante.Valor)
                    {
                        foreach (Carta item in jugadorEnTurno.CartasEnMano)
                        {
                            cartaAjugar = JugarMejorCartaDeLaMano(jugadorEnTurno.CartasEnMano);
                            jugadorEnTurno.UltimaCartaJugada = cartaAjugar;
                            break;
                        }

                    }
                }
            }
            if (cartaAjugar.Palo != "null")
            {

                jugadorEnTurno.CartasEnMano.Remove(cartaAjugar);
                cartaARetornar = cartaAjugar;

            }

            return cartaARetornar;

        }


        public Carta JugarMejorCartaDeLaMano(List<Carta> cartasEnMano)
        {
            Carta cartaAJugar;
            int indiceMejorCarta = 0;
            for (int i = 1; i < cartasEnMano.Count; i++)
            {
                if (cartasEnMano[indiceMejorCarta].Valor < cartasEnMano[i].Valor)
                {
                    indiceMejorCarta = i;
                }
            }
            cartaAJugar = cartasEnMano[indiceMejorCarta];
            return cartaAJugar;
        }

        public Carta JugarPeorCartaDeLaMano(List<Carta> cartasEnMano)
        {
            Carta cartaAJugar;
            int indicePeorCarta = 0;
            for (int i = 1; i < cartasEnMano.Count; i++)
            {
                if (cartasEnMano[indicePeorCarta].Valor > cartasEnMano[i].Valor)
                {
                    indicePeorCarta = i;
                }
            }
            cartaAJugar = cartasEnMano[indicePeorCarta];
            return cartaAJugar;
        }

        public void verificarEnvido(Jugador jugadorEnTurno)
        {
            foreach (Carta carta in jugadorEnTurno.CartasEnMano)
            {
                foreach (Carta item in jugadorEnTurno.CartasEnMano) //Recorro dos veces el mazo buscando dos cartas que sean del mismo palo
                {
                    if (carta != item) //Si no son la misma carta 
                    {
                        if (carta.Palo == item.Palo)
                        {
                            jugadorEnTurno.CantóEnvido = true;
                        }
                    }
                }

            }

        }

        public void JugarPartida()
        {
            string carta;
            string cartaj1;
            string cartaj2;
            string cartaj1Aux = "";
            string cartaj2Aux = "";
            string miPartida = "";
            IniciarPartida();
            while (VerificarSiHayGanador() == false)
            {
                Thread.Sleep(20);
                if (TerminoLaRonda() == true)
                {
                    eventoReiniciarPartida?.Invoke();
                    cartaj1Aux = "";
                    cartaj2Aux = "";
                }
                miPartida = JugarTurnos(out carta, out cartaj1, out cartaj2);
                cartaj1Aux += cartaj1;
                cartaj2Aux += cartaj2;


                MostrarLabels?.Invoke(cartaj1Aux, cartaj2Aux);
                jugarPartida?.Invoke();
                if (miPartida != String.Empty)
                {
                    Resumen += miPartida + "\n";
                }

            }
            TerminarPartida(Resumen);

        }

        public void GuardarPartidaEnTxt(string partida)
        {

            Conexiones.ActualizarEstadisticas(Jugador1);
            Conexiones.ActualizarEstadisticas(Jugador2);
            Conexiones.GuardarPartida(GanadorDeLaPartida, PerdedorDeLaPartida, fecha);
            string nombreArchivo = $"{Jugador1.ToString()} vs {Jugador2.ToString()} - {DateTime.Now.ToString("dd-MM--yyyy_HH-mm-ss")}";
            ManejadorDeArchivos.EscribirTxt(partida, nombreArchivo);

        }
        private void TerminarPartida(string miPartida)
        {

            resumen += $"TERMINO LA PARTIDAAA, EL GANADOR FUE {GanadorDeLaPartida}";
            jugarPartida?.Invoke();
            Jugador1.CantidadDePartidasJugadas++;
            Jugador2.CantidadDePartidasJugadas++;
            GuardarPartidaEnTxt(miPartida);
            Jugador1.Puntaje = 0;
            Jugador2.Puntaje = 0;
            Jugador1.EstaEnPartida = false;
            Jugador2.EstaEnPartida = false;
            terminoLaPartida = true;
        }


        public void ControlarEstadoDelEnvido()
        {
            if (Jugador1.TantosEnvido != 0 && Jugador2.TantosEnvido != 0 && EnvidoFinalizado == false)
            {
                CompararTantosDelEnvido();
                EnvidoFinalizado = true;
                FlagSeEstaJugandoElEnvido = false;

            }
            else if (EnvidoFinalizado == false && FlagNoQuisoEnvido == true)
            {
                FlagSeEstaJugandoElEnvido = false;
                EnvidoFinalizado = true;
            }
        }

        public string JugarTurnos(out string carta, out string cartaj1, out string cartaj2)
        {
            string texto = "";
            carta = "";
            cartaj1 = "";
            cartaj2 = "";
            if (Jugador1.EsMano == true)
            {

                if (EnvidoFinalizado == false)
                {
                    //mesaView.CantarJ1 = partida.JugarEnvido(partida.Jugador1, partida.Jugador2);
                    texto = JugarEnvido(Jugador1, Jugador2);

                }

                if (FlagSeEstaJugandoElEnvido != true)
                {
                    if (TrucoFinalizado == false)
                    {
                        //mesaView.CantarJ1 = partida.JugarTruco(partida.Jugador1, partida.Jugador2);
                        texto = JugarTruco(Jugador1, Jugador2);
                        if (Jugador1.CantóTruco == true && Jugador2.CantóTruco == true)
                        {
                            TrucoFinalizado = true;
                        }
                    }

                    //carta = Jugador1.Usuario + "\n" + JugarUnaCarta(Jugador1,Jugador2.UltimaCartaJugada).ToString();
                    cartaj1 += Jugador1.Usuario + "\n" + JugarUnaCarta(Jugador1, Jugador2.UltimaCartaJugada).ToString() + "\n";
                    CantidadDeTurnos++;

                }

                Jugador1.EsMano = false;
                Jugador2.EsMano = true;

            }
            else if (Jugador2.EsMano == true)
            {
                if (EnvidoFinalizado == false)
                {
                    //mesaView.CantarJ2 = partida.JugarEnvido(partida.Jugador2, partida.Jugador1);
                    texto = JugarEnvido(Jugador2, Jugador1);
                }


                if (FlagSeEstaJugandoElEnvido != true)
                {
                    if (TrucoFinalizado == false)
                    {
                        //mesaView.CantarJ2 = partida.JugarTruco(partida.Jugador2, partida.Jugador1);
                        texto = JugarTruco(Jugador2, Jugador1);
                        if (Jugador1.CantóTruco == true && Jugador2.CantóTruco == true)
                        {
                            TrucoFinalizado = true;
                        }
                    }

                    //carta = Jugador2.Usuario + "\n" + JugarUnaCarta(Jugador2, Jugador1.UltimaCartaJugada).ToString();
                    cartaj2 += Jugador2.Usuario + "\n" + JugarUnaCarta(Jugador2, Jugador1.UltimaCartaJugada).ToString() + "\n";
                    CantidadDeTurnos++;

                }


                Jugador1.EsMano = true;
                Jugador2.EsMano = false;
            }

            return texto;
        }

        public void ReiniciarFlagsYParametros()
        {
            PrimerManoParda = false;
            SegundaManoParda = false;
            TercerManoParda = false;
            Ganador = "false";
            EnvidoFinalizado = false;
            FlagSeEstaJugandoElEnvido = false;
            FlagNoQuisoEnvido = false;
            FlagSeCantoElEnvido = false;
            Jugador1.GanoElEnvido = false;
            Jugador2.GanoElEnvido = false;
            Jugador1.TantosEnvido = 0;
            Jugador2.TantosEnvido = 0;
            CantidadDeTurnos = 0;
            Jugador1.ManosGanadas = 0;
            Jugador2.ManosGanadas = 0;
            Jugador1.CartasEnMano.Clear();
            Jugador2.CartasEnMano.Clear();
            repartirMano();
            Jugador1.CantóEnvido = false;
            Jugador2.CantóEnvido = false;
            Jugador1.CantóTruco = false;
            Jugador2.CantóTruco = false;
            TrucoFinalizado = false;
            FlagSeCantóTruco = false;

        }

        public void verificarTruco(Jugador jugadorEnTurno, Jugador jugadorContrario)
        {

            foreach (Carta carta in jugadorEnTurno.CartasEnMano)
            {


                if (carta.Valor >= Valor.Dos)
                {
                    jugadorEnTurno.CantóTruco = true;
                    return;
                }
                else if (jugadorContrario.UltimaCartaJugada.Valor < carta.Valor)
                {
                    jugadorEnTurno.CantóTruco = true;
                    return;
                }
                else if (carta.Valor >= Valor.Unos)
                {
                    Random rand = new Random();
                    if (rand.Next(1, 3) == 1)
                        jugadorEnTurno.CantóTruco = true;
                    return;
                }
            }

        }

        public int cantarTantosDelEnvido(Jugador jugadorEnTurno)
        {
            int tantos = 0;
            foreach (Carta carta in jugadorEnTurno.CartasEnMano)
            {
                foreach (Carta item in jugadorEnTurno.CartasEnMano)
                {
                    if (carta != item)
                    {
                        if (carta.Palo == item.Palo)
                        {
                            if (carta.Numero >= 10 || item.Numero >= 10)
                            {
                                if (carta.Numero >= 10 && item.Numero >= 10)
                                {
                                    tantos = 20;
                                }
                                else if (carta.Numero >= 10 && item.Numero < 10)
                                {
                                    tantos = 20 + item.Numero;
                                }
                                else if (carta.Numero < 10 && item.Numero >= 10)

                                {
                                    tantos = 20 + carta.Numero;
                                }

                            }
                            else
                            {
                                tantos = 20 + item.Numero + carta.Numero;
                            }


                        }
                    }


                }

            }
            return tantos;
        }

        public void MostrarLabelGanadorDelTruco()
        {
            if (Jugador1.ManosGanadas > Jugador2.ManosGanadas)
            {
                if (Jugador1.CantóTruco == true && Jugador2.CantóTruco == true)
                {
                    resumen += $"Ganador del truco: {Jugador1.Usuario}\n";

                }

            }
            else
            {
                if (Jugador1.CantóTruco == true && Jugador2.CantóTruco == true)
                {

                    resumen += $"Ganador del truco: {jugador2.Usuario}\n";

                }
            }

        }


        public void MostrarPuntajeEnRichTextBox()
        {
            resumen += $"Puntaje de {Jugador1.Usuario}: {Jugador1.Puntaje}\n";
            resumen += $"Puntaje de {Jugador2.Usuario}: {Jugador2.Puntaje}\n\n";
        }

        public string CantarTantosEnvido()
        {
            string texto;
            texto = $"Tantos de {Jugador1}: {Jugador1.TantosEnvido}\n";
            texto += $"Tantos de {Jugador2}: {Jugador2.TantosEnvido}\n";
            return texto;
        }

        public void InstanciarDelegadosYEventos()
        {


            jugarPartida += ControlarEstadoDelEnvido;
            jugarPartida += ControlarTurnos;

            eventoReiniciarPartida += MostrarLabelGanadorDelEnvido;
            eventoReiniciarPartida += MostrarLabelGanadorDelTruco;
            eventoReiniciarPartida += MostrarPuntajeEnRichTextBox;
            eventoReiniciarPartida += ReiniciarFlagsYParametros;
            eventoReiniciarPartida += repartirMano;

        }

        public void MostrarLabelGanadorDelEnvido()
        {
            if (Jugador1.GanoElEnvido == true)
            {
                resumen += $"Ganador del envido: {Jugador1.Usuario}\n";
            }
            else if (Jugador2.GanoElEnvido == true)
            {
                resumen += $"Ganador del envido: {Jugador2.Usuario}\n";
            }


        }
    }
}
