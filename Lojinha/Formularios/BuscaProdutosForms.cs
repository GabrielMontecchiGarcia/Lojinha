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

namespace Lojinha.Formularios
{
    public partial class BuscaProdutosForms : Form
    {
        public BuscaProdutosForms()
        {
            InitializeComponent();
        }

        private void BuscaProdutosForms_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
            txtbuscanomeproduto.Focus();
        }
        public void AtualizarGrid()
        {
            
        }

        private void btnfiltraproduto_Click(object sender, EventArgs e)
        {
            ClientesBLL obj = new ClientesBLL();
            produtosdataGridView.DataSource = obj.Listagem(txtfiltroprodutos.Text);

            //atualiza os abjetos textbox
            try
            {
                txtbuscacodigoproduto.Text = produtosdataGridView[0, produtosdataGridView.CurrentRow.Index].Value.ToString();
                txtbuscanomeproduto.Text = produtosdataGridView[1, produtosdataGridView.CurrentRow.Index].Value.ToString();
                txtbuscaprecoproduto.Text = produtosdataGridView[2, produtosdataGridView.CurrentRow.Index].Value.ToString();
                txtbuscaestoqueproduto.Text = produtosdataGridView[3, produtosdataGridView.CurrentRow.Index].Value.ToString();

            }
            catch (Exception)
            {
                txtbuscacodigoproduto.Text = "";
                txtbuscanomeproduto.Text = "";
                txtbuscaprecoproduto.Text = "";
                txtbuscaestoqueproduto.Text = "";
            }
        }
    }
}
