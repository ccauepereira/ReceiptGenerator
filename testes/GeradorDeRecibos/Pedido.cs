using System.Data;
namespace testes.GeradorDeRecibos;

public class Pedido
{
    private string _cliente;
    private double _valorTotal;
    private double? _desconto;
    private DateTime _dataPedido;
    private DateTime _dataEntrega;

    public Pedido(string cliente, double valorTotal, double? desconto)
    {
        _cliente = cliente;
        _valorTotal = valorTotal;
        _desconto = desconto;
        _dataPedido = DateTime.Now;
        _dataEntrega = DateTime.Now.AddDays(7);
    }

    public string Cliente
    {
        get { return _cliente; }
        set { _cliente = value; }
    }
    
    public double ValorTotal
    {
        get { return _valorTotal; }
        set { _valorTotal = value; }
    }

    public double? Desconto
    {
        get { return _desconto;}
        set { _desconto = value; }
    }

    public DateTime DataPedido
    {
        get { return _dataPedido; }
    }

    public DateTime DataEntrega
    {
        get {return _dataEntrega;}
    }

    public int CalcularDiasParaEntrega()
    {
        
        TimeSpan diff = _dataEntrega - DateTime.Now;
        return diff.Days;
    }

    public double? ObterValorFinal()
    {
            return _valorTotal - (_desconto ?? 0);
        }
    }