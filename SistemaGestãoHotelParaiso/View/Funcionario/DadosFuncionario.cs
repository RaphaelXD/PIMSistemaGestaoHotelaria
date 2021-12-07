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

namespace SistemaGestãoHotelParaiso.View.funcionario
{
    public partial class DadosFuncionario : Form
    {
        public DadosFuncionario()
        {
            InitializeComponent();
        }

        private void funcionarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.funcionarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD_SGHPDataSet);

        }

        private void DadosFuncionario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bD_SGHPDataSet.funcionario'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionarioTableAdapter.Fill(this.bD_SGHPDataSet.funcionario);

        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            MenuPrincipal Tela = new MenuPrincipal();
            Tela.Show();
            this.Close();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            SqlDataAdapter da1 = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();

            if (TxtPesquisa.Text == "")
            {
                cmd.CommandText = "SELECT * FROM funcionario";

                cmd.Connection = conexao.Conectar();
                DataTable dt = new DataTable();
                da1.SelectCommand = cmd;
                da1.Fill(dt);
                funcionarioDataGridView.DataSource = dt;
            }
            else
            {
                cmd.CommandText = "SELECT * FROM funcionario WHERE num_funcionario_mat = @lista";
                cmd.Parameters.AddWithValue("@lista", TxtPesquisa.Text);

                cmd.Connection = conexao.Conectar();
                DataTable dt = new DataTable();
                da1.SelectCommand = cmd;
                da1.Fill(dt);
                funcionarioDataGridView.DataSource = dt;
            }
        }
    }
}
