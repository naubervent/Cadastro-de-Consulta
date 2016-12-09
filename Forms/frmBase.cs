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
    public partial class frmBase : Form
    {
        public enum StatusCadastro
        {
            scInserindo,
            scNavegando,
            scEditando
        }

        private StatusCadastro sStatus;

        public frmBase()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmBase_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void LimpaControles()
        {
            foreach(Control ctr in this.Controls)
            {
                if (ctr is TextBox)
                    (ctr as TextBox).Text = "";

                if (ctr is ComboBox)
                    (ctr as ComboBox).SelectedIndex = -1;

                if (ctr is ListBox)
                    (ctr as ListBox).SelectedIndex = -1;

                if (ctr is RadioButton)
                    (ctr as RadioButton).Checked = false;

                if (ctr is CheckBox)
                    (ctr as CheckBox).Checked = false;

                if(ctr is CheckedListBox)
                {
                    foreach (ListControl item in (ctr as CheckedListBox).Items)
                        item.SelectedIndex = -1;
                }
            }
        }

        public virtual bool Salvar()
        {
            return false;
        }

        public virtual bool Excluir()
        {
            return false;
        }

        public virtual bool Localizar()
        {
            return false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(Salvar())
            {
                sStatus = StatusCadastro.scNavegando;
                LimpaControles();
                MessageBox.Show("Registro salvo com sucesso.", "Avido do sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("O registro não foi salvo, verifique os erros", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(Excluir())
            {
                LimpaControles();
                MessageBox.Show("Registro excluído com sucesso.", "Avido do sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Registro não foi excluído, verifique os erros", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            sStatus = StatusCadastro.scInserindo;
            LimpaControles();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            if(Localizar())
            {
                sStatus = StatusCadastro.scEditando;
                HabilitaDesabilitaControles(true);
                CarregaValores();
            }
        }

        private void CarregaValores()
        {
            
        }

        private void HabilitaDesabilitaControles(bool bValue)
        {
            foreach(Control ctr in this.Controls)
            {
                if (ctr is ToolStrip)
                    continue;
                ctr.Enabled = bValue;
            }

            btnNovo.Enabled = (sStatus == StatusCadastro.scNavegando);

            btnSalvar.Enabled = (sStatus == StatusCadastro.scNavegando ||
                                 sStatus == StatusCadastro.scInserindo);

            btnExcluir.Enabled = (sStatus == StatusCadastro.scEditando);

            btnLocalizar.Enabled = (sStatus == StatusCadastro.scNavegando);

            btnFechar.Enabled = true;
        }
    }
}
