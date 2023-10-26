using Microsoft.Data.SqlClient;
public abstract class Database: IDisposable
{
    protected SqlConnection conn;
    // abrir a conexão
    public Database() 
    {
        string connectionString = "Data Source= DESKTOP-LAB0504\\MSSQLSERVER02; Initial Catalog= BDEcommerce; Integrated Security=true; TrustServerCertificate=true";
        conn = new SqlConnection(connectionString);
        conn.Open();
        Console.WriteLine("Conexão Aberta");
    }
    // fechar a conexão
    public void Dispose()
    {
        conn.Close();
        Console.WriteLine("Conexão fechada");
    }
}