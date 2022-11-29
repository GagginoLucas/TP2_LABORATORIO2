using Biblioteca.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class frm_Estadisticas : Form
    {
        private List<Partida> listaPartidas;
        private List<Jugador> topCincoJugadoresGanadores;
        private List<Jugador> topCincoJugadoresPerdedores;
        private List<Jugador> topCincoPartidasJugadas;

        public frm_Estadisticas()
        {
            InitializeComponent();

            cmb_Estadisticas.Items.Clear();
            cmb_Estadisticas.Items.Add("TOP 5 de jugadores con más partidas ganadas.");
            cmb_Estadisticas.Items.Add("TOP 5 de jugadores con más partidas perdidas.");
            cmb_Estadisticas.Items.Add("TOP 5 de jugadores con más partidas jugadas.");
            cmb_Estadisticas.Items.Add("Historial de partidas.");
        }

        private void frm_Estadisticas_Load(object sender, EventArgs e)
        {
            listaPartidas = Conexiones.ObtenerPartidas();
            topCincoJugadoresGanadores = Conexiones.ObtenerTopCincoMejoresJugadores();
            topCincoJugadoresPerdedores = Conexiones.ObtenerTopCincoPerdedores();
            topCincoPartidasJugadas = Conexiones.ObtenerTopCincoPartidasJugadas();
        }
           
        private void ActualizarEstadisticasTop5Jugadores(List<Jugador> lista)
        {
            dgv_Estadisticas.DataSource = null;
            if (lista.Count > 0 && lista != null)
                dgv_Estadisticas.DataSource = lista;
        }


        private void ActualizarEstadisticasHistorialPartidas()
        {
            dgv_Partidas.DataSource = null;
            
            if (listaPartidas.Count > 0 && listaPartidas != null)
                dgv_Partidas.DataSource = listaPartidas;
        }


        private void btn_IrAtras_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void cmb_Estadisticas_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv_Estadisticas.Visible = true;
            dgv_Partidas.Visible = false;
            switch (cmb_Estadisticas.SelectedIndex)
            {
                case 0:
                        dgv_Estadisticas.Columns[1].Visible = false;
                        dgv_Estadisticas.Columns[2].Visible = true;
                        dgv_Estadisticas.Columns[3].Visible = false;
                        ActualizarEstadisticasTop5Jugadores(topCincoJugadoresGanadores);

                    break;

                case 1:
                        dgv_Estadisticas.Columns[1].Visible = false;
                        dgv_Estadisticas.Columns[2].Visible = false;
                        dgv_Estadisticas.Columns[3].Visible = true;
                        ActualizarEstadisticasTop5Jugadores(topCincoJugadoresPerdedores);
                    break;

                case 2:
                        dgv_Estadisticas.Columns[1].Visible = true;
                        dgv_Estadisticas.Columns[2].Visible = true;
                        dgv_Estadisticas.Columns[3].Visible = true;
                        ActualizarEstadisticasTop5Jugadores(topCincoPartidasJugadas);
                    break;

                case 3:
                        dgv_Estadisticas.Visible = false;
                        dgv_Partidas.Visible = true;
                        ActualizarEstadisticasHistorialPartidas();
                    break;
            }
        }
    }
}
