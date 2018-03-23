using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
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

            if (Dialogo.Show("Notificación", "Desea crear el archivo Excel", "SI", "NO").Equals(DialogResult.OK))
            {
                string Nombre = "Prueba Exitosa";

                AppExcel = new Excel.Application();
                Libro = AppExcel.Workbooks.Add();
                Hoja = AppExcel.ActiveSheet;
                AppExcel.Visible = true;
                Hoja.Name = Nombre;

                //Libro.SaveAs("Prueba");
                Aviso.Mostrar("Notificación", " Proceso terminado con éxito", "Finalizar");
            }
            else
            {
                Aviso.Mostrar("Notificación", " Proceso terminado \nNo realizó proceso", "Finalizar");
            }



        }

        private void pbxCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbxMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnTrabajar_Click(object sender, EventArgs e)
        {

            Work work = new Work();
            work.Working += new Work.work(Notificar);

            Thread thread = new Thread(work.Trabajando);
            thread.Start();
        }

        public void Notificar(string mensaje)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => lblStatus.Text = mensaje));
            }
        }
    }
}
