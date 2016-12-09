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
    public partial class frmPaciente : Form
    {
        public frmPaciente()
        {
            InitializeComponent();
        }

        private void pacienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pacienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.consultorio2DataSet);

        }

        private void frmPaciente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'consultorio2DataSet.Paciente' table. You can move, or remove it, as needed.
            this.pacienteTableAdapter.Fill(this.consultorio2DataSet.Paciente);
            LimparCampos();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Paciente paciente = new Paciente();
            paciente.Nome = txtNome.Text;
            paciente.Telefone = txtTelefone.Text;

            //String strConexao = @"Data Source=DESKTOP-8T3IK17\SQLEXPRESS;Initial Catalog=Consultorio2;Integrated Security=True";
            Conexao conexao = new Conexao(DadosDaConexao.SatringDeConexao);
            DALPaciente dal = new DALPaciente(conexao);

            try
            {
                dal.Incluir(paciente);
                MessageBox.Show("Paciente salvo no banco de dados.");
                LimparCampos();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            frmPrincipal carrega = new frmPrincipal();
            carrega.ShowDialog();
        }
        private void LimparCampos()
        {
            txtNome.Text = "";
            txtTelefone.Text = "";
        }
    }
}
