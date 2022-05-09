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

namespace Wf_Adm.FormsCliente
{
    public partial class FormClienteDelete : Form
    {
        public FormClienteDelete()
        {
            InitializeComponent();
        }

        private void FormClienteDelete_Load(object sender, EventArgs e)
        {
            ClienteRepository cr = new();
            cr.ClientesCadastrados();
            cr.TodosClientes().ForEach(c => lbxDeletar.Items.Add(c));
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            ClienteRepository cr = new();
            cr.Deletar(cr.EncontrarCliente(lbxDeletar.SelectedIndex));
            MessageBox.Show("Cliente Deletado com sucesso !!");
            lbxDeletar.Items.Clear();
            cr.TodosClientes().ForEach(c => lbxDeletar.Items.Add(c));
        }
    }
}
