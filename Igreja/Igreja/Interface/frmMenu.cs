using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Igreja.Interface;
using Igreja.BD.BDIgrejaDataSetTableAdapters;

namespace Igreja
{
    public partial class frmMenu : frmModelo
    {
        
        public frmMenu()
        {
            InitializeComponent();
            CIDADETableAdapter cid = new CIDADETableAdapter();
            cid.Insert("BETIM", "MG");
            cid.Insert("BELO HORIZONTE", "MG");
            cid.Insert("CONTAGEM", "MG");



        }

        private void cadastrarPessoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente cli = new frmCliente(); 
            cli.MdiParent = this;
            cli.Show();
            Painel.SendToBack();
        }
    }
}

