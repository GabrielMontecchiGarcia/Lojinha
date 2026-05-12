using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lojinha.Modelos;
using System.Data;
using System.Data.SqlClient;

namespace Lojinha.DAL
{
    public class VendasDAL
    {
        public void incluir(VendasInformation vendas)
        {
            //Conexão com o banco de dados
            SqlConnection cn = new SqlConnection(Dados.StringConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "insere_venda";
                //Parâmetros de SP
                SqlParameter pcodigo = new SqlParameter("@codigo", SqlDbType.Int);
                pcodigo.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pcodigo);

                SqlParameter pdata = new SqlParameter("@data", SqlDbType.DateTime);
                pdata.Value = vendas.Data;
                cmd.Parameters.Add(pdata);

                SqlParameter pquantidade = new SqlParameter("@quantidade", SqlDbType.Int);
                pquantidade.Value = vendas.Quantidade;
                cmd.Parameters.Add(pquantidade);

                SqlParameter pfaturado = new SqlParameter("@faturado", SqlDbType.Bit);
                pfaturado.Value = vendas.Faturado;
                cmd.Parameters.Add(pfaturado);

                SqlParameter pcodigoProduto = new SqlParameter("@codigoProduto", SqlDbType.Int);
                pcodigoProduto.Value = vendas.CodigoProduto;
                cmd.Parameters.Add(pcodigoProduto);
                cn.Open();
                cmd.ExecuteNonQuery();

                vendas.Codigo = (Int32)cmd.Parameters["@codigo"].Value;
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
        public void alterar(VendasInformation vendas)
        {
            //Conexão com o banco de dados
            SqlConnection cn = new SqlConnection(Dados.StringConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "altera_venda";
                //Parâmetros de SP
                SqlParameter pcodigo = new SqlParameter("@codigo", SqlDbType.Int);
                pcodigo.Value = vendas.Codigo;
                cmd.Parameters.Add(pcodigo);

                SqlParameter pdata = new SqlParameter("@data", SqlDbType.DateTime);
                pdata.Value = vendas.Data;
                cmd.Parameters.Add(pdata);

                SqlParameter pquantidade = new SqlParameter("@quantidade", SqlDbType.Int);
                pquantidade.Value = vendas.Quantidade;
                cmd.Parameters.Add(pquantidade);

                SqlParameter pfaturado = new SqlParameter("@faturado", SqlDbType.Bit);
                pfaturado.Value = vendas.Faturado;
                cmd.Parameters.Add(pfaturado);

                SqlParameter pcodigoProduto = new SqlParameter("@codigoProduto", SqlDbType.Int);
                pcodigoProduto.Value = vendas.CodigoProduto;
                cmd.Parameters.Add(pcodigoProduto);

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
        public void excluir(int codigo)
        {
            //Conexão com o banco de dados
            SqlConnection cn = new SqlConnection(Dados.StringConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "exclui_venda";
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
        public DataTable listagem(string filtro)
        {
            DataTable tabela = new DataTable();
            //Conexão com o banco de dados
            SqlConnection cn = new SqlConnection(Dados.StringConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "seleciona_vendas";
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
            return tabela;
        }
    }
}
