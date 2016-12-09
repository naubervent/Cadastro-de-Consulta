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

    public partial class frmMedico : Form
    {
        public frmMedico()
        {
            InitializeComponent();
        }

        private void medicoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.medicoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.consultorio2DataSet);

        }

        private void frmMedico_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'consultorio2DataSet.Medico' table. You can move, or remove it, as needed.
            this.medicoTableAdapter.Fill(this.consultorio2DataSet.Medico);
            LimparCampos();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Medico medico = new Medico();
            medico.Nome = txtNome.Text;
            medico.Crm = txtCRM.Text;

            //String strConexao = @"Data Source=DESKTOP-8T3IK17\SQLEXPRESS;Initial Catalog=Consultorio2;Integrated Security=True";
            Conexao conexao = new Conexao(DadosDaConexao.StringDeConexao);
            DALMedico dal = new DALMedico(conexao);

            try
            {
                dal.Incluir(medico);
                MessageBox.Show("Medico salvo no banco de dados.");
                LimparCampos();
                
            }
            catch(Exception ex)
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
            txtCRM.Text = "";
        }
    }
}
