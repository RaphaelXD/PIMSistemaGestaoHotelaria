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
    public partial class CheckINCheckOut : Form
    {
        public CheckINCheckOut()
        {
            InitializeComponent();
        }

        private void reserva_hospedagemBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.reserva_hospedagemBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD_SGHPDataSet);

        }

        private void CheckINCheckOut_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bD_SGHPDataSet.reserva_hospedagem'. Você pode movê-la ou removê-la conforme necessário.
            this.reserva_hospedagemTableAdapter.Fill(this.bD_SGHPDataSet.reserva_hospedagem);

        }

        private void BtnConsulta_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            SqlDataAdapter da1 = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();

            if (TxtConsulta.Text == "")
            {
                cmd.CommandText = "SELECT *  FROM reserva_hospedagem";
                cmd.Connection = conexao.Conectar();
                DataTable dt = new DataTable();
                da1.SelectCommand = cmd;
                da1.Fill(dt);
                reserva_hospedagemDataGridView.DataSource = dt;
            }
            else
            {
                cmd.CommandText = "SELECT *  FROM reserva_hospedagem WHERE id_res_hospedagem = @pesquisa ";
                cmd.Parameters.AddWithValue("@pesquisa", TxtConsulta.Text);
                cmd.Connection = conexao.Conectar();
                DataTable dt = new DataTable();
                da1.SelectCommand = cmd;
                da1.Fill(dt);
                reserva_hospedagemDataGridView.DataSource = dt;
            }
            
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            MenuPrincipal mp = new MenuPrincipal();
            mp.Show();
            this.Close();
        }

        private void BtnCheckIN_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            SqlDataAdapter da1 = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = 
                "UPDATE reserva_hospedagem " +
                "SET dat_checkin = @checkin, sta_apartamento = @status " +
                "WHERE id_res_hospedagem = @idreserva";
            cmd.Parameters.AddWithValue("@checkin", DTPCheckIN.Value);
            cmd.Parameters.AddWithValue("@status", CBStatus.Text);
            cmd.Parameters.AddWithValue("@idreserva", TxtIDReserva.Text);

            cmd.Connection = conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        private void BtnCheckOUT_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            SqlDataAdapter da1 = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = 
                "UPDATE reserva_hospedagem " +
                "SET dat_saida = @saida, dat_checkout= @checkout, var_acrescimo = @valortotal, sta_apartamento = @status " +
                "WHERE id_res_hospedagem = @idreserva";

            cmd.Parameters.AddWithValue("@saida", DTPSaida.Value);
            cmd.Parameters.AddWithValue("@checkout", DTPCheckOUT.Value);
            cmd.Parameters.AddWithValue("@valortotal", TxtValorTotal.Text);
            cmd.Parameters.AddWithValue("@status", CBStatus.Text);
            cmd.Parameters.AddWithValue("@idreserva", TxtIDReserva.Text);

            cmd.Connection = conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
    }
}
