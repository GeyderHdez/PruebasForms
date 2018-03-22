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
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            IniciaProceso();
        }

        public void IniciaProceso()
        {
            Aviso.Mostrar("Inicio", "Iniciando aplicación de Prueba", "Continuar");

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

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;

            dialogResult = Dialogo.Show("Responde SI o NO", "Seleccione un boton", "SI", "NO");

            Aviso.Mostrar("Boton seleccionado","El usuario eligió " + dialogResult.ToString(),"Aceptar");
        }
    }
}
