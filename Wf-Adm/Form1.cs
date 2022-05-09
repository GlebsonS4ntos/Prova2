using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wf_Adm.FormsCliente;

namespace Wf_Adm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MenuClienteAdicionar_Click(object sender, EventArgs e)
        {
            FormClienteAdd formClienteAdd = new();
            formClienteAdd.ShowDialog();
        }

        private void MenuClienteVisualizar_Click(object sender, EventArgs e)
        {
            FormClienteVisualizar clienteVisualizar = new();
            clienteVisualizar.ShowDialog();
        }
    }
}
