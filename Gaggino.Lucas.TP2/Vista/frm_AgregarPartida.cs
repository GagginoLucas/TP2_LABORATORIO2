using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca.Interfaces;
using Biblioteca.Modelos;
using Biblioteca.Presentadores;

namespace Vista
{
    public partial class frm_AgregarPartida : Form , IAgregarPartida
    {
        PresentadorAgregarPartida presentador;
        List<Jugador> jugadores = new List<Jugador>();
        List<Partida> nuevaPartida;

        public string LabelError { get => lbl_Error.Text; set => lbl_Error.Text = value; }

        public frm_AgregarPartida(List<Jugador> listaJugadores, List<Partida> listaPartidas)
        {
            InitializeComponent();
            presentador = new(this);
            jugadores = listaJugadores;
            nuevaPartida = listaPartidas;
        }

        private void frm_AgregarPartida_Load(object sender, EventArgs e)
        {
            CargarJugadores();
            lbl_Error.Visible = false;
        }

        private void cmb_Jugador1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void CargarJugadores()
        {

            List<Jugador> listaAux = jugadores;

            for (int i = 0; i < jugadores.Count; i++)
            {
                cmb_Jugador1.Items.Add(jugadores[i]);
                cmb_Jugador2.Items.Add(jugadores[i]);

            }
        }

        private bool ValidarJugadoresSeleccionados()
        {
            if(cmb_Jugador1.SelectedIndex != cmb_Jugador2.SelectedIndex)
            {

                if (jugadores[cmb_Jugador1.SelectedIndex].EstaEnPartida == false && jugadores[cmb_Jugador2.SelectedIndex].EstaEnPartida == false)
                {
                    return true;
                }
                else
                {
                    lbl_Error.Visible = true;
                    presentador.MostrarError("Uno de los jugadores seleccionados ya se encuentra en una partida.");
                }
            }
            else
            {
                lbl_Error.Visible = true;
                presentador.MostrarError("Un jugador no puede jugar contra si mismo!!!.");
            }
            return false;
        }

        private async void btn_CrearPartida_Click(object sender, EventArgs e)
        {
            if (ValidarJugadoresSeleccionados())
            {
                
                Partida partidaAux = new Partida(jugadores[cmb_Jugador1.SelectedIndex], jugadores[cmb_Jugador2.SelectedIndex], "false");
                nuevaPartida.Add(partidaAux);

                await partidaAux.EmpezarTarea(); //Lo ejecuta en segundo plano
                DialogResult = DialogResult.OK;
            }

        }

        private void btn_CancelarPartida_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
