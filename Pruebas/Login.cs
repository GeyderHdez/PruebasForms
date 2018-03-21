using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Pruebas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            Region = Region.FromHrgn(CreateRoundRectRgn(2, 2, Width, Height, 20, 20));

            StartPosition = FormStartPosition.CenterScreen;
            BringToFront();
            txtSelect.Select();
        }


        private void lblIngresar_Click(object sender, EventArgs e)
        {
            if (txtUser.Text.Equals("geyder") && txtPass.Text.Equals("geyder"))
            {
                Ingresar();
            }
            else
            {
                Alert.Show("usuario no válido", Alert.AlertType.warning);

            }
        }

        private void txtUser_Click(object sender, EventArgs e)
        {
            txtUser.Text = "";
            if (txtPass.Text == "")
            {
                txtPass.Text = "";
                txtPass.UseSystemPasswordChar = false;
                txtPass.Text = "password";
            }
        }

        private void txtPass_Click(object sender, EventArgs e)
        {
            txtPass.Text = "";
            txtPass.UseSystemPasswordChar = true;
            if (txtUser.Text == "")
            {
                txtUser.Text = "usuario";
            }
        }


        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                txtPass.UseSystemPasswordChar = true;
                txtPass.Text = "";
                txtPass.Focus();

                if (txtUser.Text == "")
                {
                    txtUser.Text = "usuario";
                }
            }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                if (txtPass.Text == "")
                {
                    txtPass.UseSystemPasswordChar = false;
                    txtPass.Text = "contraseña";
                }

                if (txtUser.Text == "usuario")
                {
                    txtUser.Focus();
                }
                else
                {
                    if (txtUser.Text.Equals("geyder") && txtPass.Text.Equals("geyder"))
                    {
                        Ingresar();
                    }
                    else
                    {
                        Alert.Show("usuario no válido", Alert.AlertType.warning);
                    }
                }
            }
        }


        private void txtPass_Enter(object sender, EventArgs e)
        {
            txtPass.Text = "";
            txtPass.UseSystemPasswordChar = true;
        }

        void Ingresar()
        {
            Principal principal = new Principal();
            principal.Show();
            Hide();
            Alert.Show("Ingreso exitoso", Alert.AlertType.success);
        }


        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, // x-coordinate of upper-left corner
            int nTopRect, // y-coordinate of upper-left corner
            int nRightRect, // x-coordinate of lower-right corner
            int nBottomRect, // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
            );

    }
}
