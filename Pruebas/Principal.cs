using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;


namespace Pruebas
{
    public partial class Principal : Form
    {
        Excel.Application AppExcel;
        Excel.Workbook Libro;
        Excel.Worksheet Hoja;

        public Principal()
        {
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            //IniciaProceso();
        }

        public void IniciaProceso()
        {
            Aviso aviso = new Aviso();

            aviso.Mostrar("Inicio", "Iniciando aplicación de Prueba", "Continuar");

            string Nombre = "Prueba Exitosa";

            AppExcel = new Excel.Application();
            Libro = AppExcel.Workbooks.Add();
            Hoja = AppExcel.ActiveSheet;
            AppExcel.Visible = true;

            //Libro.SaveAs("Prueba");
            Hoja.Name = Nombre;
        }

        private void pbxCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbxMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
