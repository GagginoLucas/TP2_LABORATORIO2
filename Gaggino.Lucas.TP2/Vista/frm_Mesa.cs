using Biblioteca.Interfaces;
using Biblioteca.Modelos;
using Biblioteca.Presentadores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Label = System.Windows.Forms.Label;

namespace Vista
{
    public partial class frm_Mesa : Form , IMesa
    {
        PresentadorMesa presentadorMesa;
        Partida mipartida;
        delegate void SetTextCallback(string texto);


        public string MostrarCartasJ1 { get => lbl_CartasJugador1.Text; set => lbl_CartasJugador1.Text = value; }

        public void MostrarCartasJ1Metodo(string texto)
        {
            if (lbl_CartasJugador1.InvokeRequired)
            {
                SetTextCallback st = new SetTextCallback(MostrarCartasJ1Metodo);
                this.Invoke(st, new object[] {texto});
            }
            else
            {
                 MostrarCartasJ1 = texto;
            }

        }

        public string MostrarCartasJ2 { get => lbl_CartasJugador2.Text; set => lbl_CartasJugador2.Text = value; }
        public void MostrarCartasJ2Metodo(string texto)
        {
            if (lbl_CartasJugador2.InvokeRequired)
            {
                SetTextCallback st = new SetTextCallback(MostrarCartasJ2Metodo);
                this.Invoke(st, new object[] { texto });
            }
            else
            {
                MostrarCartasJ2 = texto;
            }

        }
    
        public string MostrarPartida { get => rtx_Partida.Text; set => rtx_Partida.Text = value; }

        public void MostrarPartidaMetodo(string texto)
        {
            if (rtx_Partida.InvokeRequired)
            {
                SetTextCallback st = new SetTextCallback(MostrarPartidaMetodo);
                this.Invoke(st, new object[] { texto });
            }
            else
            {
                MostrarPartida = texto;
            }

        }

        public frm_Mesa(Partida partidaEnCurso)
        {

            InitializeComponent();
            presentadorMesa = new(this, partidaEnCurso);
            presentadorMesa.InstanciarDelegadosYEventos();
            mipartida = partidaEnCurso;
        }

        private void frm_Mesa_Load(object sender, EventArgs e)
        {

        }

        private void tmr_Partida_Tick(object sender, EventArgs e)
        { 


        }

        private void rtx_Partida_TextChanged(object sender, EventArgs e)
        {

            rtx_Partida.SelectionStart = rtx_Partida.Text.Length;
            rtx_Partida.ScrollToCaret();

        }

        private void btn_IrAtras_Click(object sender, EventArgs e)
        {
            presentadorMesa.IrAtras();
            this.Close();
        }
    }
}

