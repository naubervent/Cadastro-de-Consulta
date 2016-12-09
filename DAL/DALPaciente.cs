using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Consultas2.DAL
{
    class DALPaciente
    {
        private Conexao objConexao; 
        public DALPaciente(Conexao conexao)
        {
            objConexao = conexao;
        }

        public void Incluir(Paciente paciente)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;
            cmd.CommandText = "insert into Paciente([nomePaciente], [telefone]) "+
                                "VALUES (@nome, @telefone)";
            cmd.Parameters.AddWithValue("@nome", paciente.Nome);
            cmd.Parameters.AddWithValue("@telefone", paciente.Telefone);

            objConexao.Conectar();
            paciente.Codigo = Convert.ToInt32(cmd.ExecuteScalar());
        }
    }
}
