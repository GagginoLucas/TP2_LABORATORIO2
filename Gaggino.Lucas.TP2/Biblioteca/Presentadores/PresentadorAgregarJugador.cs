using Biblioteca.Interfaces;
using Biblioteca.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Presentadores
{
    public class PresentadorAgregarJugador
    {
        IAgregarJugador viewAgregarJugador;
        List<Jugador> jugadores;
        Jugador auxJugador;
        public PresentadorAgregarJugador(IAgregarJugador viewAgregarJugador)
        {
            this.viewAgregarJugador = viewAgregarJugador;
            jugadores = Conexiones.ObtenerJugadores();
        }

        public bool VerificarDatosCargados()
        {
            bool retorno = false;
            if (viewAgregarJugador.Nombre != String.Empty && viewAgregarJugador.Apellido != String.Empty && viewAgregarJugador.Usuario != String.Empty
                   && viewAgregarJugador.Nombre is not null && viewAgregarJugador.Apellido is not null && viewAgregarJugador.Usuario is not null)
            {
                foreach (Jugador jugador in jugadores)
                {
                    if(viewAgregarJugador.Usuario.ToLower() != jugador.Usuario.ToLower())
                    {
                        retorno = true;
                    }
                    else
                    {
                        retorno = false;
                        viewAgregarJugador.Error = "Ya existe un usuario con ese nombre.";
                        break;
                    }
                }
            }
            else
            { 
                viewAgregarJugador.Error = "Faltaron completar datos.";
                retorno = false;
            }
            return retorno;
        }

        public int GenerarNroDeID()
        {
            int ultimoID;
            int ultimoJugador;
            ultimoJugador = jugadores.Count;
            ultimoID = jugadores[ultimoJugador].Id;
            ultimoID++;
            return ultimoID;
            
        }
        public bool AgregarJugador()
        {
            
            if(VerificarDatosCargados())
            {
                Conexiones.AgregarJugador(viewAgregarJugador.Nombre, viewAgregarJugador.Apellido, viewAgregarJugador.Usuario);
                return true;
            }
            return false;
        }
    }
}
