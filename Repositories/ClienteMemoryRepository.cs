using System.Linq;

public class ClienteMemoryRepository : IClienteRepository
{
    List<Cliente> clientes = new List<Cliente>();
    public void Create(Cliente cliente)
    {
        clientes.Add(cliente);
    }

    public void Delete(int id)
    {
        var cliente = (from c in clientes
                    where c.ClienteId == id
                    select c).FirstOrDefault();

        clientes.Remove(cliente);
    }

    public List<Cliente> Read()
    {
        return clientes;
    }

    public Cliente Read(int id)
    {
        return clientes.FirstOrDefault(c => c.ClienteId == id);
    }

    public List<Cliente> Search(string form)
    {
        
        var listafiltrada = new List<Cliente>();
        foreach(Cliente c in clientes) {
            if(c.Name.Contains(form) )
                listafiltrada.Add(c);
                
        }
                return listafiltrada;
    }

    public void Update(Cliente cliente)
    {
        var c = Read(cliente.ClienteId);

        c.Name = cliente.Name;
        c.Email = cliente.Email;
        c.Password = cliente.Password;
    }
}