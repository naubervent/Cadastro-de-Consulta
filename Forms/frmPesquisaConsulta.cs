using Consultas2.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultas2
{
    public partial class frmPesquisaConsulta : Form
    {
        public frmPesquisaConsulta()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao(DadosDaConexao.StringDeConexao);
            DALConsulta dal = new DALConsulta(conexao);
            dgvDados.DataSource = dal.Localizar(txtValor.Text);
        }

        private void frmPesquisaConsulta_Load(object sender, EventArgs e)
        {
            btnExecutar_Click(sender, e);
            dgvDados.Columns[0].HeaderText = "Código";
            dgvDados.Columns[0].Width = 45;
            dgvDados.Columns[1].HeaderText = "Paciente";
            dgvDados.Columns[1].Width = 698;
            /*dgvDados.Columns[2].HeaderText = "Médico";
            dgvDados.Columns[2].Width = 277;
            dgvDados.Columns[3].HeaderText = "Data da Consulta";
            dgvDados.Columns[3].Width = 141;*/

        }
    }
}
