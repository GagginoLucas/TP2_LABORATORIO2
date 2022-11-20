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
            this.dgv_Estadisticas = new System.Windows.Forms.DataGridView();
            this.ganadorDeLaPartidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perdedorDeLaPartidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partidaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_IrAtras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Estadisticas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partidaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Estadisticas
            // 
            this.dgv_Estadisticas.AllowUserToAddRows = false;
            this.dgv_Estadisticas.AllowUserToDeleteRows = false;
            this.dgv_Estadisticas.AllowUserToResizeColumns = false;
            this.dgv_Estadisticas.AllowUserToResizeRows = false;
            this.dgv_Estadisticas.AutoGenerateColumns = false;
            this.dgv_Estadisticas.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.dgv_Estadisticas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_Estadisticas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgv_Estadisticas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Estadisticas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ganadorDeLaPartidaDataGridViewTextBoxColumn,
            this.perdedorDeLaPartidaDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn});
            this.dgv_Estadisticas.DataSource = this.partidaBindingSource;
            this.dgv_Estadisticas.Location = new System.Drawing.Point(102, 32);
            this.dgv_Estadisticas.Name = "dgv_Estadisticas";
            this.dgv_Estadisticas.RowTemplate.Height = 25;
            this.dgv_Estadisticas.Size = new System.Drawing.Size(346, 221);
            this.dgv_Estadisticas.TabIndex = 0;
            // 
            // ganadorDeLaPartidaDataGridViewTextBoxColumn
            // 
            this.ganadorDeLaPartidaDataGridViewTextBoxColumn.DataPropertyName = "GanadorDeLaPartida";
            this.ganadorDeLaPartidaDataGridViewTextBoxColumn.HeaderText = "Ganador";
            this.ganadorDeLaPartidaDataGridViewTextBoxColumn.Name = "ganadorDeLaPartidaDataGridViewTextBoxColumn";
            // 
            // perdedorDeLaPartidaDataGridViewTextBoxColumn
            // 
            this.perdedorDeLaPartidaDataGridViewTextBoxColumn.DataPropertyName = "PerdedorDeLaPartida";
            this.perdedorDeLaPartidaDataGridViewTextBoxColumn.HeaderText = "Perdedor";
            this.perdedorDeLaPartidaDataGridViewTextBoxColumn.Name = "perdedorDeLaPartidaDataGridViewTextBoxColumn";
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            // 
            // partidaBindingSource
            // 
            this.partidaBindingSource.DataSource = typeof(Biblioteca.Modelos.Partida);
            // 
            // btn_IrAtras
            // 
            this.btn_IrAtras.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_IrAtras.Location = new System.Drawing.Point(206, 278);
            this.btn_IrAtras.Name = "btn_IrAtras";
            this.btn_IrAtras.Size = new System.Drawing.Size(119, 40);
            this.btn_IrAtras.TabIndex = 1;
            this.btn_IrAtras.Text = "IR ATRAS";
            this.btn_IrAtras.UseVisualStyleBackColor = true;
            this.btn_IrAtras.Click += new System.EventHandler(this.btn_IrAtras_Click);
            // 
            // frm_Estadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vista.Properties.Resources.fondo_agregarPartida;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(536, 342);
            this.ControlBox = false;
            this.Controls.Add(this.btn_IrAtras);
            this.Controls.Add(this.dgv_Estadisticas);
            this.Name = "frm_Estadisticas";
            this.ShowIcon = false;
            this.Text = "Estadisticas";
            this.Load += new System.EventHandler(this.frm_Estadisticas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Estadisticas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partidaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgv_Estadisticas;
        private DataGridViewTextBoxColumn ganadorDeLaPartidaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn perdedorDeLaPartidaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private BindingSource partidaBindingSource;
        private Button btn_IrAtras;
    }
}