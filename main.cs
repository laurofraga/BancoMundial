using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
        PessoaFisica pessoa1 = new PessoaFisica("João", "Silva", "12345678", "111.222.333-44", new DateTime(1990, 5, 20), "Rua A, 123", "1111-1111", "joao@email.com", 3000);
        PessoaFisica pessoa2 = new PessoaFisica("Maria", "Oliveira", "87654321", "999.888.777-66", new DateTime(2002, 8, 15), "Rua B, 456", "2222-2222", "maria@email.com", 1500);
        
       
        List<PessoaFisica> socios = new List<PessoaFisica> { pessoa1, pessoa2 };

        
        PessoaJuridica empresa1 = new PessoaJuridica(socios, 123456789, "Empresa ABC Ltda", "ABC Store", "987654321", new DateTime(2015, 1, 10), "Av. Empresarial, 1000", "3333-3333", "contato@empresaabc.com", 50000);
        
        
        Console.WriteLine($"Pessoa Física: {pessoa1.Nome} {pessoa1.Sobrenome}, CPF: {pessoa1.Cpf}, Faixa Etária: {pessoa1.FaixaEtaria}");
        Console.WriteLine($"Pessoa Jurídica: {empresa1.RazaoSocial}, CNPJ: {empresa1.Cnpj}, Faturamento: {empresa1.Faturamento:C}");

        
        ContaCorrente contaCorrenteJoao = new ContaCorrente(pessoa1, 1010, "SIMPLES");
        ContaPoupanca contaPoupancaMaria = new ContaPoupanca(pessoa2, 2020, 0.05);
        ContaSalario contaSalarioEmpresa = new ContaSalario(empresa1, 3030);

       

        
        contaCorrenteJoao.Depositar(2000);
        Console.WriteLine($"Saldo da conta corrente de João: {contaCorrenteJoao.ConsultarSaldo():C}");

        
        contaPoupancaMaria.Depositar(500);
        Console.WriteLine($"Saldo da conta poupança de Maria: {contaPoupancaMaria.ConsultarSaldo():C}");

       
        contaCorrenteJoao.Transferir(contaPoupancaMaria, 500);
        Console.WriteLine($"Saldo de João após transferência: {contaCorrenteJoao.ConsultarSaldo():C}");
        Console.WriteLine($"Saldo de Maria após receber transferência: {contaPoupancaMaria.ConsultarSaldo():C}");

        
        contaSalarioEmpresa.Sacar(1000); 
        contaSalarioEmpresa.Transferir(contaCorrenteJoao, 1000); 
        
        contaPoupancaMaria.Sacar(200);
        Console.WriteLine($"Saldo da conta poupança de Maria após saque: {contaPoupancaMaria.ConsultarSaldo():C}");

        
        contaCorrenteJoao.Pagar("1234567890123456");
        
        contaCorrenteJoao.Emprestimo(300);
        Console.WriteLine($"Saldo da conta corrente de João após empréstimo: {contaCorrenteJoao.ConsultarSaldo():C}");

        
        Console.WriteLine("Operações bancárias concluídas.");
    }
}
