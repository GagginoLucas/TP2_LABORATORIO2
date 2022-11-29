namespace Vista
{
    partial class frm_AgregarPartida
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AgregarPartida));
            this.cmb_Jugador1 = new System.Windows.Forms.ComboBox();
            this.cmb_Jugador2 = new System.Windows.Forms.ComboBox();
            this.btn_CrearPartida = new System.Windows.Forms.Button();
            this.btn_CancelarPartida = new System.Windows.Forms.Button();
            this.lbl_SeleccioneJugadores = new System.Windows.Forms.Label();
            this.lbl_Error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmb_Jugador1
            // 
            this.cmb_Jugador1.BackColor = System.Drawing.SystemColors.Window;
            this.cmb_Jugador1.FormattingEnabled = true;
            this.cmb_Jugador1.Location = new System.Drawing.Point(94, 73);
            this.cmb_Jugador1.Name = "cmb_Jugador1";
            this.cmb_Jugador1.Size = new System.Drawing.Size(207, 23);
            this.cmb_Jugador1.TabIndex = 0;
            this.cmb_Jugador1.SelectedIndexChanged += new System.EventHandler(this.cmb_Jugador1_SelectedIndexChanged);
            // 
            // cmb_Jugador2
            // 
            this.cmb_Jugador2.BackColor = System.Drawing.SystemColors.Window;
            this.cmb_Jugador2.FormattingEnabled = true;
            this.cmb_Jugador2.Location = new System.Drawing.Point(94, 140);
            this.cmb_Jugador2.Name = "cmb_Jugador2";
            this.cmb_Jugador2.Size = new System.Drawing.Size(207, 23);
            this.cmb_Jugador2.TabIndex = 0;
            // 
            // btn_CrearPartida
            // 
            this.btn_CrearPartida.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_CrearPartida.Location = new System.Drawing.Point(141, 238);
            this.btn_CrearPartida.Name = "btn_CrearPartida";
            this.btn_CrearPartida.Size = new System.Drawing.Size(98, 43);
            this.btn_CrearPartida.TabIndex = 1;
            this.btn_CrearPartida.Text = "CREAR PARTIDA";
            this.btn_CrearPartida.UseVisualStyleBackColor = true;
            this.btn_CrearPartida.Click += new System.EventHandler(this.btn_CrearPartida_Click);
            // 
            // btn_CancelarPartida
            // 
            this.btn_CancelarPartida.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_CancelarPartida.Location = new System.Drawing.Point(141, 329);
            this.btn_CancelarPartida.Name = "btn_CancelarPartida";
            this.btn_CancelarPartida.Size = new System.Drawing.Size(98, 42);
            this.btn_CancelarPartida.TabIndex = 2;
            this.btn_CancelarPartida.Text = "CANCELAR";
            this.btn_CancelarPartida.UseVisualStyleBackColor = true;
            this.btn_CancelarPartida.Click += new System.EventHandler(this.btn_CancelarPartida_Click);
            // 
            // lbl_SeleccioneJugadores
            // 
            this.lbl_SeleccioneJugadores.AutoSize = true;
            this.lbl_SeleccioneJugadores.BackColor = System.Drawing.Color.Transparent;
            this.lbl_SeleccioneJugadores.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_SeleccioneJugadores.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_SeleccioneJugadores.Location = new System.Drawing.Point(94, 22);
            this.lbl_SeleccioneJugadores.Name = "lbl_SeleccioneJugadores";
            this.lbl_SeleccioneJugadores.Size = new System.Drawing.Size(207, 25);
            this.lbl_SeleccioneJugadores.TabIndex = 3;
            this.lbl_SeleccioneJugadores.Text = "Seleccione 2 jugadores";
            // 
            // lbl_Error
            // 
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Error.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Error.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_Error.Location = new System.Drawing.Point(12, 186);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(67, 21);
            this.lbl_Error.TabIndex = 4;
            this.lbl_Error.Text = "lblerror";
            this.lbl_Error.Visible = false;
            // 
            // frm_AgregarPartida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(390, 419);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_Error);
            this.Controls.Add(this.lbl_SeleccioneJugadores);
            this.Controls.Add(this.btn_CancelarPartida);
            this.Controls.Add(this.btn_CrearPartida);
            this.Controls.Add(this.cmb_Jugador2);
            this.Controls.Add(this.cmb_Jugador1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "frm_AgregarPartida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear partida";
            this.Load += new System.EventHandler(this.frm_AgregarPartida_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmb_Jugador1;
        private ComboBox cmb_Jugador2;
        private Button btn_CrearPartida;
        private Button btn_CancelarPartida;
        private Label lbl_SeleccioneJugadores;
        private Label lbl_Error;
    }
}