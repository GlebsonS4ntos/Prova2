using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wf_Adm.Repository;
using Wf_Adm.Services;
using System.Threading;

namespace WF_Supermercado
{
    public partial class Form1 : Form
    {
        Thread t1;

        public Form1()
        {
            InitializeComponent();
        }

        private void CbxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxCliente.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CarregarForm cf = new();
            cf.CarregarFormClientes().ForEach(c => cbxCliente.Items.Add(c));
            cf.CarregarFormProdutos().ForEach(p => cbxProduto.Items.Add(p));
        }

        private void cbxProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxQuantidade.Items.Clear();
            CarregarForm cf = new();
            int i = cf.CarregarQuantidadeProduto(cbxProduto.SelectedIndex);
            for(int j = 1; j <= i; j++)
            {
                cbxQuantidade.Items.Add(j);
            }
        }

        private void btnAdicionarItem_Click(object sender, EventArgs e)
        {
            try
            {
                CarregarForm cf = new();
                ItemCompra i = cf.CriacaoItem(cbxProduto.SelectedIndex, cbxQuantidade.SelectedIndex + 1);
                lbxPedido.Items.Add(i);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Selecione todos os Campos");
            }
        }

        private void btnEnviarPedido_Click(object sender, EventArgs e)
        {
            CarregarForm cf = new();
            List<ItemCompra> lista = new();
            foreach (ItemCompra i in lbxPedido.Items)
            {
                lista.Add(i);
            }
            cf.CriarPedido(cbxCliente.SelectedIndex, lista);
            this.Close();
            t1 = new(AbrirJanela);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void AbrirJanela(object obj)
        {
            Application.Run(new Pedido());
        }
    }
}
