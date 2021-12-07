using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestãoHotelParaiso.View
{
    public partial class Reserva : Form
    {
       

        public Reserva()
        {
            InitializeComponent();
        }

        private void Reserva_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bD_SGHPDataSet.reserva_hospedagem'. Você pode movê-la ou removê-la conforme necessário.
            this.reserva_hospedagemTableAdapter.Fill(this.bD_SGHPDataSet.reserva_hospedagem);
            // TODO: esta linha de código carrega dados na tabela 'bD_SGHPDataSet.reserva_hospedagem'. Você pode movê-la ou removê-la conforme necessário.
            this.reserva_hospedagemTableAdapter.Fill(this.bD_SGHPDataSet.reserva_hospedagem);

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            MenuPrincipal mp = new MenuPrincipal();
            mp.Show();
            this.Close();
        }

        private void reserva_hospedagemBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.reserva_hospedagemBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD_SGHPDataSet);

        }

        private void reserva_hospedagemBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.reserva_hospedagemBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD_SGHPDataSet);

        }
    }
}
