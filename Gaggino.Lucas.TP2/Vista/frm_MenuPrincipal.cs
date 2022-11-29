using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca.Modelos;

namespace Vista
{
    public partial class frm_MenuPrincipal : Form
    {
        List<Partida> listaDePartidas = new List<Partida>();
        List<Jugador> listaDeJugadores;
        int indiceDataGridPartidas;
        public frm_MenuPrincipal()
        {
            InitializeComponent();
        }

        private void frm_MenuPrincipal_Load(object sender, EventArgs e)
        {
            ActualizarListaDeJugadores();
            ActualizarListaDePartidas();
            btn_VerPartida.Enabled = false;
        }

        private void btn_CrearPartida_Click(object sender, EventArgs e)
        {
            frm_AgregarPartida formularioAgregarPartida = new frm_AgregarPartida(listaDeJugadores, listaDePartidas);
            this.Hide();
            formularioAgregarPartida.ShowDialog();
            ActualizarListaDePartidas();
            this.Show();
        }

        private void ActualizarListaDeJugadores()
        {
            listaDeJugadores = Conexiones.ObtenerJugadores();
        }


        private void ActualizarListaDePartidas()
        {
            bool flaghayParaRemover = false;
            int indice = -1;
            for (int i = 0; i < listaDePartidas.Count; i++)
            {
                if (listaDePartidas[i].TerminoLaPartida == true)
                {
                    indice = i;
                    flaghayParaRemover = true;
                }
            }

            if(flaghayParaRemover == true)
            listaDePartidas.Remove(listaDePartidas[indice]);


            if (listaDePartidas.Count <= 0)
            {
                btn_VerPartida.Enabled = false;
            }

            dgv_Partidas.DataSource = null;
            
            if(listaDePartidas.Count > 0 && listaDePartidas != null)
            dgv_Partidas.DataSource = listaDePartidas;

        }


        private void btn_VerPartida_Click(object sender, EventArgs e)
        {
            frm_Mesa formularioMesa = new frm_Mesa(listaDePartidas[indiceDataGridPartidas]);
            formularioMesa.Show();
            ActualizarListaDePartidas();
            this.Show();
        }

        private void dgv_Partidas_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            indiceDataGridPartidas = e.RowIndex;
            btn_VerPartida.Enabled = true;
        }

        private void tmr_MenuPrincipal_Tick(object sender, EventArgs e)
        {
            ActualizarListaDePartidas();
        }

        private void btn_Estadisticas_Click(object sender, EventArgs e)
        {
            frm_Estadisticas formEstadisticas = new frm_Estadisticas();
            this.Hide();
            formEstadisticas.ShowDialog();
            this.Show();

        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btn_AgregarJugador_Click(object sender, EventArgs e)
        {
            frm_AgregarJugador formAgregarJugador = new frm_AgregarJugador();
            this.Hide();
            if (formAgregarJugador.ShowDialog() == DialogResult.OK)
            {
                ActualizarListaDeJugadores();
            }
            this.Show();
        }
    }
}
