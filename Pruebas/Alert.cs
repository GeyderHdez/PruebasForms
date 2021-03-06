﻿using System;
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
    public partial class Alert : Form
    {
        public Alert(string mensaje, AlertType type)
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(2, 2, Width, Height, 15, 15));
            switch (type)
            {
                case AlertType.success:
                    BackColor = Color.SeaGreen;
                    lblMensaje.Text = mensaje;
                    icon.Image = ListaIcon.Images[0];
                    break;
                case AlertType.info:
                    BackColor = Color.Gray;
                    lblMensaje.Text = mensaje;
                    icon.Image = ListaIcon.Images[1];
                    break;
                case AlertType.warning:
                    BackColor = Color.OrangeRed;
                    lblMensaje.Text = mensaje;
                    icon.Image = ListaIcon.Images[2];
                    break;
                case AlertType.error:
                    BackColor = Color.Red;
                    lblMensaje.Text = mensaje;
                    icon.Image = ListaIcon.Images[3];
                    break;

            }
        }

        public static void Show(string mensaje, AlertType type)
        {
            new Alert(mensaje, type).Show();
        }

        public enum AlertType
        {
            success, info, warning, error
        }

        private void Alert_Load(object sender, EventArgs e)
        {
            Top = -1 * Height;
            //Left = (Screen.PrimaryScreen.Bounds.Width /2) - (Width/2);
            Left = Screen.PrimaryScreen.Bounds.Width - Width -60;
            show.Start();
            timeOut.Start();
        }

        private void timeOut_Tick(object sender, EventArgs e)
        {
            close.Start();
        }

        int interval = 0;
        private void show_Tick(object sender, EventArgs e)
        {
            if (Top < 60)
            {
                Top += interval;
                interval += 10;
            }
            else
            {
                show.Stop();
            }
        }

        private void close_Tick(object sender, EventArgs e)
        {
            if (Opacity > 0)
            {
                Opacity -= 0.2;
            }
            else
                Hide();
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
    }
}
