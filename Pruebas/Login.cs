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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            txtSelect.Select();
        }

        private void txtUser_Click(object sender, EventArgs e)
        {
            txtUser.Text = "";
        }

        private void txtPass_Click(object sender, EventArgs e)
        {
            txtPass.Text = "";
        }

        private void lblIngresar_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            principal.Show();

            Hide();
        }
    }
}
