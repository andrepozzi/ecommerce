public interface IClienteRepository
{
    List<Cliente> Read();
    Cliente Read(int id);
    void Create(Cliente cliente);
    void Delete(int id);
    void Update(Cliente cliente);
    List<Cliente> Search(string form);
}