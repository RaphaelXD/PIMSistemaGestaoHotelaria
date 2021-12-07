using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestãoHotelParaiso.Modelo
{
    class Funcionari
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem;

        public Funcionari(String Matricula, String DataAdmissao, String CTPS, String PIS, String Cargo)
        {
            cmd.CommandText = "insert into funcionario (num_funcionario_mat, data_admissao, num_cod_ctps, num_pis, des_cargo)" +
                "VALUES (@matricula, @admissao, @ctps, @pis, @cargo)";

            cmd.Parameters.AddWithValue("@matricula", Matricula);
            cmd.Parameters.AddWithValue("@admissao", DataAdmissao);
            cmd.Parameters.AddWithValue("@ctps", CTPS);
            cmd.Parameters.AddWithValue("@pis", PIS);
            cmd.Parameters.AddWithValue("@cargo", Cargo);

            try
            {
                cmd.Connection = conexao.Conectar();

                cmd.ExecuteNonQuery();

                conexao.Desconectar();

            }
            catch (SqlException)
            {
                this.mensagem = "Erro ao se conectar com o banco de Dados";
            }
        }
    }
}
