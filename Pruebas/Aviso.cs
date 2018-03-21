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
        public Aviso()
        {
            InitializeComponent();
        }

        public void Mostrar(string titulo, string mensaje, string boton)
        {
            lblNombre.Text = titulo;
            lblMensaje.Text = mensaje;
            btnAceptar.Text = boton;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            TopMost = true;
            StartPosition = FormStartPosition.CenterScreen;
            ShowDialog();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
