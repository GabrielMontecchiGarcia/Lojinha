using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Lojinha.Modelos;

namespace Lojinha.DAL
{
    public class ClientesDAL
    {
        public void Incluir(ClienteInformation cliente)
        {
            //Conexão com o banco de dados
            SqlConnection cn = new SqlConnection(Dados.StringConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "insere_cliente";
                //Parâmetros de SP
                SqlParameter pcodigo = new SqlParameter("@codigo", SqlDbType.Int);
                pcodigo.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pcodigo);

                SqlParameter pnome = new SqlParameter("@nome", SqlDbType.VarChar, 100);
                pnome.Value = cliente.Nome;
                cmd.Parameters.Add(pnome);

                SqlParameter pemail = new SqlParameter("@email", SqlDbType.VarChar, 100);
                pemail.Value = cliente.Email;
                cmd.Parameters.Add(pemail);

                SqlParameter ptelefone = new SqlParameter("@telefone", SqlDbType.VarChar, 20);
                ptelefone.Value = cliente.Telefone;
                cmd.Parameters.Add(ptelefone);

                cn.Open();
                cmd.ExecuteNonQuery();

                cliente.Codigo = (Int32)cmd.Parameters["@codigo"].Value;
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
        //Alterar clientes
        public void Alterar(ClienteInformation cliente)
        {
            //Conexão com o banco de dados
            SqlConnection cn = new SqlConnection(Dados.StringConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "altera_cliente";
                //Parâmetros de SP
                SqlParameter pcodigo = new SqlParameter("@codigo", SqlDbType.Int);
                pcodigo.Value = cliente.Codigo;
                cmd.Parameters.Add(pcodigo);

                SqlParameter pnome = new SqlParameter("@nome", SqlDbType.VarChar, 100);
                pnome.Value = cliente.Nome;
                cmd.Parameters.Add(pnome);

                SqlParameter pemail = new SqlParameter("@email", SqlDbType.VarChar, 100);
                pemail.Value = cliente.Email;
                cmd.Parameters.Add(pemail);

                SqlParameter ptelefone = new SqlParameter("@telefone", SqlDbType.VarChar, 20);
                ptelefone.Value = cliente.Telefone;
                cmd.Parameters.Add(ptelefone);
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
                cmd.CommandText = "exclui_cliente";
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
        public DataTable Listagem(string filtro)
        {
            //Conexão com o banco de dados
            SqlConnection cn = new SqlConnection(Dados.StringConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "seleciona_cliente";
                //Parametros da Stored Procedure
                SqlParameter pfiltro = new SqlParameter("@filtro", SqlDbType.VarChar, 100);
                pfiltro.Value = filtro;
                cmd.Parameters.Add(pfiltro);
                DataTable tabela = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabela);
                return tabela;
            }
            catch (SqlException ex)
            {
                throw new Exception("Erro ao acessar o banco de dados." + ex.Message.ToString());
            }
            catch
            {
                throw new Exception("Erro desconhecido ao acessar o banco de dados.");
            }
            finally
            {
                cn.Close();
            }

        }
    }
}
