using Biblioteca.Interfaces;
using Biblioteca.Presentadores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class frm_AgregarJugador : Form , IAgregarJugador
    {
        TextInfo ti = new CultureInfo("es-ES", false).TextInfo;
        PresentadorAgregarJugador presentadorAgregarJugador;

        public string Nombre { get => txt_Nombre.Text; set => txt_Nombre.Text = value; }
        public string Apellido { get => txt_Apellido.Text; set => txt_Apellido.Text = value; }
        public string Usuario { get => txt_Usuario.Text; set => txt_Usuario.Text = value; }
        public string Error { get => lbl_Error.Text; set => lbl_Error.Text = value; }

        public frm_AgregarJugador()
        {
            InitializeComponent();
            presentadorAgregarJugador = new PresentadorAgregarJugador(this);
        }

        private void frm_AgregarJugador_Load(object sender, EventArgs e)
        {
            Error = "";
        }

        private void txt_Nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
 
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
    
        }

        private void txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txt_Nombre_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox? txt = sender as TextBox;
            txt.Text = ti.ToTitleCase(txt.Text.ToLower());
            txt.SelectionStart = txt.Text.Length; 
        }

        private void txt_Apellido_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox? txt = sender as TextBox;
            txt.Text = ti.ToTitleCase(txt.Text.ToLower());
            txt.SelectionStart = txt.Text.Length;
        }

        private void txt_Usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (presentadorAgregarJugador.AgregarJugador())
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
