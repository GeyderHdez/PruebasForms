namespace Pruebas
{
    partial class Alert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alert));
            this.lblMensaje = new System.Windows.Forms.Label();
            this.icon = new System.Windows.Forms.PictureBox();
            this.ListaIcon = new System.Windows.Forms.ImageList(this.components);
            this.timeOut = new System.Windows.Forms.Timer(this.components);
            this.show = new System.Windows.Forms.Timer(this.components);
            this.close = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMensaje
            // 
            this.lblMensaje.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(71, 28);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(212, 23);
            this.lblMensaje.TabIndex = 0;
            this.lblMensaje.Text = "Welcome";
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // icon
            // 
            this.icon.Image = ((System.Drawing.Image)(resources.GetObject("icon.Image")));
            this.icon.Location = new System.Drawing.Point(13, 12);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(50, 50);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon.TabIndex = 1;
            this.icon.TabStop = false;
            // 
            // ListaIcon
            // 
            this.ListaIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ListaIcon.ImageStream")));
            this.ListaIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.ListaIcon.Images.SetKeyName(0, "success.png");
            this.ListaIcon.Images.SetKeyName(1, "info.png");
            this.ListaIcon.Images.SetKeyName(2, "warning.png");
            this.ListaIcon.Images.SetKeyName(3, "error.png");
            // 
            // timeOut
            // 
            this.timeOut.Interval = 3000;
            this.timeOut.Tick += new System.EventHandler(this.timeOut_Tick);
            // 
            // show
            // 
            this.show.Tick += new System.EventHandler(this.show_Tick);
            // 
            // close
            // 
            this.close.Tick += new System.EventHandler(this.close_Tick);
            // 
            // Alert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(311, 74);
            this.ControlBox = false;
            this.Controls.Add(this.icon);
            this.Controls.Add(this.lblMensaje);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Alert";
            this.Opacity = 0.9D;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Alert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.ImageList ListaIcon;
        private System.Windows.Forms.Timer close;
        public System.Windows.Forms.Timer timeOut;
        public System.Windows.Forms.Timer show;
    }
}