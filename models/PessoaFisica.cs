using System;

public class PessoaFisica : Pessoa
{
    public string Nome {get; set;}
    public string Sobrenome {get; set;}
    public string Rg {get; set;}
    public string CPF {get; set;}
    public DateTime DataDeNascimento {get; set;}
    public int Idade => DateTime.Now.Year - DataDeNascimento.Year;
    public string FaixaEtaria => Auxiliar.FaixaEtaria(Idade);
    public double Renda {get; set;}

    public PessoaFisica(string nome, string sobrenome, string rg, string cpf, DateTime dataDeNascimento, string endereco, string telefone, string email, double renda) 
    : base(endereco, telefone, email)
    {
        Nome = nome;
        Sobrenome = sobrenome;
        Rg = rg;
        CPF = cpf;
        DataDeNascimento = dataDeNascimento;
        Renda = renda;
    }

}