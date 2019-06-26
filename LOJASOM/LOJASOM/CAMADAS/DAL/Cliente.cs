using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOJASOM.CAMADAS.DAL
{
    public class Cliente
    {
        private string strCon = Conexao.getConexao();

        public List<MODEL.Cliente> Select()
        {
            List<MODEL.Cliente> lstCliente = new List<MODEL.Cliente>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Clientes";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.Cliente cliente = new MODEL.Cliente();
                    cliente.id = Convert.ToInt32(dados["id"].ToString());
                    cliente.nome = dados["nome"].ToString();
                    cliente.endereco = dados["endereco"].ToString();
                    cliente.telefone = dados["telefone"].ToString();
                    lstCliente.Add(cliente);
                }
            }
            catch 
            {
                Console.WriteLine("Consulta da Tabela Clientes deu problema...");
            }
            return lstCliente;
        }
        
        public void Insert(MODEL.Cliente cliente)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into Clientes values(@nome, @endereco, @telefone)";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", cliente.nome);
            cmd.Parameters.AddWithValue("@endereco", cliente.endereco);
            cmd.Parameters.AddWithValue("@telefone", cliente.telefone);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na inserção de Clientes...");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Update(MODEL.Cliente cliente)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update Clientes set nome=@nome, endereco=@endereco, telefone=@telefone where id=@id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", cliente.id);
            cmd.Parameters.AddWithValue("@nome", cliente.nome);
            cmd.Parameters.AddWithValue("@endereco", cliente.endereco);
            cmd.Parameters.AddWithValue("@telefone", cliente.telefone);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro de Atualização de Clientes...");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Delete(int id)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from Clientes where id=@id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na remoção de Cliente...");
            }
            finally
            {
                conexao.Close();
            }
        }
            
    }
}
