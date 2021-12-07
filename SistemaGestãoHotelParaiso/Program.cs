using SistemaGestãoHotelParaiso.View;
using SistemaGestãoHotelParaiso.View.funcionario;
using SistemaGestãoHotelParaiso.View.Funcionario;
using SistemaGestãoHotelParaiso.View.Hospede;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestãoHotelParaiso
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TelaLogin());
        }
    }
}
