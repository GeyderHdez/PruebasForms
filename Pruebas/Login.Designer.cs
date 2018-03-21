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
            this.contenedor = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.txtSelect = new System.Windows.Forms.TextBox();
            this.shapeUser = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapePass = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeIngresar = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
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
            this.shapeUser,
            this.contenedor});
            this.shapeContainer1.Size = new System.Drawing.Size(402, 500);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // contenedor
            // 
            this.contenedor.BackColor = System.Drawing.Color.White;
            this.contenedor.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.contenedor.CornerRadius = 9;
            this.contenedor.Location = new System.Drawing.Point(0, 0);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(350, 450);
            // 
            // txtSelect
            // 
            this.txtSelect.Location = new System.Drawing.Point(444, 107);
            this.txtSelect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSelect.Name = "txtSelect";
            this.txtSelect.Size = new System.Drawing.Size(68, 20);
            this.txtSelect.TabIndex = 1;
            // 
            // shapeUser
            // 
            this.shapeUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.shapeUser.CornerRadius = 7;
            this.shapeUser.Location = new System.Drawing.Point(113, 112);
            this.shapeUser.Name = "shapeUser";
            this.shapeUser.Size = new System.Drawing.Size(166, 33);
            // 
            // shapePass
            // 
            this.shapePass.CornerRadius = 7;
            this.shapePass.Location = new System.Drawing.Point(113, 216);
            this.shapePass.Name = "shapePass";
            this.shapePass.Size = new System.Drawing.Size(159, 32);
            // 
            // shapeIngresar
            // 
            this.shapeIngresar.CornerRadius = 7;
            this.shapeIngresar.Location = new System.Drawing.Point(109, 298);
            this.shapeIngresar.Name = "shapeIngresar";
            this.shapeIngresar.Size = new System.Drawing.Size(159, 32);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.LightGray;
            this.lblLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLogin.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.White;
            this.lblLogin.Location = new System.Drawing.Point(142, 42);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(69, 25);
            this.lblLogin.TabIndex = 2;
            this.lblLogin.Text = "Login";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(117, 116);
            this.txtUser.Multiline = true;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(156, 25);
            this.txtUser.TabIndex = 3;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(117, 221);
            this.txtPass.Multiline = true;
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(152, 21);
            this.txtPass.TabIndex = 4;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 500);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.txtSelect);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Login";
            this.Text = "Login";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape contenedor;
        private System.Windows.Forms.TextBox txtSelect;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape shapeIngresar;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape shapePass;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape shapeUser;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
    }
}