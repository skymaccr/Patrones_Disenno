public class ClienteCredito : Cliente
{
    protected override Pedido CreaPedido(double importe)
    {
        return new PedidoCredito(importe);
    }
}
