using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Igreja.BD.BDIgrejaDataSetTableAdapters;
using System.Data;

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

        public List<Pessoa> PesquisarPessoa(string nome)
        {
            Pessoa p;
            List<Pessoa> ListaPessoas = new List<Pessoa>();
            try
            {
                DataTable tbNomes = BDPessoa.PesquisaPessoaPorNome("%" + nome + "%");
                foreach (DataRow Linhas in tbNomes.Rows)
                {
                    p = new Pessoa();
                    p.Nome = Linhas["NOME"].ToString();
                    p.Endereco = Linhas["ENDERECO"].ToString();
                    p.Nrua = (int)Linhas["NRUA"];
                    p.Complemento = Linhas["COMPLEMENTO"].ToString();
                    p.Bairro = Linhas["BAIRRO"].ToString();
                    p.TelCelular = Linhas["TELCELULAR"].ToString();
                    p.TelFixo = Linhas["TELFIXO"].ToString();
                    p.Email = Linhas["EMAIL"].ToString();
                    p.DataNascimento = (DateTime)Linhas["DATANASCIMENTO"];
                    p.IdCidade = (int)Linhas["IDCIDADE"];
                    p.MembroFrequentador = (bool)Linhas["MEBROFREQUENTADOR"];
                    ListaPessoas.Add(p);
                }

                return ListaPessoas;
            }
            catch (Exception err)
            {
                return ListaPessoas;
                System.Windows.Forms.MessageBox.Show(err.Message);
            }
        }

        public DataTable ListaNomes()
        {
            DataTable tb = new DataTable();
            try
            {
                tb = BDPessoa.RetornaListaMembros();
                return tb;
            }
            catch (Exception err)
            {
                return tb;
                System.Windows.Forms.MessageBox.Show(err.Message);
            }
        }
    }
}
