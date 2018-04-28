namespace Pruebas
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pbxMinimizar = new System.Windows.Forms.PictureBox();
            this.pbxCerrar = new System.Windows.Forms.PictureBox();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnTrabajar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCerrar)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.pbxMinimizar);
            this.panel1.Controls.Add(this.pbxCerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1221, 49);
            this.panel1.TabIndex = 1;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(237, 9);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(19, 25);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = ".";
            // 
            // pbxMinimizar
            // 
            this.pbxMinimizar.Image = global::Pruebas.Properties.Resources.ic_do_not_disturb_on_white_64px;
            this.pbxMinimizar.Location = new System.Drawing.Point(1102, 0);
            this.pbxMinimizar.Name = "pbxMinimizar";
            this.pbxMinimizar.Size = new System.Drawing.Size(50, 49);
            this.pbxMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxMinimizar.TabIndex = 4;
            this.pbxMinimizar.TabStop = false;
            this.pbxMinimizar.Click += new System.EventHandler(this.pbxMinimizar_Click);
            // 
            // pbxCerrar
            // 
            this.pbxCerrar.Image = global::Pruebas.Properties.Resources.error;
            this.pbxCerrar.Location = new System.Drawing.Point(1159, 0);
            this.pbxCerrar.Name = "pbxCerrar";
            this.pbxCerrar.Size = new System.Drawing.Size(50, 49);
            this.pbxCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCerrar.TabIndex = 3;
            this.pbxCerrar.TabStop = false;
            this.pbxCerrar.Click += new System.EventHandler(this.pbxCerrar_Click);
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.Color.White;
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(237, 49);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(984, 596);
            this.pnlContenedor.TabIndex = 3;
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.Transparent;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.White;
            this.btnInicio.Location = new System.Drawing.Point(0, 94);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(237, 69);
            this.btnInicio.TabIndex = 0;
            this.btnInicio.Text = "Iniciar";
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnTrabajar
            // 
            this.btnTrabajar.BackColor = System.Drawing.Color.Transparent;
            this.btnTrabajar.FlatAppearance.BorderSize = 0;
            this.btnTrabajar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrabajar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrabajar.ForeColor = System.Drawing.Color.White;
            this.btnTrabajar.Location = new System.Drawing.Point(0, 165);
            this.btnTrabajar.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.btnTrabajar.Name = "btnTrabajar";
            this.btnTrabajar.Size = new System.Drawing.Size(237, 69);
            this.btnTrabajar.TabIndex = 1;
            this.btnTrabajar.Text = "Trabajar";
            this.btnTrabajar.UseVisualStyleBackColor = false;
            this.btnTrabajar.Click += new System.EventHandler(this.btnTrabajar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(35)))), ((int)(((byte)(53)))));
            this.panel2.Controls.Add(this.btnTrabajar);
            this.panel2.Controls.Add(this.btnInicio);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(237, 596);
            this.panel2.TabIndex = 2;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1221, 645);
            this.ControlBox = false;
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Principal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCerrar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbxMinimizar;
        private System.Windows.Forms.PictureBox pbxCerrar;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnTrabajar;
        private System.Windows.Forms.Panel panel2;
    }
}

