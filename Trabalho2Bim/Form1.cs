using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho2Bim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        List<NF> listNf = new List<NF>();

        private void btnGravar_Click(object sender, EventArgs e)
        {
            NF nf = new NF();

            nf.nomeProd = txtNomeProd.Text;
            nf.numNf = Convert.ToInt32(txtNumNota.Text);
            nf.precoUnit = Convert.ToDouble(txtPreco.Text);
            nf.qntVendida = Convert.ToInt32(txtQuantidade.Text);
            nf.cliente = txtCliente.Text;
            nf.vendedor = txtVendedor.Text;
            nf.regiao = txtRegiao.Text;
            nf.totalItem += nf.precoUnit;
            txtTotal.Text = nf.totalItem.ToString();
            nf.fornecedor = txtFornecedor.Text;

            listNf.Add(nf);
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dgNf.DataSource = null;
            dgNf.DataSource = listNf;
        }
    }
}
