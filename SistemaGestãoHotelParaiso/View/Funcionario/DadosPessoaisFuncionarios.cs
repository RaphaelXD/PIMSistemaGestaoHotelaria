using SistemaGestãoHotelParaiso.Controle;
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
    public partial class DadosPessoaisFuncionarios : Form
    {
        public DadosPessoaisFuncionarios()
        {
            InitializeComponent();
        }

        private void pessoaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pessoaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD_SGHPDataSet);

        }

        private void DadosPessoaisFuncionarios_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bD_SGHPDataSet.pessoa'. Você pode movê-la ou removê-la conforme necessário.
            this.pessoaTableAdapter.Fill(this.bD_SGHPDataSet.pessoa);

        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            MenuPrincipal mp = new MenuPrincipal();
            mp.Show();
            this.Close();
        }


        private void BtnPesquisar_Click(object sender, EventArgs e)
        {

            Conexao conexao = new Conexao();
            SqlDataAdapter da1 = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();

            if (TxtPesquisa.Text == "")
            {
                cmd.CommandText = "SELECT * FROM pessoa";

                cmd.Connection = conexao.Conectar();
                DataTable dt = new DataTable();
                da1.SelectCommand = cmd;
                da1.Fill(dt);
                pessoaDataGridView.DataSource = dt;
            }
            else
            {
                if (ValidarCPF.testeCPF(TxtPesquisa.Text))
                {
                    try
                    {
                        cmd.CommandText = "SELECT id_pessoa,des_nome,des_cpf FROM pessoa WHERE des_cpf = @cpf";
                        cmd.Parameters.AddWithValue("@cpf", long.Parse(TxtPesquisa.Text));

                        cmd.Connection = conexao.Conectar();
                        DataTable dt = new DataTable();
                        da1.SelectCommand = cmd;
                        da1.Fill(dt);
                        pessoaDataGridView.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao Buscar funcionario\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Informe um CPF válido!", "CPF", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
