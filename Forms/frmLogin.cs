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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void usuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.consultorio2DataSet);

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'consultorio2DataSet.Usuario' table. You can move, or remove it, as needed.
            this.usuarioTableAdapter.Fill(this.consultorio2DataSet.Usuario);

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            usuarioTextBox.Text = "";
            senhaTextBox.Text = "";
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            DataTableReader read = new DataTableReader(consultorio2DataSet.Usuario);
            bool logado = false;
            if (String.Compare(usuarioTextBox.Text, "") != 0 && (String.Compare(senhaTextBox.Text, "") != 0))
            {
                while (read.Read())
                {
                    if (String.Compare(usuarioTextBox.Text, read.GetString(0)) == 0 && (String.Compare(senhaTextBox.Text, read.GetString(1)) == 0))
                        logado = true;
                    break;
                }
            }
            if(logado)
            {
                frmPrincipal principal = new frmPrincipal();
                principal.ShowDialog();
            }
            else
            {
                MessageBox.Show("Login ou Senha incorretos.");
            }
        }
    }
}
