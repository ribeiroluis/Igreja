using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Igreja.Controle;

namespace Igreja.Interface
{
    public partial class frmCliente : frmModelo
    {
        Pessoa p;
        public bool status;

        public frmCliente()
        {
            InitializeComponent();
            status = true;            
            
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDIgrejaDataSet.CIDADE'. Você pode movê-la ou removê-la conforme necessário.
            this.cIDADETableAdapter.Fill(this.bDIgrejaDataSet.CIDADE);

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            p = new Pessoa();
            p.Nome = txNome.Text.ToUpper();
            p.Bairro = txBairro.Text.ToUpper();
            p.Complemento = txComplemento.Text.ToUpper();
            p.DataNascimento = DateTime.Parse(txDataNascimento.Text);
            p.Email = txEmail.Text;
            p.Endereco = txLogradouro.Text.ToUpper();
            p.IdCidade = (int)cbCidade.SelectedValue;
            p.Nrua = int.Parse(txNumero.Text);
            p.TelCelular = txTelCel.Text;
            p.TelFixo = txTelFixo.Text;           

            if (rbtnNao.Checked)
                p.MembroFrequentador = false;
            else
                p.MembroFrequentador = true;

            int result = p.InserirPessoa();

            if (result == 1)
                MessageBox.Show("Inserido com sucesso");
            else
                MessageBox.Show("Erro ao gravar.");


        }

    }
}
