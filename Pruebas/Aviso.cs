using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pruebas
{
    public partial class Aviso : Form
    {
        public Aviso(string titulo, string mensaje, string boton)
        {
            InitializeComponent();

            lblNombre.Text = titulo;
            lblMensaje.Text = mensaje;
            btnAceptar.Text = boton;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterScreen;
            TopMost = true;
            ShowDialog();
        }

        public static void Mostrar(string titulo, string mensaje, string boton)
        {
            new Aviso(titulo, mensaje, boton);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Hide();
            Dispose();
        }
    }
}
