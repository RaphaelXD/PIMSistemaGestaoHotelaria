using SistemaGestãoHotelParaiso.Controle;
using SistemaGestãoHotelParaiso.Modelo;
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

namespace SistemaGestãoHotelParaiso.View.Hospede
{
    public partial class VerificaeReservaQuarto : Form
    {
        
        public VerificaeReservaQuarto()
        {
            InitializeComponent();
        }

        private void reserva_hospedagemBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.reserva_hospedagemBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD_SGHPDataSet);

        }

        private void escolha_quarto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bD_SGHPDataSet.tipo_apartamento'. Você pode movê-la ou removê-la conforme necessário.
            this.tipo_apartamentoTableAdapter.Fill(this.bD_SGHPDataSet.tipo_apartamento);
            // TODO: esta linha de código carrega dados na tabela 'bD_SGHPDataSet1.reserva_hospedagem'. Você pode movê-la ou removê-la conforme necessário.
            this.reserva_hospedagemTableAdapter.Fill(this.bD_SGHPDataSet1.reserva_hospedagem);
            // TODO: esta linha de código carrega dados na tabela 'bD_SGHPDataSet.apartamento'. Você pode movê-la ou removê-la conforme necessário.
            this.apartamentoTableAdapter.Fill(this.bD_SGHPDataSet.apartamento);
            // TODO: esta linha de código carrega dados na tabela 'bD_SGHPDataSet.reserva_hospedagem'. Você pode movê-la ou removê-la conforme necessário.
            this.reserva_hospedagemTableAdapter.Fill(this.bD_SGHPDataSet.reserva_hospedagem);

        }


        private void BtnConsultar_Click_1(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            SqlDataAdapter da1 = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT id_res_hospedagem, id_apartamento_num, val_total, dat_entrada, dat_saida, sta_apartamento  FROM reserva_hospedagem WHERE dat_saida BETWEEN @datainicio AND  @datafim";

            cmd.Parameters.Add("@Datainicio", SqlDbType.DateTime).Value = DTPInicio.Value.Date;
            cmd.Parameters.Add("@Datafim", SqlDbType.DateTime).Value = DTPFim.Value.Date;
            cmd.Connection = conexao.Conectar();
            DataTable dt = new DataTable();
            da1.SelectCommand = cmd;
            da1.Fill(dt);
            reserva_hospedagemDataGridView.DataSource = dt;
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.reserva_hospedagemTableAdapter.FillBy(this.bD_SGHPDataSet.reserva_hospedagem);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            MenuPrincipal mp = new MenuPrincipal();
            mp.Show();
            this.Close();
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            ValidarCampo VC = new ValidarCampo();
            if (VC.CampoVazio(TxtIDPessoa, "ID Pessoa"))
                return;

            if (VC.CampoVazio(DTPDataEntrada, "Data de Entrada"))
                return;

            if (VC.CampoVazio(CBNumApartamento, "Numero do quarto"))
                return;

            if (VC.CampoVazio(NumBoxValorApart, "Valor do quarto"))
                return;

            if (VC.CampoVazio(CBStatus, "Status"))
                return;

            ReservaHospede reserHosp = new ReservaHospede(
                TxtIDPessoa.Text,
                DTPDataEntrada.Value,
                DTPDataSaida.Value,
                CBNumApartamento.Text,
                NumBoxValorApart.Text,
                CBStatus.Text);

            MessageBox.Show("Dados cadastrados!", "Funcionarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
