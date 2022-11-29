namespace Vista
{
    partial class frm_MenuPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_CrearPartida = new System.Windows.Forms.Button();
            this.btn_Estadisticas = new System.Windows.Forms.Button();
            this.btn_VerPartida = new System.Windows.Forms.Button();
            this.dgv_Partidas = new System.Windows.Forms.DataGridView();
            this.jugador1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jugador2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partidaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tmr_MenuPrincipal = new System.Windows.Forms.Timer(this.components);
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_AgregarJugador = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Partidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partidaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_CrearPartida
            // 
            this.btn_CrearPartida.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_CrearPartida.Location = new System.Drawing.Point(35, 43);
            this.btn_CrearPartida.Name = "btn_CrearPartida";
            this.btn_CrearPartida.Size = new System.Drawing.Size(123, 40);
            this.btn_CrearPartida.TabIndex = 1;
            this.btn_CrearPartida.Text = "CREAR PARTIDA";
            this.btn_CrearPartida.UseVisualStyleBackColor = true;
            this.btn_CrearPartida.Click += new System.EventHandler(this.btn_CrearPartida_Click);
            // 
            // btn_Estadisticas
            // 
            this.btn_Estadisticas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Estadisticas.Location = new System.Drawing.Point(35, 210);
            this.btn_Estadisticas.Name = "btn_Estadisticas";
            this.btn_Estadisticas.Size = new System.Drawing.Size(123, 40);
            this.btn_Estadisticas.TabIndex = 2;
            this.btn_Estadisticas.Text = "ESTADÍSTICAS";
            this.btn_Estadisticas.UseVisualStyleBackColor = true;
            this.btn_Estadisticas.Click += new System.EventHandler(this.btn_Estadisticas_Click);
            // 
            // btn_VerPartida
            // 
            this.btn_VerPartida.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_VerPartida.Location = new System.Drawing.Point(35, 300);
            this.btn_VerPartida.Name = "btn_VerPartida";
            this.btn_VerPartida.Size = new System.Drawing.Size(123, 40);
            this.btn_VerPartida.TabIndex = 3;
            this.btn_VerPartida.Text = "VER PARTIDA";
            this.btn_VerPartida.UseVisualStyleBackColor = true;
            this.btn_VerPartida.Click += new System.EventHandler(this.btn_VerPartida_Click);
            // 
            // dgv_Partidas
            // 
            this.dgv_Partidas.AllowUserToAddRows = false;
            this.dgv_Partidas.AllowUserToDeleteRows = false;
            this.dgv_Partidas.AllowUserToResizeColumns = false;
            this.dgv_Partidas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.dgv_Partidas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Partidas.AutoGenerateColumns = false;
            this.dgv_Partidas.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.dgv_Partidas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_Partidas.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgv_Partidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Partidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jugador1DataGridViewTextBoxColumn,
            this.jugador2DataGridViewTextBoxColumn});
            this.dgv_Partidas.DataSource = this.partidaBindingSource;
            this.dgv_Partidas.Location = new System.Drawing.Point(353, 43);
            this.dgv_Partidas.MultiSelect = false;
            this.dgv_Partidas.Name = "dgv_Partidas";
            this.dgv_Partidas.ReadOnly = true;
            this.dgv_Partidas.RowTemplate.Height = 25;
            this.dgv_Partidas.Size = new System.Drawing.Size(247, 374);
            this.dgv_Partidas.TabIndex = 4;
            this.dgv_Partidas.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_Partidas_RowHeaderMouseClick_1);
            // 
            // jugador1DataGridViewTextBoxColumn
            // 
            this.jugador1DataGridViewTextBoxColumn.DataPropertyName = "Jugador1";
            this.jugador1DataGridViewTextBoxColumn.HeaderText = "Jugador1";
            this.jugador1DataGridViewTextBoxColumn.Name = "jugador1DataGridViewTextBoxColumn";
            this.jugador1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jugador2DataGridViewTextBoxColumn
            // 
            this.jugador2DataGridViewTextBoxColumn.DataPropertyName = "Jugador2";
            this.jugador2DataGridViewTextBoxColumn.HeaderText = "Jugador2";
            this.jugador2DataGridViewTextBoxColumn.Name = "jugador2DataGridViewTextBoxColumn";
            this.jugador2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // partidaBindingSource
            // 
            this.partidaBindingSource.DataSource = typeof(Biblioteca.Modelos.Partida);
            // 
            // tmr_MenuPrincipal
            // 
            this.tmr_MenuPrincipal.Enabled = true;
            this.tmr_MenuPrincipal.Interval = 1000;
            this.tmr_MenuPrincipal.Tick += new System.EventHandler(this.tmr_MenuPrincipal_Tick);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Salir.Location = new System.Drawing.Point(35, 377);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(123, 40);
            this.btn_Salir.TabIndex = 5;
            this.btn_Salir.Text = "SALIR";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_AgregarJugador
            // 
            this.btn_AgregarJugador.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_AgregarJugador.Location = new System.Drawing.Point(35, 122);
            this.btn_AgregarJugador.Name = "btn_AgregarJugador";
            this.btn_AgregarJugador.Size = new System.Drawing.Size(123, 40);
            this.btn_AgregarJugador.TabIndex = 6;
            this.btn_AgregarJugador.Text = "CREAR JUGADOR";
            this.btn_AgregarJugador.UseVisualStyleBackColor = true;
            this.btn_AgregarJugador.Click += new System.EventHandler(this.btn_AgregarJugador_Click);
            // 
            // frm_MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vista.Properties.Resources.fondo_agregarPartida;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(662, 451);
            this.ControlBox = false;
            this.Controls.Add(this.btn_AgregarJugador);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.dgv_Partidas);
            this.Controls.Add(this.btn_VerPartida);
            this.Controls.Add(this.btn_Estadisticas);
            this.Controls.Add(this.btn_CrearPartida);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenido";
            this.Load += new System.EventHandler(this.frm_MenuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Partidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partidaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btn_CrearPartida;
        private Button btn_Estadisticas;
        private Button btn_VerPartida;
        private DataGridView dgv_Partidas;
        private BindingSource partidaBindingSource;
        private System.Windows.Forms.Timer tmr_MenuPrincipal;
        private DataGridViewTextBoxColumn jugador1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn jugador2DataGridViewTextBoxColumn;
        private Button btn_Salir;
        private Button btn_AgregarJugador;
    }
}