using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultas2
{
    class Paciente
    {
        public Paciente()
        {
            this.Codigo = 0;
            this.Nome = "";
            this.Telefone = "";
        }

        public Paciente(int codigo, string nome, string telefone)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Telefone = telefone;
        }

        private int codigo;
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private string telefone;
        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }
    }
}
