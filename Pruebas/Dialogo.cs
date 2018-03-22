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
    public partial class Dialogo : Form
    {
        static DialogResult dialogResult;

        public Dialogo(string titulo, string mensaje, string botonSI, string botonNO)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            lblProceso.Text = titulo;
            lblMensaje.Text = mensaje;
            btnSI.Text = botonSI;
            btnNO.Text = botonNO;
            TopMost = true;
            ShowDialog();
        }

        public static DialogResult Show(string titulo, string mensaje, string btnOK, string btnNO)
        {
            new Dialogo(titulo, mensaje, btnOK, btnNO);
            return dialogResult;
        }

        private void btnSI_Click(object sender, EventArgs e)
        {
            dialogResult = DialogResult.OK;
            Hide();
        }

        private void btnNO_Click(object sender, EventArgs e)
        {
            dialogResult = DialogResult.No;
            Hide();
        }
    }
}
