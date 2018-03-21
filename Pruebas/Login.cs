﻿using System;
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
            BringToFront();
            txtSelect.Select();
        }
      
        private void lblIngresar_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            principal.Show();

            Hide();
        }

        private void txtUser_Click(object sender, EventArgs e)
        {
            txtUser.Text = "";
        }

        private void txtPass_Click(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
            txtPass.Text = "";
            txtPass.PasswordChar = '*';
        }

       
        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                txtPass.UseSystemPasswordChar = true;
                txtPass.Text = "";
                txtPass.PasswordChar = '*';
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
                    //Ingresar();
                }
            }
        }

       

    }
}
