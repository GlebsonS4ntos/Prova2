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

namespace WF_Supermercado
{
    public partial class Pedido : Form
    {
        public Pedido()
        {
            InitializeComponent();
        }

        private void Pedido_Load(object sender, EventArgs e)
        {
            for(int i = 1; i <= 10; i++)
            {
                cbxParcelas.Items.Add(i);
            }
            label3.Visible = false;
            cbxParcelas.Visible = false;
            lbxPedido.Enabled = false;

            PedidoRepository pr = new();
            pr.TodosPedidos().ForEach(p => lbxPedido.Items.Add(p));
            
        }

        private void cbxPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxPagamento.SelectedIndex == 1)
            {
                label3.Visible = true;
                cbxParcelas.Visible = true;
            }
            else
            {
                label3.Visible = false;
                cbxParcelas.Visible = false;
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (cbxPagamento.SelectedIndex == 0)
            {
                MessageBox.Show("Realize o Pagamento no Caixa");
            }
            else if (cbxPagamento.SelectedIndex == 1)
            {
                PedidoRepository pr = new();
                Wf_Adm.Services.Pedido p = pr.EncontrarPedido(0);
                double valor = p.ValorCompra / (cbxParcelas.SelectedIndex + 1);
                MessageBox.Show("O valor da compra é de: " + 
                    (cbxParcelas.SelectedIndex+1) + "x de " + valor);
            }
            else if (cbxPagamento.SelectedIndex == 2)
            {
                Random randNum = new Random();
                MessageBox.Show("A chave Pix para Pagamento é: " + randNum.Next());
            }
        }
    }
}
