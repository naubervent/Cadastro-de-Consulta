namespace Consultas2
{
    partial class frmConsulta
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
            System.Windows.Forms.Label idConsultaLabel;
            System.Windows.Forms.Label nomeMedicoLabel;
            System.Windows.Forms.Label nomePacienteLabel;
            System.Windows.Forms.Label dataConsultaLabel;
            System.Windows.Forms.Label horarioConsultaLabel;
            System.Windows.Forms.Label observacoesLabel;
            this.idConsultaLabel1 = new System.Windows.Forms.Label();
            this.consultaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultorio2DataSet = new Consultas2.Consultorio2DataSet();
            this.cmbNomeMedico = new System.Windows.Forms.ComboBox();
            this.medicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cmbNomePaciente = new System.Windows.Forms.ComboBox();
            this.pacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pacienteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hrConsulta = new System.Windows.Forms.DateTimePicker();
            this.txtObservacoes = new System.Windows.Forms.TextBox();
            this.consultaTableAdapter = new Consultas2.Consultorio2DataSetTableAdapters.ConsultaTableAdapter();
            this.tableAdapterManager = new Consultas2.Consultorio2DataSetTableAdapters.TableAdapterManager();
            this.medicoTableAdapter = new Consultas2.Consultorio2DataSetTableAdapters.MedicoTableAdapter();
            this.pacienteTableAdapter = new Consultas2.Consultorio2DataSetTableAdapters.PacienteTableAdapter();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.dtConsulta = new System.Windows.Forms.DateTimePicker();
            idConsultaLabel = new System.Windows.Forms.Label();
            nomeMedicoLabel = new System.Windows.Forms.Label();
            nomePacienteLabel = new System.Windows.Forms.Label();
            dataConsultaLabel = new System.Windows.Forms.Label();
            horarioConsultaLabel = new System.Windows.Forms.Label();
            observacoesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.consultaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultorio2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // idConsultaLabel
            // 
            idConsultaLabel.AutoSize = true;
            idConsultaLabel.Location = new System.Drawing.Point(203, 97);
            idConsultaLabel.Name = "idConsultaLabel";
            idConsultaLabel.Size = new System.Drawing.Size(62, 13);
            idConsultaLabel.TabIndex = 0;
            idConsultaLabel.Text = "id Consulta:";
            // 
            // nomeMedicoLabel
            // 
            nomeMedicoLabel.AutoSize = true;
            nomeMedicoLabel.Location = new System.Drawing.Point(203, 126);
            nomeMedicoLabel.Name = "nomeMedicoLabel";
            nomeMedicoLabel.Size = new System.Drawing.Size(74, 13);
            nomeMedicoLabel.TabIndex = 2;
            nomeMedicoLabel.Text = "nome Medico:";
            // 
            // nomePacienteLabel
            // 
            nomePacienteLabel.AutoSize = true;
            nomePacienteLabel.Location = new System.Drawing.Point(203, 153);
            nomePacienteLabel.Name = "nomePacienteLabel";
            nomePacienteLabel.Size = new System.Drawing.Size(81, 13);
            nomePacienteLabel.TabIndex = 4;
            nomePacienteLabel.Text = "nome Paciente:";
            // 
            // dataConsultaLabel
            // 
            dataConsultaLabel.AutoSize = true;
            dataConsultaLabel.Location = new System.Drawing.Point(203, 181);
            dataConsultaLabel.Name = "dataConsultaLabel";
            dataConsultaLabel.Size = new System.Drawing.Size(75, 13);
            dataConsultaLabel.TabIndex = 6;
            dataConsultaLabel.Text = "data Consulta:";
            // 
            // horarioConsultaLabel
            // 
            horarioConsultaLabel.AutoSize = true;
            horarioConsultaLabel.Location = new System.Drawing.Point(203, 207);
            horarioConsultaLabel.Name = "horarioConsultaLabel";
            horarioConsultaLabel.Size = new System.Drawing.Size(86, 13);
            horarioConsultaLabel.TabIndex = 8;
            horarioConsultaLabel.Text = "horario Consulta:";
            // 
            // observacoesLabel
            // 
            observacoesLabel.AutoSize = true;
            observacoesLabel.Location = new System.Drawing.Point(203, 232);
            observacoesLabel.Name = "observacoesLabel";
            observacoesLabel.Size = new System.Drawing.Size(71, 13);
            observacoesLabel.TabIndex = 10;
            observacoesLabel.Text = "observacoes:";
            // 
            // idConsultaLabel1
            // 
            this.idConsultaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultaBindingSource, "idConsulta", true));
            this.idConsultaLabel1.Location = new System.Drawing.Point(295, 97);
            this.idConsultaLabel1.Name = "idConsultaLabel1";
            this.idConsultaLabel1.Size = new System.Drawing.Size(200, 23);
            this.idConsultaLabel1.TabIndex = 1;
            this.idConsultaLabel1.Text = "label1";
            // 
            // consultaBindingSource
            // 
            this.consultaBindingSource.DataMember = "Consulta";
            this.consultaBindingSource.DataSource = this.consultorio2DataSet;
            // 
            // consultorio2DataSet
            // 
            this.consultorio2DataSet.DataSetName = "Consultorio2DataSet";
            this.consultorio2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbNomeMedico
            // 
            this.cmbNomeMedico.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.medicoBindingSource, "nomeMedico", true));
            this.cmbNomeMedico.DataSource = this.medicoBindingSource1;
            this.cmbNomeMedico.DisplayMember = "nomeMedico";
            this.cmbNomeMedico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNomeMedico.FormattingEnabled = true;
            this.cmbNomeMedico.Location = new System.Drawing.Point(295, 123);
            this.cmbNomeMedico.Name = "cmbNomeMedico";
            this.cmbNomeMedico.Size = new System.Drawing.Size(200, 21);
            this.cmbNomeMedico.TabIndex = 3;
            this.cmbNomeMedico.ValueMember = "idMedico";
            // 
            // medicoBindingSource
            // 
            this.medicoBindingSource.DataMember = "Medico";
            this.medicoBindingSource.DataSource = this.consultorio2DataSet;
            // 
            // medicoBindingSource1
            // 
            this.medicoBindingSource1.DataMember = "Medico";
            this.medicoBindingSource1.DataSource = this.consultorio2DataSet;
            // 
            // cmbNomePaciente
            // 
            this.cmbNomePaciente.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pacienteBindingSource, "nomePaciente", true));
            this.cmbNomePaciente.DataSource = this.pacienteBindingSource1;
            this.cmbNomePaciente.DisplayMember = "nomePaciente";
            this.cmbNomePaciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNomePaciente.FormattingEnabled = true;
            this.cmbNomePaciente.Location = new System.Drawing.Point(295, 150);
            this.cmbNomePaciente.Name = "cmbNomePaciente";
            this.cmbNomePaciente.Size = new System.Drawing.Size(200, 21);
            this.cmbNomePaciente.TabIndex = 5;
            this.cmbNomePaciente.ValueMember = "idPaciente";
            // 
            // pacienteBindingSource
            // 
            this.pacienteBindingSource.DataMember = "Paciente";
            this.pacienteBindingSource.DataSource = this.consultorio2DataSet;
            // 
            // pacienteBindingSource1
            // 
            this.pacienteBindingSource1.DataMember = "Paciente";
            this.pacienteBindingSource1.DataSource = this.consultorio2DataSet;
            // 
            // hrConsulta
            // 
            this.hrConsulta.CustomFormat = "HH:mm";
            this.hrConsulta.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.consultaBindingSource, "horarioConsulta", true));
            this.hrConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.hrConsulta.Location = new System.Drawing.Point(295, 203);
            this.hrConsulta.Name = "hrConsulta";
            this.hrConsulta.Size = new System.Drawing.Size(112, 20);
            this.hrConsulta.TabIndex = 9;
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultaBindingSource, "observacoes", true));
            this.txtObservacoes.Location = new System.Drawing.Point(295, 229);
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.Size = new System.Drawing.Size(200, 20);
            this.txtObservacoes.TabIndex = 11;
            // 
            // consultaTableAdapter
            // 
            this.consultaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ConsultaTableAdapter = this.consultaTableAdapter;
            this.tableAdapterManager.MedicoTableAdapter = null;
            this.tableAdapterManager.PacienteTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Consultas2.Consultorio2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // medicoTableAdapter
            // 
            this.medicoTableAdapter.ClearBeforeFill = true;
            // 
            // pacienteTableAdapter
            // 
            this.pacienteTableAdapter.ClearBeforeFill = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(206, 287);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 12;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(314, 287);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 13;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(420, 287);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 14;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // dtConsulta
            // 
            this.dtConsulta.CustomFormat = "dd/MM/yyy";
            this.dtConsulta.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.consultaBindingSource, "dataConsulta", true));
            this.dtConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtConsulta.Location = new System.Drawing.Point(295, 181);
            this.dtConsulta.Name = "dtConsulta";
            this.dtConsulta.Size = new System.Drawing.Size(112, 20);
            this.dtConsulta.TabIndex = 7;
            // 
            // frmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(idConsultaLabel);
            this.Controls.Add(this.idConsultaLabel1);
            this.Controls.Add(nomeMedicoLabel);
            this.Controls.Add(this.cmbNomeMedico);
            this.Controls.Add(nomePacienteLabel);
            this.Controls.Add(this.cmbNomePaciente);
            this.Controls.Add(dataConsultaLabel);
            this.Controls.Add(this.dtConsulta);
            this.Controls.Add(horarioConsultaLabel);
            this.Controls.Add(this.hrConsulta);
            this.Controls.Add(observacoesLabel);
            this.Controls.Add(this.txtObservacoes);
            this.Name = "frmConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Consulta";
            this.Load += new System.EventHandler(this.frmConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.consultaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultorio2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Consultorio2DataSet consultorio2DataSet;
        private System.Windows.Forms.BindingSource consultaBindingSource;
        private Consultorio2DataSetTableAdapters.ConsultaTableAdapter consultaTableAdapter;
        private Consultorio2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label idConsultaLabel1;
        private System.Windows.Forms.ComboBox cmbNomeMedico;
        private System.Windows.Forms.ComboBox cmbNomePaciente;
        private System.Windows.Forms.DateTimePicker hrConsulta;
        private System.Windows.Forms.TextBox txtObservacoes;
        private System.Windows.Forms.BindingSource medicoBindingSource;
        private Consultorio2DataSetTableAdapters.MedicoTableAdapter medicoTableAdapter;
        private System.Windows.Forms.BindingSource pacienteBindingSource;
        private Consultorio2DataSetTableAdapters.PacienteTableAdapter pacienteTableAdapter;
        private System.Windows.Forms.BindingSource medicoBindingSource1;
        private System.Windows.Forms.BindingSource pacienteBindingSource1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DateTimePicker dtConsulta;
    }
}