using Microsoft.Data.SqlClient;
public class ProdutoRepository : Database, IProdutoRepository
{
    public void Create(Produto produto)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = conn;
        cmd.CommandText = "INSERT INTO Produto VALUES (@nome, @preco)";

        cmd.Parameters.AddWithValue("@nome", produto.Nome);
        cmd.Parameters.AddWithValue("@preco", produto.Preco);

        cmd.ExecuteNonQuery();
    }

    public void Delete(int id)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = conn;
        cmd.CommandText = "DELETE FROM Produto Where ProdutoId = (@produtoid)";

        cmd.Parameters.AddWithValue("@produtoid", id);

        cmd.ExecuteNonQuery();
    }

    public List<Produto> Read()
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = conn;
        cmd.CommandText = "SELECT * FROM Produto";

        SqlDataReader reader = cmd.ExecuteReader();

        List<Produto> produtos = new List<Produto>();

        while(reader.Read())
        {
            Produto p = new Produto();
            p.ProdutoId = reader.GetInt32(0);
            p.Nome = reader.GetString(1);
            p.Preco = reader.GetDecimal(2);

            produtos.Add(p);
        }
   
        
        return produtos;
    }

    public Produto Read(int id)
   {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = conn;
        cmd.CommandText = "SELECT * FROM Produto Where ProdutoId = @produtoid";

        cmd.Parameters.AddWithValue("@produtoid", id);

        SqlDataReader reader = cmd.ExecuteReader();

         if(reader.Read())
        {
            Produto p = new Produto();
            p.ProdutoId = reader.GetInt32(0);
            p.Nome = reader.GetString(1);
            p.Preco = reader.GetDecimal(2);

           return p;
        }
        return null;
    }
    
    

    public void Update(Produto produto)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = conn;
        cmd.CommandText =  "UPDATE Produto SET Nome = @nome, Preco = @preco WHERE ProdutoId = @produtoid;";

        cmd.Parameters.AddWithValue("@nome", produto.Nome);
        cmd.Parameters.AddWithValue("@preco", produto.Preco);
        cmd.Parameters.AddWithValue("@produtoid", produto.ProdutoId);

        cmd.ExecuteNonQuery();
    }
}