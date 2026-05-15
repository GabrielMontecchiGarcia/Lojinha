using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            produto.Preco = Convert.ToDecimal(PrecoProdutoTextBox.Text);
            produto.Estoque = Convert.ToInt32(EstoqueProdutoTextBox.Text);

            
        }
    }
}
