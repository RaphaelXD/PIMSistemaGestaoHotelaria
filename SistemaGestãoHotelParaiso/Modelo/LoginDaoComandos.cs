using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestãoHotelParaiso
{
    class LoginDaoComandos
    {
        public bool tem = false;
        public String mensagem = ""; //Se estiver vazia esta ok
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;
        public bool VerificarLogin(String login, String senha)
        {
            //Comandos SQL para verificar se tem o login no banco
            cmd.CommandText = "select des_login, des_senha from usuario where des_login = @login and des_senha = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows) //se foi encontrado alguma informação
                {
                    tem = true;
                }
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com Banco de Dados!";
            }
            return tem;
        }
    }
}
