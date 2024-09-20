public abstract class Conta 
{
    public Pessoas Titular {get; set;}
    public long Numero {get; set;}
    public int Agencia {get; set;}
    public double Saldo {get; set;}
    public double TaxaSaque {get; set;}

    public Conta(Pessoa titular, long numero, int agencia, double saldo, double taxaSaque)
    {
        Titular = titular;
        Numero = numero;
        Agencia = agencia;
        Saldo = 0;
    }

    public void sacar {double valor}
    {
        if (valor > Saldo)
        {
            Console.WriteLine("Saldo insuficiente");
        }
        else
        {
            Saldo -= valor;
            Console.WriteLine("Saque de {valor:C} realizado. Saldo atual: {Saldo:C}");

        }
    }

    public double ConsultarSaldo()
    {
        return Saldo;
    }

    public double Transferir(Conta conta, double valor)
    {
        if (valor > Saldo)
        {
            Console.WriteLine("Saldo insuficiente");
        }
        else
        {
            Saldo -= valor;
            conta.Saldo += valor;
            Console.WriteLine("Transferência de {valor:C} realizada. Saldo atual: {Saldo:C}");
        }
    }
}