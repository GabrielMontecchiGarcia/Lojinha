using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lojinha.DAL;
using Lojinha.Modelos;
using Microsoft.Data.SqlClient.Internal;
namespace Lojinha.BLL
{
    public class ClientesBLL
    {
        public void incluir(ClienteInformation cliente)
        {
            //o nome do cliente é obrigatório
            if (cliente.Nome.Trim().Length == 0)
            {
                throw new Exception("O nome do cliente é obrigatório");
            }
            //email é sempre com letras minusculas
            cliente.Email = cliente.Email.ToLower();
            //se está tudo ok, chama a rotina de inserção
            ClientesDAL obj = new ClientesDAL();
            obj.Incluir(cliente);
        }
        public void alterar(ClienteInformation cliente)
        {
            if (cliente.Nome.Trim().Length ==0)
            {
                throw new Exception("O nome do cliente é obrigatório");
            }
            //email é sempre com letras minusculas
            cliente.Email = cliente.Email.ToLower();
            //se está tudo ok, chama a rotina de inserção
            ClientesDAL obj = new ClientesDAL();
            obj.Alterar(cliente);
        }
        public void excluir(int codigo)
        {
            if (codigo < 1)
            {
                throw new Exception("Selecione um cliente válido antes de excluir");
            }
            ClientesDAL obj = new ClientesDAL();
            obj.Excluir(codigo);
        }
        public DataTable Listagem(string filtro)
        {
            ClientesDAL obj = new ClientesDAL();
            return obj.Listagem(filtro);
        }
    }
}
