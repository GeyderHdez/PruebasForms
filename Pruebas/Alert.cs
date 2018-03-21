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
    public partial class Alert : Form
    {
        public Alert(string mensaje, AlertType type)
        {
            InitializeComponent();

            switch(type)
            {
                case AlertType.success:
                    BackColor = Color.SeaGreen;
                    lblMensaje.Text = mensaje;
                    break;
                case AlertType.info:
                    BackColor = Color.Gray;
                    lblMensaje.Text = mensaje;
                    break;
                case AlertType.warning:
                    BackColor = Color.OrangeRed;
                    lblMensaje.Text = mensaje;
                    break;
                case AlertType.error:
                    BackColor = Color.Crimson;
                    lblMensaje.Text = mensaje;
                    break;

            }
        }

        public enum AlertType
        {
          success, info, warning, error
        }

        private void Alert_Load(object sender, EventArgs e)
        {

        }
    }
}
