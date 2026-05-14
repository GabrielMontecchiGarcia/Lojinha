using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lojinha.BLL;
using Lojinha.Modelos;

namespace Lojinha.Formularios
{
    public partial class ClientesForms : Form
    {
        public ClientesForms()
        {
            InitializeComponent();
        }

        private void incluirButton_Click(object sender, EventArgs e)
        {
            ClienteInformation cliente = new ClienteInformation();
            cliente.Nome = nomeTextbox.Text;
            cliente.Email = emailTextbox.Text;
            cliente.Telefone = telefoneTextbox.Text;

            ClientesBLL obj = new ClientesBLL();
            obj.Incluir(cliente);
            MessageBox.Show("O cliente foi incluido com sucesso");
            codigoTextbox.Text = Convert.ToString(cliente.Codigo);
        }

        private void alterarButton_Click(object sender, EventArgs e)
        {
            ClienteInformation
        }
    }
}
