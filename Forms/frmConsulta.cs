using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Consultas2.DAL;

namespace Consultas2
{
    public partial class frmConsulta : Form
    {
        public frmConsulta()
        {
            InitializeComponent();
        }

        private void consultaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void frmConsulta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'consultorio2DataSet.Paciente' table. You can move, or remove it, as needed.
            this.pacienteTableAdapter.Fill(this.consultorio2DataSet.Paciente);
            // TODO: This line of code loads data into the 'consultorio2DataSet.Medico' table. You can move, or remove it, as needed.
            this.medicoTableAdapter.Fill(this.consultorio2DataSet.Medico);
            LimparCampos();

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Consulta consulta = new Consulta();
            dtConsulta.Text = Convert.ToString(DateTime.Now);
            hrConsulta.Text = Convert.ToString(DateTime.Now);

            consulta.NomeMedico = cmbNomeMedico.Text;
            consulta.NomePaciente = cmbNomePaciente.Text;            
            consulta.DataConsulta = Convert.ToDateTime(dtConsulta.Text);
            consulta.HoraConsulta = Convert.ToDateTime(hrConsulta.Text);
            consulta.Observacoes = txtObservacoes.Text;

            Conexao conexao = new Conexao(DadosDaConexao.StringDeConexao);
            DALConsulta dal = new DALConsulta(conexao);
            try
            {
                dal.Incluir(consulta);
                MessageBox.Show("Consulta salvo no banco de dados.");
                LimparCampos();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void LimparCampos()
        {
            foreach(Control ctr in this.Controls)
            {
                if (ctr is TextBox)
                    (ctr as TextBox).Text = "";
                if (ctr is ComboBox)
                    (ctr as ComboBox).SelectedIndex = -1;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            frmPrincipal carrega = new frmPrincipal();
            carrega.ShowDialog();
        }
    }
}
