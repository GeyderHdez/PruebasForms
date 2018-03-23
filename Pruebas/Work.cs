using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Pruebas
{
    class Work
    {
        public delegate void work(string notificacion);

        public event work Working;

        public void Trabajando()
        {
            Working("Iniciando trabajo");
            for (int i = 0; i <= 100000; i++)
            {
                if (i % 1000 == 0)
                {
                    Thread.Sleep(500);
                    Working("Vamos en el numero " + i);
                }
            }
            Working("Trabajo terminado");
        }
    }
}
