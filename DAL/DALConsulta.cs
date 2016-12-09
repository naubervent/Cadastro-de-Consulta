using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultas2.DAL
{
    class DALConsulta
    {
        private Conexao objConexao;

        public DALConsulta(Conexao conexao)
        {
            objConexao = conexao;
        }

        public void Incluir(Consulta consulta)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;
            cmd.CommandText = "insert into Consulta([nomeMedico], [nomePaciente], [dataConsulta], [horarioConsulta], [observacoes]) "+
                                "VALUES(@nomemedico, @nomepaciente, @dataconsulta, @horarioconsulta, @observacoes)";
            cmd.Parameters.AddWithValue("@nomemedico", consulta.NomeMedico);
            cmd.Parameters.AddWithValue("@nomepaciente", consulta.NomePaciente);
            cmd.Parameters.AddWithValue("@dataconsulta", consulta.DataConsulta);
            cmd.Parameters.AddWithValue("@horarioconsulta", consulta.HoraConsulta);
            cmd.Parameters.AddWithValue("@observacoes", consulta.Observacoes);

            objConexao.Conectar();
            consulta.IdConsulta = Convert.ToInt32(cmd.ExecuteScalar());
            //consulta.DataConsulta = Convert.ToDateTime(cmd.ExecuteScalar());
            //consulta.HoraConsulta = Convert.ToDateTime(cmd.ExecuteScalar());
            objConexao.Desconectar();
        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Consulta where nomePaciente like '" +
            valor + "%'", objConexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        
    }
}
