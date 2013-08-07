namespace Igreja.Interface
{
    partial class frmCliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.txNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.txLogradouro = new System.Windows.Forms.TextBox();
            this.txNumero = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txComplemento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txBairro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbCidade = new System.Windows.Forms.ComboBox();
            this.cIDADEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDIgrejaDataSet = new Igreja.BD.BDIgrejaDataSet();
            this.cIDADETableAdapter = new Igreja.BD.BDIgrejaDataSetTableAdapters.CIDADETableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnNao = new System.Windows.Forms.RadioButton();
            this.rbtnSim = new System.Windows.Forms.RadioButton();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.txEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txTelFixo = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txTelCel = new System.Windows.Forms.MaskedTextBox();
            this.Dicas = new System.Windows.Forms.ToolTip(this.components);
            this.dtgPessoas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.cIDADEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDIgrejaDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPessoas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // txNome
            // 
            this.txNome.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNome.Location = new System.Drawing.Point(15, 58);
            this.txNome.Name = "txNome";
            this.txNome.Size = new System.Drawing.Size(587, 26);
            this.txNome.TabIndex = 1;
            this.Dicas.SetToolTip(this.txNome, "Digite o nome e pressione enter");
            this.txNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txNome_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Logradouro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(605, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Data Nascimento";
            // 
            // txDataNascimento
            // 
            this.txDataNascimento.Enabled = false;
            this.txDataNascimento.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txDataNascimento.Location = new System.Drawing.Point(608, 58);
            this.txDataNascimento.Mask = "00/00/0000";
            this.txDataNascimento.Name = "txDataNascimento";
            this.txDataNascimento.Size = new System.Drawing.Size(117, 26);
            this.txDataNascimento.TabIndex = 2;
            this.Dicas.SetToolTip(this.txDataNascimento, "Digite a data e pressione enter");
            this.txDataNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // txLogradouro
            // 
            this.txLogradouro.Enabled = false;
            this.txLogradouro.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txLogradouro.Location = new System.Drawing.Point(15, 119);
            this.txLogradouro.Name = "txLogradouro";
            this.txLogradouro.Size = new System.Drawing.Size(494, 26);
            this.txLogradouro.TabIndex = 3;
            // 
            // txNumero
            // 
            this.txNumero.Enabled = false;
            this.txNumero.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNumero.Location = new System.Drawing.Point(515, 119);
            this.txNumero.Name = "txNumero";
            this.txNumero.Size = new System.Drawing.Size(87, 26);
            this.txNumero.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(512, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Número";
            // 
            // txComplemento
            // 
            this.txComplemento.Enabled = false;
            this.txComplemento.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txComplemento.Location = new System.Drawing.Point(608, 119);
            this.txComplemento.Name = "txComplemento";
            this.txComplemento.Size = new System.Drawing.Size(117, 26);
            this.txComplemento.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(637, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Complemento";
            // 
            // txBairro
            // 
            this.txBairro.Enabled = false;
            this.txBairro.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBairro.Location = new System.Drawing.Point(15, 176);
            this.txBairro.Name = "txBairro";
            this.txBairro.Size = new System.Drawing.Size(290, 26);
            this.txBairro.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Bairro";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(327, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Cidade";
            // 
            // cbCidade
            // 
            this.cbCidade.DataSource = this.cIDADEBindingSource;
            this.cbCidade.DisplayMember = "NOME";
            this.cbCidade.Enabled = false;
            this.cbCidade.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCidade.FormattingEnabled = true;
            this.cbCidade.Location = new System.Drawing.Point(330, 176);
            this.cbCidade.Name = "cbCidade";
            this.cbCidade.Size = new System.Drawing.Size(217, 26);
            this.cbCidade.TabIndex = 7;
            this.cbCidade.ValueMember = "IDCIDADE";
            // 
            // cIDADEBindingSource
            // 
            this.cIDADEBindingSource.DataMember = "CIDADE";
            this.cIDADEBindingSource.DataSource = this.bDIgrejaDataSet;
            // 
            // bDIgrejaDataSet
            // 
            this.bDIgrejaDataSet.DataSetName = "BDIgrejaDataSet";
            this.bDIgrejaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cIDADETableAdapter
            // 
            this.cIDADETableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnNao);
            this.groupBox1.Controls.Add(this.rbtnSim);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(553, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(172, 45);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Membro";
            // 
            // rbtnNao
            // 
            this.rbtnNao.AutoSize = true;
            this.rbtnNao.Location = new System.Drawing.Point(93, 19);
            this.rbtnNao.Name = "rbtnNao";
            this.rbtnNao.Size = new System.Drawing.Size(46, 20);
            this.rbtnNao.TabIndex = 0;
            this.rbtnNao.TabStop = true;
            this.rbtnNao.Text = "Não";
            this.rbtnNao.UseVisualStyleBackColor = true;
            // 
            // rbtnSim
            // 
            this.rbtnSim.AutoSize = true;
            this.rbtnSim.Location = new System.Drawing.Point(20, 19);
            this.rbtnSim.Name = "rbtnSim";
            this.rbtnSim.Size = new System.Drawing.Size(43, 20);
            this.rbtnSim.TabIndex = 0;
            this.rbtnSim.TabStop = true;
            this.rbtnSim.Text = "Sim";
            this.rbtnSim.UseVisualStyleBackColor = true;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Enabled = false;
            this.btnIncluir.Image = global::Igreja.Properties.Resources.Button_Add_icon1;
            this.btnIncluir.Location = new System.Drawing.Point(608, 223);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(47, 39);
            this.btnIncluir.TabIndex = 12;
            this.btnIncluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIncluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // txEmail
            // 
            this.txEmail.Enabled = false;
            this.txEmail.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txEmail.Location = new System.Drawing.Point(15, 236);
            this.txEmail.Name = "txEmail";
            this.txEmail.Size = new System.Drawing.Size(290, 26);
            this.txEmail.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(308, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Telefone Fixo";
            // 
            // txTelFixo
            // 
            this.txTelFixo.Enabled = false;
            this.txTelFixo.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txTelFixo.Location = new System.Drawing.Point(311, 236);
            this.txTelFixo.Mask = "(99) 0000-0000";
            this.txTelFixo.Name = "txTelFixo";
            this.txTelFixo.Size = new System.Drawing.Size(117, 26);
            this.txTelFixo.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(438, 217);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Telefone Celular";
            // 
            // txTelCel
            // 
            this.txTelCel.Enabled = false;
            this.txTelCel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txTelCel.Location = new System.Drawing.Point(441, 236);
            this.txTelCel.Mask = "(99) 0000-0000";
            this.txTelCel.Name = "txTelCel";
            this.txTelCel.Size = new System.Drawing.Size(117, 26);
            this.txTelCel.TabIndex = 11;
            // 
            // Dicas
            // 
            this.Dicas.AutomaticDelay = 250;
            this.Dicas.BackColor = System.Drawing.Color.Yellow;
            // 
            // dtgPessoas
            // 
            this.dtgPessoas.AllowUserToAddRows = false;
            this.dtgPessoas.AllowUserToDeleteRows = false;
            this.dtgPessoas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgPessoas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPessoas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgPessoas.Location = new System.Drawing.Point(0, 285);
            this.dtgPessoas.Name = "dtgPessoas";
            this.dtgPessoas.ReadOnly = true;
            this.dtgPessoas.Size = new System.Drawing.Size(800, 315);
            this.dtgPessoas.TabIndex = 13;
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.ControlBox = false;
            this.Controls.Add(this.dtgPessoas);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbCidade);
            this.Controls.Add(this.txTelCel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txTelFixo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txDataNascimento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txEmail);
            this.Controls.Add(this.txBairro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txComplemento);
            this.Controls.Add(this.txNumero);
            this.Controls.Add(this.txLogradouro);
            this.Controls.Add(this.txNome);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCliente";
            this.Text = "";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cIDADEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDIgrejaDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPessoas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txDataNascimento;
        private System.Windows.Forms.TextBox txLogradouro;
        private System.Windows.Forms.TextBox txNumero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txComplemento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txBairro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbCidade;
        private BD.BDIgrejaDataSet bDIgrejaDataSet;
        private System.Windows.Forms.BindingSource cIDADEBindingSource;
        private BD.BDIgrejaDataSetTableAdapters.CIDADETableAdapter cIDADETableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnNao;
        private System.Windows.Forms.RadioButton rbtnSim;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.TextBox txEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox txTelFixo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox txTelCel;
        private System.Windows.Forms.ToolTip Dicas;
        private System.Windows.Forms.DataGridView dtgPessoas;


    }
}