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
            TransparencyKey = Color.FromArgb(0xAA, 0x00, 0xFF);
            BackColor = Color.FromArgb(0xAA, 0x00, 0xFF);
        }
    }
}
