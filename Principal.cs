using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crud_cliente_e_fornecedor
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void cadastroClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_cliente c = new frm_cliente();
            c.Show();   
        }
       

    }
}
