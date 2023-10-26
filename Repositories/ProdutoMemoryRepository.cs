using System.Linq;

public class ProdutoMemoryRepository : IProdutoRepository
{
    List<Produto> produtos = new List<Produto>();
    public void Create(Produto produto)
    {
        produtos.Add(produto);
    }

    public void Delete(int id)
    {
        var produto = (from p in produtos
                    where p.ProdutoId == id
                    select p).FirstOrDefault();

        produtos.Remove(produto);
    }

    public List<Produto> Read()
    {
        return produtos;
    }

    public Produto Read(int id)
    {
      //  return (from p in produtos 
       //         where p.ProdutoId == id 
        //        select p).FirstOrDefault();
        return produtos.FirstOrDefault(p => p.ProdutoId == id);
    }

    public void Update(Produto produto)
    {
        var p = Read(produto.ProdutoId);

        p.Nome = produto.Nome;
        p.Preco = produto.Preco;
    }
}