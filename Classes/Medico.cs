using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultas2
{
    public class Medico
    {
        public Medico()
        {
            this.Idmedico = 0;
            this.Nome = "";
            this.Crm = "";
        }

        public Medico(int idMedico, string nomeMedico, string crm)
        {
            this.Idmedico = idMedico;
            this.Nome = nomeMedico;
            this.Crm = crm;            
        }


        private int idMedico;
        public int Idmedico
        {
            get { return idMedico; }
            set { idMedico = value; }
        }

        private string nomeMedico;
        public string Nome
        {
            get { return nomeMedico; }
            set { nomeMedico = value; }
        }

        private string crm;
        public string Crm
        {
            get { return crm; }
            set { crm = value; }
        }

        
    }
}
