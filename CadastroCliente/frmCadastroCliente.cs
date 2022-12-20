using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilitarios;

namespace CadastroCliente
{
    public partial class frmCadastroCliente : Form
    {
        public frmCadastroCliente()
        {
            InitializeComponent();
        }

        private void cpf_text_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void nome_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cpf = cpf_text.Text;

            Utilitarios.MetodoExtensao.ValidarCPF(cpf);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
