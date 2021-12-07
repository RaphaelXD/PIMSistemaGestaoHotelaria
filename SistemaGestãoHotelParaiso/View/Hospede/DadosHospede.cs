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

namespace SistemaGestãoHotelParaiso.View.Hospede
{
    public partial class DadosHospede : Form
    {
        public DadosHospede()
        {
            InitializeComponent();
        }

        private void pessoaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pessoaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD_SGHPDataSet);

        }

        private void DadosHospede_Load(object sender, EventArgs e)
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
            if (TxtPesquisa.Text == "")
            {
                string strConexao = "Data Source=.\\SQLEXPRESS;Initial Catalog=BD_SGHP;Integrated Security=True";
                string Query = "SELECT * FROM pessoa";

                SqlConnection conexao = new SqlConnection(strConexao);
                SqlDataAdapter dap = new SqlDataAdapter(Query, conexao);

                //Criei uma DataTable com a intensao de receber o retorno da
                DataTable tbp = new DataTable();

                //Alimentar a tb com o retorno de da
                dap.Fill(tbp);

                //Alimentar o DGVTabela usando o que tem no tb
                pessoaDataGridView.DataSource = tbp;

            }
            else
            {
                if (ValidarCPF.testeCPF(TxtPesquisa.Text))
                {
                    try
                    {
                        string strConexao = "Data Source=.\\SQLEXPRESS;Initial Catalog=BD_SGHP;Integrated Security=True";
                        string Query = "SELECT * FROM pessoa WHERE des_cpf = " + long.Parse(TxtPesquisa.Text);

                        SqlConnection conexao = new SqlConnection(strConexao);
                        SqlDataAdapter dap = new SqlDataAdapter(Query, conexao);

                        //Criei uma DataTable com a intensao de receber o retorno da
                        DataTable tbp = new DataTable();

                        //Alimentar a tb com o retorno de da
                        dap.Fill(tbp);

                        //Alimentar o DGVTabela usando o que tem no tb
                        pessoaDataGridView.DataSource = tbp;
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
