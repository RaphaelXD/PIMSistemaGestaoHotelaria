using SistemaGestãoHotelParaiso.View;
using SistemaGestãoHotelParaiso.View.funcionario;
using SistemaGestãoHotelParaiso.View.Hospede;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestãoHotelParaiso
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void BtnCadFunc_Click(object sender, EventArgs e)
        {
            CadastroFuncionario cf = new CadastroFuncionario();
            cf.Show();
            this.Hide();
        }


        private void BtnCadHosp_Click(object sender, EventArgs e)
        {
            CadastroHospede ch = new CadastroHospede();
            ch.Show();
            this.Hide();
        }
        private void BtnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Quer sair do menu?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                TelaLogin tl = new TelaLogin();
                tl.Show();
                this.Close();
                this.Dispose();
            }
        }

        private void BtnInfo_Click(object sender, EventArgs e)
        {
            Info Tela = new Info();
            Tela.Show();
            this.Hide();
        }

        private void BtnAlterarFuncionario_Click(object sender, EventArgs e)
        {
            DadosPessoaisFuncionarios AltFunc = new DadosPessoaisFuncionarios();
            AltFunc.Show();
            this.Hide();
        }

        private void BtnQuartos_Click(object sender, EventArgs e)
        {
            CheckINCheckOut checkin_out = new CheckINCheckOut();
            checkin_out.Show();
            this.Hide();
        }

        private void BtnDadosFunc_Click(object sender, EventArgs e)
        {
            DadosFuncionario DadoFunc = new DadosFuncionario();
            DadoFunc.Show();
            this.Hide();
        }

        private void BtnDadosHospede_Click(object sender, EventArgs e)
        {
            DadosHospede DadoHosp = new DadosHospede();
            DadoHosp.Show();
            this.Hide();
        }

        private void BtnReservas_Click(object sender, EventArgs e)
        {
            VerificaeReservaQuarto vrq = new VerificaeReservaQuarto();
            vrq.Show();
            this.Hide();
        }
    }
}
