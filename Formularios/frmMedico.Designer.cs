namespace Consultas2
{
    partial class frmMedico
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idMedicoLabel;
            System.Windows.Forms.Label nomeMedicoLabel;
            System.Windows.Forms.Label crmMedicoLabel;
            this.consultorio2DataSet = new Consultas2.Consultorio2DataSet();
            this.medicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicoTableAdapter = new Consultas2.Consultorio2DataSetTableAdapters.MedicoTableAdapter();
            this.tableAdapterManager = new Consultas2.Consultorio2DataSetTableAdapters.TableAdapterManager();
            this.idMedicoTextBox = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCRM = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            idMedicoLabel = new System.Windows.Forms.Label();
            nomeMedicoLabel = new System.Windows.Forms.Label();
            crmMedicoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.consultorio2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idMedicoLabel
            // 
            idMedicoLabel.AutoSize = true;
            idMedicoLabel.Location = new System.Drawing.Point(242, 153);
            idMedicoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            idMedicoLabel.Name = "idMedicoLabel";
            idMedicoLabel.Size = new System.Drawing.Size(56, 13);
            idMedicoLabel.TabIndex = 1;
            idMedicoLabel.Text = "id Medico:";
            // 
            // nomeMedicoLabel
            // 
            nomeMedicoLabel.AutoSize = true;
            nomeMedicoLabel.Location = new System.Drawing.Point(242, 176);
            nomeMedicoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nomeMedicoLabel.Name = "nomeMedicoLabel";
            nomeMedicoLabel.Size = new System.Drawing.Size(45, 13);
            nomeMedicoLabel.TabIndex = 3;
            nomeMedicoLabel.Text = "Medico:";
            // 
            // crmMedicoLabel
            // 
            crmMedicoLabel.AutoSize = true;
            crmMedicoLabel.Location = new System.Drawing.Point(242, 199);
            crmMedicoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            crmMedicoLabel.Name = "crmMedicoLabel";
            crmMedicoLabel.Size = new System.Drawing.Size(72, 13);
            crmMedicoLabel.TabIndex = 5;
            crmMedicoLabel.Text = "CRM Medico:";
            // 
            // consultorio2DataSet
            // 
            this.consultorio2DataSet.DataSetName = "Consultorio2DataSet";
            this.consultorio2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medicoBindingSource
            // 
            this.medicoBindingSource.DataMember = "Medico";
            this.medicoBindingSource.DataSource = this.consultorio2DataSet;
            // 
            // medicoTableAdapter
            // 
            this.medicoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ConsultaTableAdapter = null;
            this.tableAdapterManager.MedicoTableAdapter = this.medicoTableAdapter;
            this.tableAdapterManager.PacienteTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Consultas2.Consultorio2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // idMedicoTextBox
            // 
            this.idMedicoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicoBindingSource, "idMedico", true));
            this.idMedicoTextBox.Location = new System.Drawing.Point(316, 151);
            this.idMedicoTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.idMedicoTextBox.Name = "idMedicoTextBox";
            this.idMedicoTextBox.ReadOnly = true;
            this.idMedicoTextBox.Size = new System.Drawing.Size(76, 20);
            this.idMedicoTextBox.TabIndex = 2;
            // 
            // txtNome
            // 
            this.txtNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicoBindingSource, "nomeMedico", true));
            this.txtNome.Location = new System.Drawing.Point(316, 173);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(76, 20);
            this.txtNome.TabIndex = 4;
            // 
            // txtCRM
            // 
            this.txtCRM.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicoBindingSource, "crmMedico", true));
            this.txtCRM.Location = new System.Drawing.Point(316, 196);
            this.txtCRM.Margin = new System.Windows.Forms.Padding(2);
            this.txtCRM.Name = "txtCRM";
            this.txtCRM.Size = new System.Drawing.Size(76, 20);
            this.txtCRM.TabIndex = 6;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(222, 256);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(317, 256);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(418, 256);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(idMedicoLabel);
            this.Controls.Add(this.idMedicoTextBox);
            this.Controls.Add(nomeMedicoLabel);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(crmMedicoLabel);
            this.Controls.Add(this.txtCRM);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMedico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMedico";
            this.Load += new System.EventHandler(this.frmMedico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.consultorio2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Consultorio2DataSet consultorio2DataSet;
        private System.Windows.Forms.BindingSource medicoBindingSource;
        private Consultorio2DataSetTableAdapters.MedicoTableAdapter medicoTableAdapter;
        private Consultorio2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox idMedicoTextBox;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCRM;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
    }
}