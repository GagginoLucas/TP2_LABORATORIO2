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
        public frm_Estadisticas()
        {
            InitializeComponent();

        }

        private void frm_Estadisticas_Load(object sender, EventArgs e)
        {
            listaPartidas = Conexiones.ObtenerPartidas();
            ActualizarEstadisticas();
        }
           
        private void ActualizarEstadisticas()
        {
            dgv_Estadisticas.DataSource = null;

            if (listaPartidas.Count > 0 && listaPartidas != null)
                dgv_Estadisticas.DataSource = listaPartidas;
        }

        private void btn_IrAtras_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
