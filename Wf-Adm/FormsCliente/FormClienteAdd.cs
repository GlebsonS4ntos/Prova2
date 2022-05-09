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
    public partial class FormClienteAdd : Form
    {
        public FormClienteAdd()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteRepository cr = new();
                cr.AddCliente(new(Int64.Parse(txtCpf.Text), txtNome.Text));
                MessageBox.Show("Cliente Cadastrado com sucesso !!");
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
