namespace Vista
{
    partial class frm_Mesa
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
            this.lbl_CartasJugador1 = new System.Windows.Forms.Label();
            this.lbl_CartasJugador2 = new System.Windows.Forms.Label();
            this.tmr_Partida = new System.Windows.Forms.Timer(this.components);
            this.rtx_Partida = new System.Windows.Forms.RichTextBox();
            this.btn_IrAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_CartasJugador1
            // 
            this.lbl_CartasJugador1.AutoSize = true;
            this.lbl_CartasJugador1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CartasJugador1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_CartasJugador1.Location = new System.Drawing.Point(137, 33);
            this.lbl_CartasJugador1.Name = "lbl_CartasJugador1";
            this.lbl_CartasJugador1.Size = new System.Drawing.Size(0, 25);
            this.lbl_CartasJugador1.TabIndex = 2;
            // 
            // lbl_CartasJugador2
            // 
            this.lbl_CartasJugador2.AutoSize = true;
            this.lbl_CartasJugador2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CartasJugador2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_CartasJugador2.Location = new System.Drawing.Point(137, 301);
            this.lbl_CartasJugador2.Name = "lbl_CartasJugador2";
            this.lbl_CartasJugador2.Size = new System.Drawing.Size(0, 25);
            this.lbl_CartasJugador2.TabIndex = 3;
            // 
            // tmr_Partida
            // 
            this.tmr_Partida.Enabled = true;
            this.tmr_Partida.Interval = 2000;
            this.tmr_Partida.Tick += new System.EventHandler(this.tmr_Partida_Tick);
            // 
            // rtx_Partida
            // 
            this.rtx_Partida.BackColor = System.Drawing.SystemColors.HighlightText;
            this.rtx_Partida.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.rtx_Partida.Location = new System.Drawing.Point(489, 33);
            this.rtx_Partida.Name = "rtx_Partida";
            this.rtx_Partida.Size = new System.Drawing.Size(379, 362);
            this.rtx_Partida.TabIndex = 8;
            this.rtx_Partida.Text = " ";
            this.rtx_Partida.TextChanged += new System.EventHandler(this.rtx_Partida_TextChanged);
            // 
            // btn_IrAtras
            // 
            this.btn_IrAtras.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_IrAtras.Location = new System.Drawing.Point(637, 417);
            this.btn_IrAtras.Name = "btn_IrAtras";
            this.btn_IrAtras.Size = new System.Drawing.Size(98, 31);
            this.btn_IrAtras.TabIndex = 12;
            this.btn_IrAtras.Text = "IR ATRAS";
            this.btn_IrAtras.UseVisualStyleBackColor = true;
            this.btn_IrAtras.Click += new System.EventHandler(this.btn_IrAtras_Click);
            // 
            // frm_Mesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vista.Properties.Resources.fondo_agregarPartida;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(880, 485);
            this.ControlBox = false;
            this.Controls.Add(this.btn_IrAtras);
            this.Controls.Add(this.rtx_Partida);
            this.Controls.Add(this.lbl_CartasJugador2);
            this.Controls.Add(this.lbl_CartasJugador1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_Mesa";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mesa de juego";
            this.Load += new System.EventHandler(this.frm_Mesa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lbl_CartasJugador1;
        private Label lbl_CartasJugador2;
        private System.Windows.Forms.Timer tmr_Partida;
        private RichTextBox rtx_Partida;
        private Button btn_IrAtras;
    }
}