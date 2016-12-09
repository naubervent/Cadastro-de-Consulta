using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Consultas2.DAL
{
    class DALMedico
    {
        private Conexao objConexao;
        public DALMedico(Conexao conexao)
        {
            objConexao = conexao; //DALLCategoria na outa video aula
        }

        public void Incluir(Medico medico)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;
            cmd.CommandText = "insert into Medico([nomeMedico], [crmMedico]) "+
                                "VALUES (@nome, @crm)";
            cmd.Parameters.AddWithValue("@nome", medico.Nome);
            cmd.Parameters.AddWithValue("@crm", medico.Crm);

            objConexao.Conectar();
            medico.Idmedico = Convert.ToInt32(cmd.ExecuteScalar());
            objConexao.Desconectar();
        }
    }
}
