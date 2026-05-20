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
    public partial class BuscaClientesForms : Form
    {
        public BuscaClientesForms()
        {
            InitializeComponent();
        }
        public void AtualizarGrid()
        {
            var obj = new ClientesBLL();
            ClientesdataGridView.DataSource = obj.Listagem(filtroTextBox.Text);

            // If there are rows, make the first cell the current cell so CurrentRow is not null
            if (ClientesdataGridView.Rows.Count > 0)
            {
                ClientesdataGridView.CurrentCell = ClientesdataGridView[0, 0];
                var row = ClientesdataGridView.CurrentRow;
                codigoTextBox.Text = Convert.ToString(row.Cells[0].Value ?? "");
                nomeTextBox.Text = Convert.ToString(row.Cells[1].Value ?? "");
                emailTextBox.Text = Convert.ToString(row.Cells[2].Value ?? "");
                telefoneTextBox.Text = Convert.ToString(row.Cells[3].Value ?? "");
            }
            else
            {
                codigoTextBox.Text = nomeTextBox.Text = emailTextBox.Text = telefoneTextBox.Text = "";
            }

        }


        private void BuscaClientesForms_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
            nomeTextBox.Focus();
        }

        private void FiltrarButton_Click(object sender, EventArgs e)
        {
            //Comunicação com a camada BLL
            ClientesBLL obj = new ClientesBLL();
            ClientesdataGridView.DataSource = obj.Listagem(filtroTextBox.Text);

            //atualiza os abjetos textbox
            try
            {
                codigoTextBox.Text = ClientesdataGridView[0, ClientesdataGridView.CurrentRow.Index].Value.ToString();
                nomeTextBox.Text = ClientesdataGridView[1, ClientesdataGridView.CurrentRow.Index].Value.ToString();
                emailTextBox.Text = ClientesdataGridView[2, ClientesdataGridView.CurrentRow.Index].Value.ToString();
                telefoneTextBox.Text = ClientesdataGridView[3, ClientesdataGridView.CurrentRow.Index].Value.ToString();
            }
            catch (Exception)
            {
                codigoTextBox.Text = "";
                nomeTextBox.Text = "";
                emailTextBox.Text = "";
                telefoneTextBox.Text = "";
            }
        }

        private void IncluirButton_Click(object sender, EventArgs e)
        {
            ClienteInformation cliente = new ClienteInformation();
            cliente.Nome = nomeTextBox.Text;
            cliente.Email = emailTextBox.Text;
            cliente.Telefone = telefoneTextBox.Text;

            ClientesBLL obj = new ClientesBLL();
            obj.Incluir(cliente);
            MessageBox.Show("O cliente foi incluido com sucesso");
            codigoTextBox.Text = Convert.ToString(cliente.Codigo);
        }
    }
}
