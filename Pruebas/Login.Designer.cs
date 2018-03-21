namespace Pruebas
{
    partial class Login
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
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.shapeIngresar = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapePass = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeUser = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.txtSelect = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblIngresar = new System.Windows.Forms.Label();
            this.pnlIngresar = new System.Windows.Forms.Panel();
            this.pnlIngresar.SuspendLayout();
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.shapeIngresar,
            this.shapePass,
            this.shapeUser});
            this.shapeContainer1.Size = new System.Drawing.Size(322, 365);
            this.shapeContainer1.TabIndex = 4;
            this.shapeContainer1.TabStop = false;
            // 
            // shapeIngresar
            // 
            this.shapeIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.shapeIngresar.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.shapeIngresar.BorderColor = System.Drawing.Color.White;
            this.shapeIngresar.CornerRadius = 5;
            this.shapeIngresar.Location = new System.Drawing.Point(65, 276);
            this.shapeIngresar.Name = "shapeIngresar";
            this.shapeIngresar.Size = new System.Drawing.Size(200, 40);
            // 
            // shapePass
            // 
            this.shapePass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.shapePass.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.shapePass.BorderColor = System.Drawing.Color.White;
            this.shapePass.CornerRadius = 7;
            this.shapePass.Location = new System.Drawing.Point(65, 182);
            this.shapePass.Name = "shapePass";
            this.shapePass.Size = new System.Drawing.Size(200, 40);
            // 
            // shapeUser
            // 
            this.shapeUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.shapeUser.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.shapeUser.BorderColor = System.Drawing.Color.White;
            this.shapeUser.CornerRadius = 7;
            this.shapeUser.Location = new System.Drawing.Point(65, 104);
            this.shapeUser.Name = "shapeUser";
            this.shapeUser.SelectionColor = System.Drawing.Color.SteelBlue;
            this.shapeUser.Size = new System.Drawing.Size(200, 40);
            // 
            // txtSelect
            // 
            this.txtSelect.Location = new System.Drawing.Point(444, 107);
            this.txtSelect.Margin = new System.Windows.Forms.Padding(2);
            this.txtSelect.Name = "txtSelect";
            this.txtSelect.Size = new System.Drawing.Size(68, 20);
            this.txtSelect.TabIndex = 0;
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.Color.DarkGray;
            this.txtUser.Location = new System.Drawing.Point(90, 112);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(152, 24);
            this.txtUser.TabIndex = 1;
            this.txtUser.Text = "usuario";
            this.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUser.Click += new System.EventHandler(this.txtUser_Click);
            this.txtUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUser_KeyDown);
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.Color.DarkGray;
            this.txtPass.Location = new System.Drawing.Point(90, 191);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(152, 24);
            this.txtPass.TabIndex = 2;
            this.txtPass.Text = "contraseña";
            this.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPass.Click += new System.EventHandler(this.txtPass_Click);
            this.txtPass.Enter += new System.EventHandler(this.txtPass_Enter);
            this.txtPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPass_KeyDown);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkGray;
            this.lblTitulo.Location = new System.Drawing.Point(91, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(140, 59);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "login";
            // 
            // lblIngresar
            // 
            this.lblIngresar.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresar.ForeColor = System.Drawing.Color.White;
            this.lblIngresar.Location = new System.Drawing.Point(0, 0);
            this.lblIngresar.Name = "lblIngresar";
            this.lblIngresar.Size = new System.Drawing.Size(175, 38);
            this.lblIngresar.TabIndex = 3;
            this.lblIngresar.Text = "Ingresar";
            this.lblIngresar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblIngresar.Click += new System.EventHandler(this.lblIngresar_Click);
            // 
            // pnlIngresar
            // 
            this.pnlIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.pnlIngresar.Controls.Add(this.lblIngresar);
            this.pnlIngresar.Location = new System.Drawing.Point(79, 278);
            this.pnlIngresar.Name = "pnlIngresar";
            this.pnlIngresar.Size = new System.Drawing.Size(175, 38);
            this.pnlIngresar.TabIndex = 7;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(322, 365);
            this.ControlBox = false;
            this.Controls.Add(this.pnlIngresar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtSelect);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Login";
            this.pnlIngresar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.TextBox txtSelect;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape shapeIngresar;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape shapePass;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape shapeUser;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblIngresar;
        private System.Windows.Forms.Panel pnlIngresar;
    }
}