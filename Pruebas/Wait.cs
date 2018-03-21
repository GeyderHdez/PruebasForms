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
    public partial class Wait : Form
    {
        bool activo;
        public Wait()
        {
            InitializeComponent();
            Show();
            BringToFront();
            activo = true;
        }

        public void Work(string proceso, string mensaje)
        {
            if (activo)
            {
                lblNombreProceso.Text = proceso;
                lblStatus.Text = mensaje;
                Application.DoEvents();
            }
        }

        public void Stop()
        {
            Dispose();
        }
    }
}
