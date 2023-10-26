public interface IProdutoRepository
{
    List<Produto> Read();
    Produto Read(int id);
    void Create(Produto produto);
    void Delete(int id);
    void Update(Produto produto);
}