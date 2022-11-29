namespace Vista
{
    partial class frm_Estadisticas
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
            this.jugadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partidaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_IrAtras = new System.Windows.Forms.Button();
            this.partidaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.jugadorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.jugadorBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.jugadorBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.jugadorBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.dgv_Estadisticas = new System.Windows.Forms.DataGridView();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDePartidasJugadasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDePartidasGanadasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDePartidasPerdidasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDeAnchosDeEspadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDeAnchosDeBastoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jugadorBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.cmb_Estadisticas = new System.Windows.Forms.ComboBox();
            this.partidaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dgv_Partidas = new System.Windows.Forms.DataGridView();
            this.ganadorDeLaPartidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PerdedorDeLaPartida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partidaBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.jugadorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partidaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partidaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jugadorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jugadorBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jugadorBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jugadorBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Estadisticas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jugadorBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partidaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Partidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partidaBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // jugadorBindingSource
            // 
            this.jugadorBindingSource.DataSource = typeof(Biblioteca.Modelos.Jugador);
            // 
            // partidaBindingSource
            // 
            this.partidaBindingSource.DataSource = typeof(Biblioteca.Modelos.Partida);
            // 
            // btn_IrAtras
            // 
            this.btn_IrAtras.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_IrAtras.Location = new System.Drawing.Point(324, 360);
            this.btn_IrAtras.Name = "btn_IrAtras";
            this.btn_IrAtras.Size = new System.Drawing.Size(119, 40);
            this.btn_IrAtras.TabIndex = 1;
            this.btn_IrAtras.Text = "IR ATRAS";
            this.btn_IrAtras.UseVisualStyleBackColor = true;
            this.btn_IrAtras.Click += new System.EventHandler(this.btn_IrAtras_Click);
            // 
            // partidaBindingSource1
            // 
            this.partidaBindingSource1.DataSource = typeof(Biblioteca.Modelos.Partida);
            // 
            // jugadorBindingSource1
            // 
            this.jugadorBindingSource1.DataSource = typeof(Biblioteca.Modelos.Jugador);
            // 
            // jugadorBindingSource2
            // 
            this.jugadorBindingSource2.DataSource = typeof(Biblioteca.Modelos.Jugador);
            // 
            // jugadorBindingSource3
            // 
            this.jugadorBindingSource3.DataSource = typeof(Biblioteca.Modelos.Jugador);
            // 
            // jugadorBindingSource4
            // 
            this.jugadorBindingSource4.DataSource = typeof(Biblioteca.Modelos.Jugador);
            // 
            // dgv_Estadisticas
            // 
            this.dgv_Estadisticas.AllowUserToAddRows = false;
            this.dgv_Estadisticas.AllowUserToDeleteRows = false;
            this.dgv_Estadisticas.AllowUserToResizeColumns = false;
            this.dgv_Estadisticas.AllowUserToResizeRows = false;
            this.dgv_Estadisticas.AutoGenerateColumns = false;
            this.dgv_Estadisticas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Estadisticas.BackgroundColor = System.Drawing.Color.Coral;
            this.dgv_Estadisticas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Estadisticas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usuarioDataGridViewTextBoxColumn,
            this.cantidadDePartidasJugadasDataGridViewTextBoxColumn,
            this.cantidadDePartidasGanadasDataGridViewTextBoxColumn,
            this.cantidadDePartidasPerdidasDataGridViewTextBoxColumn,
            this.cantidadDeAnchosDeEspadaDataGridViewTextBoxColumn,
            this.cantidadDeAnchosDeBastoDataGridViewTextBoxColumn});
            this.dgv_Estadisticas.DataSource = this.jugadorBindingSource5;
            this.dgv_Estadisticas.Location = new System.Drawing.Point(69, 112);
            this.dgv_Estadisticas.MultiSelect = false;
            this.dgv_Estadisticas.Name = "dgv_Estadisticas";
            this.dgv_Estadisticas.ReadOnly = true;
            this.dgv_Estadisticas.RowTemplate.Height = 25;
            this.dgv_Estadisticas.Size = new System.Drawing.Size(643, 182);
            this.dgv_Estadisticas.TabIndex = 2;
            this.dgv_Estadisticas.Visible = false;
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            this.usuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.HeaderText = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            this.usuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidadDePartidasJugadasDataGridViewTextBoxColumn
            // 
            this.cantidadDePartidasJugadasDataGridViewTextBoxColumn.DataPropertyName = "CantidadDePartidasJugadas";
            this.cantidadDePartidasJugadasDataGridViewTextBoxColumn.HeaderText = "Partidas jugadas";
            this.cantidadDePartidasJugadasDataGridViewTextBoxColumn.Name = "cantidadDePartidasJugadasDataGridViewTextBoxColumn";
            this.cantidadDePartidasJugadasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidadDePartidasGanadasDataGridViewTextBoxColumn
            // 
            this.cantidadDePartidasGanadasDataGridViewTextBoxColumn.DataPropertyName = "CantidadDePartidasGanadas";
            this.cantidadDePartidasGanadasDataGridViewTextBoxColumn.HeaderText = "Partidas ganadas";
            this.cantidadDePartidasGanadasDataGridViewTextBoxColumn.Name = "cantidadDePartidasGanadasDataGridViewTextBoxColumn";
            this.cantidadDePartidasGanadasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidadDePartidasPerdidasDataGridViewTextBoxColumn
            // 
            this.cantidadDePartidasPerdidasDataGridViewTextBoxColumn.DataPropertyName = "CantidadDePartidasPerdidas";
            this.cantidadDePartidasPerdidasDataGridViewTextBoxColumn.HeaderText = "Partidas perdidas";
            this.cantidadDePartidasPerdidasDataGridViewTextBoxColumn.Name = "cantidadDePartidasPerdidasDataGridViewTextBoxColumn";
            this.cantidadDePartidasPerdidasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidadDeAnchosDeEspadaDataGridViewTextBoxColumn
            // 
            this.cantidadDeAnchosDeEspadaDataGridViewTextBoxColumn.DataPropertyName = "CantidadDeAnchosDeEspada";
            this.cantidadDeAnchosDeEspadaDataGridViewTextBoxColumn.HeaderText = "Anchos de espada obtenidos";
            this.cantidadDeAnchosDeEspadaDataGridViewTextBoxColumn.Name = "cantidadDeAnchosDeEspadaDataGridViewTextBoxColumn";
            this.cantidadDeAnchosDeEspadaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidadDeAnchosDeBastoDataGridViewTextBoxColumn
            // 
            this.cantidadDeAnchosDeBastoDataGridViewTextBoxColumn.DataPropertyName = "CantidadDeAnchosDeBasto";
            this.cantidadDeAnchosDeBastoDataGridViewTextBoxColumn.HeaderText = "Anchos de basto obtenidos";
            this.cantidadDeAnchosDeBastoDataGridViewTextBoxColumn.Name = "cantidadDeAnchosDeBastoDataGridViewTextBoxColumn";
            this.cantidadDeAnchosDeBastoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jugadorBindingSource5
            // 
            this.jugadorBindingSource5.DataSource = typeof(Biblioteca.Modelos.Jugador);
            // 
            // cmb_Estadisticas
            // 
            this.cmb_Estadisticas.FormattingEnabled = true;
            this.cmb_Estadisticas.Location = new System.Drawing.Point(252, 51);
            this.cmb_Estadisticas.Name = "cmb_Estadisticas";
            this.cmb_Estadisticas.Size = new System.Drawing.Size(316, 23);
            this.cmb_Estadisticas.TabIndex = 3;
            this.cmb_Estadisticas.Text = "¿Que desea visualizar?";
            this.cmb_Estadisticas.SelectedIndexChanged += new System.EventHandler(this.cmb_Estadisticas_SelectedIndexChanged);
            // 
            // partidaBindingSource2
            // 
            this.partidaBindingSource2.DataSource = typeof(Biblioteca.Modelos.Partida);
            // 
            // dgv_Partidas
            // 
            this.dgv_Partidas.AllowUserToAddRows = false;
            this.dgv_Partidas.AllowUserToDeleteRows = false;
            this.dgv_Partidas.AllowUserToResizeColumns = false;
            this.dgv_Partidas.AllowUserToResizeRows = false;
            this.dgv_Partidas.AutoGenerateColumns = false;
            this.dgv_Partidas.BackgroundColor = System.Drawing.Color.Coral;
            this.dgv_Partidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Partidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ganadorDeLaPartidaDataGridViewTextBoxColumn,
            this.PerdedorDeLaPartida,
            this.fechaDataGridViewTextBoxColumn});
            this.dgv_Partidas.DataSource = this.partidaBindingSource3;
            this.dgv_Partidas.Location = new System.Drawing.Point(220, 112);
            this.dgv_Partidas.Name = "dgv_Partidas";
            this.dgv_Partidas.ReadOnly = true;
            this.dgv_Partidas.RowTemplate.Height = 25;
            this.dgv_Partidas.Size = new System.Drawing.Size(348, 217);
            this.dgv_Partidas.TabIndex = 4;
            this.dgv_Partidas.Visible = false;
            // 
            // ganadorDeLaPartidaDataGridViewTextBoxColumn
            // 
            this.ganadorDeLaPartidaDataGridViewTextBoxColumn.DataPropertyName = "GanadorDeLaPartida";
            this.ganadorDeLaPartidaDataGridViewTextBoxColumn.HeaderText = "Ganador";
            this.ganadorDeLaPartidaDataGridViewTextBoxColumn.Name = "ganadorDeLaPartidaDataGridViewTextBoxColumn";
            this.ganadorDeLaPartidaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // PerdedorDeLaPartida
            // 
            this.PerdedorDeLaPartida.DataPropertyName = "PerdedorDeLaPartida";
            this.PerdedorDeLaPartida.HeaderText = "Perdedor";
            this.PerdedorDeLaPartida.Name = "PerdedorDeLaPartida";
            this.PerdedorDeLaPartida.ReadOnly = true;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // partidaBindingSource3
            // 
            this.partidaBindingSource3.DataSource = typeof(Biblioteca.Modelos.Partida);
            // 
            // frm_Estadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vista.Properties.Resources.fondo_agregarPartida;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(780, 425);
            this.ControlBox = false;
            this.Controls.Add(this.dgv_Partidas);
            this.Controls.Add(this.cmb_Estadisticas);
            this.Controls.Add(this.dgv_Estadisticas);
            this.Controls.Add(this.btn_IrAtras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_Estadisticas";
            this.ShowIcon = false;
            this.Text = "Estadisticas";
            this.Load += new System.EventHandler(this.frm_Estadisticas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jugadorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partidaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partidaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jugadorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jugadorBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jugadorBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jugadorBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Estadisticas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jugadorBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partidaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Partidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partidaBindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private BindingSource partidaBindingSource;
        private Button btn_IrAtras;
        private BindingSource jugadorBindingSource;
        private BindingSource partidaBindingSource1;
        private BindingSource jugadorBindingSource1;
        private BindingSource jugadorBindingSource2;
        private BindingSource jugadorBindingSource3;
        private BindingSource jugadorBindingSource4;
        private DataGridView dgv_Estadisticas;
        private DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cantidadDePartidasJugadasDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cantidadDePartidasGanadasDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cantidadDePartidasPerdidasDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cantidadDeAnchosDeEspadaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cantidadDeAnchosDeBastoDataGridViewTextBoxColumn;
        private BindingSource jugadorBindingSource5;
        private ComboBox cmb_Estadisticas;
        private BindingSource partidaBindingSource2;
        private DataGridView dgv_Partidas;
        private BindingSource partidaBindingSource3;
        private DataGridViewTextBoxColumn ganadorDeLaPartidaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn PerdedorDeLaPartida;
        private DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
    }
}