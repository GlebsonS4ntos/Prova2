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
    public partial class Form1 : Form
    {
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
    }
}
