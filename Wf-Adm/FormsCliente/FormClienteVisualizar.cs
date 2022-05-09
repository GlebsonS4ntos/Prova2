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
    public partial class FormClienteVisualizar : Form
    {
        public FormClienteVisualizar()
        {
            InitializeComponent();
        }

        private void FormClienteVisualizar_Load(object sender, EventArgs e)
        {
            ClienteRepository cr = new();
            cr.TodosClientes().ForEach(c => lbxClientes.Items.Add(c));
        }
    }
}
