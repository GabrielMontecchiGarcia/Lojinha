using System;
using System.Collections.Generic;
using System.Data;
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
            if(produtos.Preco == 0)
            {
                throw new Exception("O preço do produto é obrigátorio");
            }
            if(produtos.Estoque == 0)
            {
                throw new Exception("O estoque do produto é obrigátorio");
            }
            ProdutosBLL obj = new ProdutosBLL();
            obj.Incluir(produtos);
        }
        public void Alterar (ProdutosInformation produtos)
        {
            if(produtos.Nome.Trim().Length == 0)
            {
                throw new Exception("O nome do produto é obrigátorio");
            }
            ProdutosBLL obj = new ProdutosBLL();
            obj.Alterar(produtos);
        }
        public void Excluir(int codigo)
        {
            if(codigo < 1)
            {
                throw new Exception("Selecione um produto válido antes de excluir");
            }
            ProdutosBLL obj = new ProdutosBLL();
            obj.Excluir(codigo);
        }
        public DataTable Listagem(string filtro)
        {
            ProdutosBLL obj = new ProdutosBLL();
            return obj.Listagem(filtro);
        }
    }
}
