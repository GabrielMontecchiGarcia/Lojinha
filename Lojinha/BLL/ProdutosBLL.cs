using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lojinha.DAL;
using Lojinha.Modelos;

namespace Lojinha.BLL
{
    public class ProdutosBLL
    {
        public void Incluir(ProdutosInformation produtos)
        {
            if(produtos.Nome.Trim().Length == 0)
            {
                throw new Exception("O Nome do Produto é Obrigátorio");
            }
            produtos.Preco = produtos.Preco;
        }
    }
}
