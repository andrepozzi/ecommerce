public class Pedido
{
    public int PedidoId { get; set; }   
    public DateTime Data { get; set; }
    public Cliente Cliente {get; set;}
    public List<Item> Items { get; set; }

    public decimal Total => Items.Sum(item => item.Total);

    // public decimal Total {
    //     get 
    //     {
    //         decimal total = 0;
    //         foreach(var item in Items) {
    //             total += item.Total;
    //         }
    //         return total;
    //     }
    // }
}