using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOJASOM.CAMADAS.DAL
{
    public class Produto
    {
        private string strCon = Conexao.getConexao();

        public List<MODEL.Produto> Select()
        {
            List<MODEL.Produto> lstProdutos = new List<MODEL.Produto>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Produtos";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.Produto produto = new MODEL.Produto();
                    produto.id = Convert.ToInt32(dados["id"].ToString());
                    produto.descricao = dados["descricao"].ToString();
                    produto.marca = dados["marca"].ToString();
                    produto.quantidade = Convert.ToSingle(dados["quantidade"].ToString());
                    produto.preco = Convert.ToSingle(dados["preco"].ToString());
                    lstProdutos.Add(produto);

                }
            }
            catch
            {
                Console.WriteLine("Erro na Consulta de Produtos!");
            }
            return lstProdutos;
        }

            public List<MODEL.Produto> SelectById(int id)
            {
                List<MODEL.Produto> lstProdutos = new List<MODEL.Produto>();
                SqlConnection conexao = new SqlConnection(strCon);
                string sql = "Select * from Produtos where id=@id";
                SqlCommand cmd = new SqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@id", id);
                try
                {
                    conexao.Open();
                    SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    while (dados.Read())
                    {
                        MODEL.Produto produto = new MODEL.Produto();
                        produto.id = Convert.ToInt32(dados["id"].ToString());
                        produto.descricao = dados["descricao"].ToString();
                        produto.marca = dados["marca"].ToString();
                        produto.quantidade = Convert.ToSingle(dados["quantidade"].ToString());
                        produto.preco = Convert.ToSingle(dados["preco"].ToString());
                        lstProdutos.Add(produto);

                    }
                }
                catch
                {
                    Console.WriteLine("Erro na Consulta de Produtos por ID!");
                }
                return lstProdutos;
            }

            public List<MODEL.Produto> SelectByDescricao(string descricao)
            {
                List<MODEL.Produto> lstProdutos = new List<MODEL.Produto>();
                SqlConnection conexao = new SqlConnection(strCon);
                string sql = "Select * from Produtos where (descricao like @descricao)";
                SqlCommand cmd = new SqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@descricao", "%" + descricao + "%");
                try
                {
                    conexao.Open();
                    SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    while (dados.Read())
                    {
                        MODEL.Produto produto = new MODEL.Produto();
                        produto.id = Convert.ToInt32(dados["id"].ToString());
                        produto.descricao = dados["descricao"].ToString();
                        produto.marca = dados["marca"].ToString();
                        produto.quantidade = Convert.ToSingle(dados["quantidade"].ToString());
                        produto.preco = Convert.ToSingle(dados["preco"].ToString());
                        lstProdutos.Add(produto);

                    }
                }
                catch
                {
                    Console.WriteLine("Erro na Consulta de Produtos!");
                }
                return lstProdutos;
            }

            public List<MODEL.Produto> SelectByMarca(string marca)
            {
                List<MODEL.Produto> lstProdutos = new List<MODEL.Produto>();
                SqlConnection conexao = new SqlConnection(strCon);
                string sql = "Select * from Produtos where (marca like @marca)";
                SqlCommand cmd = new SqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@marca", "%" + marca + "%");
                try
                {
                    conexao.Open();
                    SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    while (dados.Read())
                    {
                        MODEL.Produto produto = new MODEL.Produto();
                        produto.id = Convert.ToInt32(dados["id"].ToString());
                        produto.descricao = dados["descricao"].ToString();
                        produto.marca = dados["marca"].ToString();
                        produto.quantidade = Convert.ToSingle(dados["quantidade"].ToString());
                        produto.preco = Convert.ToSingle(dados["preco"].ToString());
                        lstProdutos.Add(produto);

                    }
                }
                catch
                {
                    Console.WriteLine("Erro na Consulta de Produtos!");
                }
                return lstProdutos;
            }

            public void Insert(MODEL.Produto produto)
            {
                SqlConnection conexao = new SqlConnection(strCon);
                string sql = "Insert into Produtos values (@descricao, @marca, @quantidade, @preco);";
                SqlCommand cmd = new SqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@id", produto.id);
                cmd.Parameters.AddWithValue("@descricao", produto.descricao);
                cmd.Parameters.AddWithValue("@marca", produto.marca);
                cmd.Parameters.AddWithValue("@quantidade", produto.quantidade);
                cmd.Parameters.AddWithValue("@preco", produto.preco);
                try
                {
                    conexao.Open();
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    Console.WriteLine("Erro na Inserção de Produtos!");
                }
                finally
                {
                    conexao.Close();
                }
            }

            public void Update(MODEL.Produto produto)
            {
                SqlConnection conexao = new SqlConnection(strCon);
                string sql = "Update Produtos set descricao=@descricao, marca=@marca, quantidade=@quantidade, preco=@preco where id=@id";
                SqlCommand cmd = new SqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@id", produto.id);
                cmd.Parameters.AddWithValue("@descricao", produto.descricao);
                cmd.Parameters.AddWithValue("@marca", produto.marca);
                cmd.Parameters.AddWithValue("@quantidade", produto.quantidade);
                cmd.Parameters.AddWithValue("@preco", produto.preco);
                try
                {
                    conexao.Open();
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    Console.WriteLine("Erro de Atualização de Produtos!");
                }
                finally
                {
                    conexao.Close();
                }
            }

            public void Delete(int id)
            {
                SqlConnection conexao = new SqlConnection(strCon);
                string sql = "Delete from Produtos where id=@id";
                SqlCommand cmd = new SqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@id", id);

                try
                {
                    conexao.Open();
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    Console.WriteLine("Erro na Remoção de Produtos!");
                }
                finally
                {
                    conexao.Close();
                }
            }

      
    }
}
