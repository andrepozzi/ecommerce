public class Item
{
    public Produto Produto { get; set; }
    public int Quantidade { get; set; }
    public decimal Total
    {
        get { return this.Produto.Preco * this.Quantidade; }
    }
}