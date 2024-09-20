using System;

public class ContaCorrente : ContaCorrente, IDepositavel
{
    public string Tipo {get; private set;}
    public double Limite {get; private set;}
    public double TaxaDoLimite {get; private set;}

    public ContaCorrente(Pessoa titular, int agencia, string tipo) : base(titular, agencia)
    {
        Tipo = tipo;
        
        if (tipo == "SIMPES")
        {
            Limite = titular is PessoaFisica ? pf.renda * 1.5 : 0;
            TaxaDoLimite = 0.05;
        }
        else if (tipo == "ESPECIAL")
        {
            Limite = titular is PessoaFisica && pf.renda > 5000 ? Pf.renda * 2 : 0;
            TaxaDoLimite = 0.02;
        }
        else
        {
            Limite = 0;
            TaxaDoLimite = 0;
        }
    }

    public void Depositar(double valor)
    {
        Saldo += valor;
        Console.WriteLine("Depósito de {valor:C} realizado. Saldo atual: {Saldo:C}");
    }


    public override void Transferir (ContaCorrente conta, double valor)
    {
        if (Saldo + Limite >= valor)
        {
            Saldo -= valor;
            conta.Saldo += valor;
            Console.WriteLine("Transferência de {valor:C} realizada. Saldo atual: {Saldo:C}");
        }
        else
        {
            Console.WriteLine("Saldo insuficiente");
        }

    }
    public void Pagar(string codigoBarras)
    {
        Console.WriteLine("Pagamento de {codigoBarras} realizado");
    }

    public void Emprestimo(double valor)
    {if (Saldo + Limite >= valor)
        {
            Saldo -= valor;
            Console.WriteLine("Empréstimo de {valor:C} realizado. Saldo atual: {Saldo:C}");
        }
        else
        {
            Console.WriteLine("Emprestimp não aprovado");
        }
    }
}