using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultas2
{
   public class Consulta
    {
            private int idConsulta;
            private string nomeMedico;
            private string nomePaciente;
            private DateTime dataConsulta;
            private DateTime horaConsulta;
            private string observacoes;

        /*public Consulta (int idConsulta, string nomeMedico, string nomePaciente, DateTime dataConsulta, DateTime horaConsulta, string observacoes)
        {
            this.Id_Consulta = idConsulta;
            this.Nome_Medico = nomeMedico;
            this.Nome_Paciente = nomePaciente;
            this.Data_Consulta = dataConsulta;
            this.Hora_Consulta = horaConsulta;
            this.Observacoes = observacoes;

        }*/

        public int IdConsulta
        {
            get { return idConsulta; }
            set { idConsulta = value; }
        }
        public string NomeMedico

        {
            get { return nomeMedico; }
            set { nomeMedico = value; }
        }

        public string NomePaciente
        {
            get { return nomePaciente; }
            set { nomePaciente = value; }
        }

        public DateTime DataConsulta
        {
            get { return dataConsulta; }
            set { dataConsulta = value; }
        }

       public DateTime HoraConsulta
        {
            get { return horaConsulta; }
            set { horaConsulta = value; }
        }

        public string Observacoes
        {
            get { return observacoes; }
            set { observacoes = value; }
        }

        /*private int idConsulta;
        public int IdConsulta
        {
            get { return idConsulta; }
            set { idConsulta = value; }
        }

        private string nomeMedico;
        public string NomeMedico
        {
            get { return nomeMedico; }
            set { nomeMedico = value; }
        }

        private string nomePaciente;
        public string NomePaciente
        {
            get { return nomePaciente; }
            set { nomePaciente = value; }
        }

        private DateTime dataConsulta;
        public DateTime DataConsulta
        {
            get { return dataConsulta; }
            set { dataConsulta = value; }
        }

        private DateTime horaConsulta;
        public DateTime HoraConsulta
        {
            get { return horaConsulta; }
            set { horaConsulta = value; }
        }*/


    }
}
