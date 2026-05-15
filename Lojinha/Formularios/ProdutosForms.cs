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
    public partial class ProdutosForms : Form
    {
        public ProdutosForms()
        {
            InitializeComponent();
        }

        private void IncluirProdutoButton_Click(object sender, EventArgs e)
        {
            ProdutosInformation produto = new ProdutosInformation();
            produto.Nome = NomeProdutoTextBox.Text;
            produto.Preco = decimal.Parse(TxtPrecoProduto.Text);
            produto.Estoque = int.Parse(EstoqueProdutoTextBox.Text);

            ProdutosBLL obj = new ProdutosBLL();
            obj.Incluir(produto);
            MessageBox.Show("Seu produto foi incluido com sucesso");
            CodigoProdutoTextBox.Text = Convert.ToString(produto.Codigo);
        }

        private void AlterarProdutoButton_Click(object sender, EventArgs e)
        {
            if (CodigoProdutoTextBox.Text.Length == 0)
            {
                MessageBox.Show("Um cliente deve ser selecionado para alteração");
            }
            else
                try
                {
                    ProdutosInformation produto = new ProdutosInformation();
                    produto.Codigo = int.Parse(CodigoProdutoTextBox.Text);
                    produto.Nome = NomeProdutoTextBox.Text;
                    produto.Preco = Convert.ToDecimal(TxtPrecoProduto.Text);
                    produto.Estoque = Convert.ToInt32(EstoqueProdutoTextBox.Text);

                    ProdutosBLL obj = new ProdutosBLL();
                    obj.Alterar(produto);
                    MessageBox.Show("Produto alterado com sucesso");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro " + ex.Message);
                }
        }

        private void ExcluirProdutoButton_Click(object sender, EventArgs e)
        {
            if (CodigoProdutoTextBox.Text.Length == 0)
            {
                MessageBox.Show("Um produto deve ser selecionado para ser deletado");
            }
            else
                try
                {
                    int codigo = Convert.ToInt32(CodigoProdutoTextBox.Text);

                    ProdutosBLL obj = new ProdutosBLL();
                    obj.Excluir(codigo);
                    MessageBox.Show("produto apagado com sucesso");
                }
                catch (Exception ex)
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
