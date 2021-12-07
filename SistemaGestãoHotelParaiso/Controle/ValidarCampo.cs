using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestãoHotelParaiso.Controle
{
    public class ValidarCampo
    {
        public bool CampoVazio(Control ControleForm, string campo)
        {
            if (ControleForm.Text == "")
            {
                MessageBox.Show("O campo " + campo + " esta incorreto.");
                ControleForm.Focus();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

