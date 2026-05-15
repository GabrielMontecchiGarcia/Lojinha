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
        public void Incluir(ProdutosInformation produto)
        {
            if(produto.Nome.Trim().Length == 0)
            {
                throw new Exception("O Nome do Produto é obrigatório");
            }
            ProdutoDAL obj = new ProdutoDAL();
            obj.Incluir(produto);
        }
        public void Alterar (ProdutosInformation produto)
        {
            if(produto.Nome.Trim().Length == 0)
            {
                throw new Exception("O nome do produto é obrigátorio");
            }
            ProdutoDAL obj = new ProdutoDAL();
            obj.Alterar(produto);
        }
        public void Excluir(int codigo)
        {
            if(codigo < 1)
            {
                throw new Exception("Selecione um produto válido antes de excluir");
            }
            ProdutoDAL obj = new ProdutoDAL();
            obj.Excluir(codigo);
        }
        public DataTable Listagem(string filtro)
        {
            ProdutoDAL obj = new ProdutoDAL();
            return obj.Listagem(filtro);
        }
    }
}
