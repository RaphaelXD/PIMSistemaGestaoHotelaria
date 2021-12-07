using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestãoHotelParaiso.Modelo
{
    class ReservaHospede
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem;

        public ReservaHospede(String ID,  DateTime DataEntrada, DateTime DataSaida, String NumApartamento, String ValorApartamento, String Status)
        {
            cmd.CommandText = "insert into reserva_hospedagem (id_pessoa, dat_entrada, dat_saida, id_apartamento_num, val_total, sta_apartamento)" +
                "VALUES (@idpessoa, @dataentrada, @datasaida, @numeroapartament, @valorapartamento, @statusapartamento)";

            cmd.Parameters.AddWithValue("@idpessoa", ID);
            cmd.Parameters.AddWithValue("@dataentrada", DataEntrada);
            cmd.Parameters.AddWithValue("@datasaida", DataSaida);
            cmd.Parameters.AddWithValue("@numeroapartament", NumApartamento);
            cmd.Parameters.AddWithValue("@valorapartamento", ValorApartamento);
            cmd.Parameters.AddWithValue("@statusapartamento", Status);

            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();

                this.mensagem = "Reserva confirmada!!";
            }
            catch (SqlException)
            {
                this.mensagem = "Erro ao se conectar com o banco de Dados";
            }
        }
    }
}
