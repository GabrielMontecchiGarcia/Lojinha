using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lojinha.Modelos;

namespace Lojinha.DAL
{
    public class ProdutoDAL
    {
        public void Incluir(ProdutosInformation produtos)
        {
            //Conexão com o banco de dados
            SqlConnection cn = new SqlConnection(Dados.StringConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = " ";
                //Parâmetros de SP
                SqlParameter pcodigo = new SqlParameter("@codigo", SqlDbType.Int);
                pcodigo.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pcodigo);

                SqlParameter pdescricao = new SqlParameter("@estoque", SqlDbType.Int);
                pdescricao.Value = produtos.Estoque;
                cmd.Parameters.Add(pdescricao);

                SqlParameter ppreco = new SqlParameter("@preco", SqlDbType.Decimal);
                ppreco.Value = produtos.Preco;
                cmd.Parameters.Add(ppreco);
                cn.Open();
                cmd.ExecuteNonQuery();

                produtos.Codigo = (Int32)cmd.Parameters["@codigo"].Value;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao abrir conexão com o banco de dados. " + ex.Message);
            }
            catch
            {
                throw new Exception("Errro descohecido ao acessar banco de dados");
            }
            finally
            {
                cn.Close();
            }
        }
        public void Alterar(ProdutosInformation produtos)
        {
            //Conexão com o banco de dados
            SqlConnection cn = new SqlConnection(Dados.StringConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "altera_produto";
                //Parâmetros de SP

                SqlParameter pcodigo = new SqlParameter("@codigo", SqlDbType.Int);
                pcodigo.Value = produtos.Codigo;
                cmd.Parameters.Add(pcodigo);

                SqlParameter pdescricao = new SqlParameter("@estoque", SqlDbType.Int);
                pdescricao.Value = produtos.Estoque;
                cmd.Parameters.Add(pdescricao);

                SqlParameter ppreco = new SqlParameter("@preco", SqlDbType.Decimal);
                ppreco.Value = produtos.Preco;
                cmd.Parameters.Add(ppreco);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao abrir conexão com o banco de dados. " + ex.Message);
            }
            catch
            {
                throw new Exception("Errro descohecido ao acessar banco de dados");
            }
            finally
            {
                cn.Close();
            }
        }
        public void Excluir(int codigo)
        {
            //Conexão com o banco de dados
            SqlConnection cn = new SqlConnection(Dados.StringConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "exclui_produto";
                //Parâmetros de SP
                SqlParameter pcodigo = new SqlParameter("@codigo", SqlDbType.Int);
                pcodigo.Value = codigo;
                cmd.Parameters.Add(pcodigo);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao abrir conexão com o banco de dados. " + ex.Message);
            }
            catch
            {
                throw new Exception("Errro descohecido ao acessar banco de dados");
            }
            finally
            {
                cn.Close();
            }
        }
        public DataTable Listagem (string filtro)
        {
            //Conexão com o banco de dados
            SqlConnection cn = new SqlConnection(Dados.StringConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "seleciona_produtos";
                //Parâmetros de SP
                SqlParameter pfiltro = new SqlParameter("@filtro", SqlDbType.VarChar, 100);
                pfiltro.Value = filtro;
                cmd.Parameters.Add(pfiltro);
                cn.Open();
                DataTable tabela = new DataTable();
                tabela.Load(cmd.ExecuteReader());
                return tabela;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao abrir conexão com o banco de dados. " + ex.Message);
            }
            catch
            {
                throw new Exception("Errro descohecido ao acessar banco de dados");
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
