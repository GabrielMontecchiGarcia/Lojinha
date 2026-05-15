using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
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
            if (codigoTextbox.Text.Length == 0)
            {
                MessageBox.Show("Um cliente deve ser selecionado para alteração");
            }
            else
                try
                {
                    ClienteInformation cliente = new ClienteInformation();
                    cliente.Codigo = int.Parse(codigoTextbox.Text);
                    cliente.Nome = nomeTextbox.Text;
                    cliente.Email = emailTextbox.Text;
                    cliente.Telefone = telefoneTextbox.Text;

                    ClientesBLL obj = new ClientesBLL();
                    obj.Alterar(cliente);
                    MessageBox.Show("Cliente alterado com sucesso");
                }
                catch (Exception ex) 
                {
                    MessageBox.Show("Erro " + ex.Message);
                }

        }

        private void excluirButton_Click(object sender, EventArgs e)
        {           
            if (codigoTextbox.Text.Length == 0)
            {
                MessageBox.Show("Um cliente deve ser selecionado para ser deletado");
            }
            else
                try
                {
                    int codigo = Convert.ToInt32(codigoTextbox.Text);
                    
                    ClientesBLL obj = new ClientesBLL();
                    obj.Excluir(codigo);
                    MessageBox.Show("cliente apagado com sucesso");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
