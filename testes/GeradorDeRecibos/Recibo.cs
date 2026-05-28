using System.Text;
using System;
namespace testes.GeradorDeRecibos;

public class Recibo
{
    public static string GeradorDeRecibos(Pedido pedido)
    {
        var sb = new StringBuilder();
        sb.AppendLine("========================================");
        sb.AppendLine($"Cliente: {pedido.Cliente}");
        sb.AppendLine($"Data do pedido: {pedido.DataPedido.ToShortDateString()}");
        sb.AppendLine(($"Previsão de entrega: {pedido.DataEntrega.ToLongDateString()}"));
        sb.AppendLine($"Dias restantes: {pedido.CalcularDiasParaEntrega()}");
        sb.AppendLine($"Valor: {pedido.ValorTotal}");
        sb.AppendLine($"Desconto: {pedido.Desconto ?? 0}");
        sb.AppendLine($"Valor final: {pedido.ObterValorFinal()}");
        sb.AppendLine("========================================");
        return sb.ToString();
    }

    public class Saida
    {
        public static void Executar()
        {
            Pedido pedido1 = new Pedido("Maria Fernanda", 150.00, 25.00);
            string recibo1 = Recibo.GeradorDeRecibos(pedido1);

            Console.WriteLine(recibo1);

            Pedido pedido2 = new Pedido("Cauê", 200.00, null);
            string recibo2 = Recibo.GeradorDeRecibos(pedido2);
            Console.WriteLine(recibo2);
        }
    }
}