using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Igreja.BD.BDIgrejaDataSetTableAdapters;

namespace Igreja.Controle
{
    class Pessoa
    {
        PESSOATableAdapter BDPessoa;

        public Pessoa()
        {
             BDPessoa = new PESSOATableAdapter();
        }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public int Nrua { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string TelCelular { get; set; }
        public string TelFixo { get; set; }
        public string Email { get; set; }
        public DateTime  DataNascimento { get; set; }
        public int IdCidade { get; set; }
        public bool MembroFrequentador { get; set; }

        public int InserirPessoa()
        {
            try
            {
                BDPessoa.Insert(Nome, Endereco, Nrua, Complemento, Bairro, TelCelular, TelFixo, Email, DataNascimento, IdCidade, MembroFrequentador);
                return 1;
            }
            catch (Exception err)
            {
                System.Windows.Forms.MessageBox.Show(err.Message);
                return 0;
            }
 
        }
    }
}
