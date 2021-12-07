using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestãoHotelParaiso.Model
{
    class pessoa
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem;

        public pessoa(String Nome, String CPF, String RG, String DataNasc, String Endereco, String Cidade, String Estado, String Telefone, String Email)
        {
            cmd.CommandText = "insert into pessoa (des_nome, des_cpf, des_rg, dat_nasc, des_endereco, des_cidade, des_estado, des_tel, des_email)" +
                "VALUES (@nome, @cpf, @rg, @datanascimento, @endereço, @cidade, @estado, @telefone, @email)";

            cmd.Parameters.AddWithValue("@nome", Nome);
            cmd.Parameters.AddWithValue("@cpf", CPF);
            cmd.Parameters.AddWithValue("@rg", RG);
            cmd.Parameters.AddWithValue("@datanascimento", DataNasc);
            cmd.Parameters.AddWithValue("@endereço", Endereco);
            cmd.Parameters.AddWithValue("@cidade", Cidade);
            cmd.Parameters.AddWithValue("@estado", Estado);
            cmd.Parameters.AddWithValue("@telefone", Telefone);
            cmd.Parameters.AddWithValue("@email", Email);

            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();

                this.mensagem = "Cadastrado com Sucesso!!";
            }
            catch (SqlException)
            {
                this.mensagem = "Erro ao se conectar com o banco de Dados";
            }
        }
    }
}
