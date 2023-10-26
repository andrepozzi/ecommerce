public class Cliente
{
    // propriedades:
    private int clienteId;
    private string name;
    private string email;
    private string password;

    public int ClienteId 
    {
        get { return this.clienteId;}
        set { this.clienteId = value;}
    }

    public string Name {
        get { return this.name; }
        set { this.name = value; }
    }

    public string Email {
        get { return this.email; }
        set { this.email = value; }
    }

    public string Password {
        get { return this.password; }
        set { this.password = value; }
    }
}

// Cliente c = new Cliente();
// c.SetName("Fulano");
// c.GetName();

// c.Name = "Ciclano";
// c.Name