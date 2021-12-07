using SistemaGestãoHotelParaiso.Controle;
using SistemaGestãoHotelParaiso.Model;
using SistemaGestãoHotelParaiso.Modelo;
using SistemaGestãoHotelParaiso.View.Funcionario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestãoHotelParaiso.View
{
    public partial class CadastroFuncionario : Form
    {
        public CadastroFuncionario()
        {
            InitializeComponent();
        }

        private void BtnAvancar_Click(object sender, EventArgs e)
        {
            ValidarCampo VC = new ValidarCampo();
            if (VC.CampoVazio(TxtNome, "Nome"))
                return;

            if (VC.CampoVazio(TxtRG, "RG"))
                return;

            if(TxtCPF.Text == "")

                MessageBox.Show("Informe um CPF!", "CPF", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (ValidarCPF.testeCPF(TxtCPF.Text))
                {
                    try
                    {
                        pessoa cp = new pessoa(TxtNome.Text, TxtCPF.Text, TxtRG.Text, TxtDatNasc.Text, TxtEndereco.Text, TxtCidade.Text, CBEstado.Text, TxtTel.Text, TxtEmail.Text);
                        MessageBox.Show("Dados cadastrados!", "Funcionarios", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        CadastroDadosProfissinaisFuncionario ff = new CadastroDadosProfissinaisFuncionario();
                        ff.Show();
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao cadastrar funcionario\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Informe um CPF válido!", "CPF", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            MenuPrincipal mp = new MenuPrincipal();
            mp.Show();
            this.Close();
        }
    }
}
