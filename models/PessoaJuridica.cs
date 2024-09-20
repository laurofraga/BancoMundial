using System;
using System.Collections.Generic;

public class PessoaJuridica : Pessoa
{
    public List<pessoaFisica> socios {get; set;}
    public int Cnpj {get; set;}
    public string RazaoSocial {get; set;}
    public string NomeFantasia {get; set;}
    public string InscricaoEstadual {get; set;}
    public DateTime DataAbertura {get; set;}
    publin int idade => DateTime.Now.Year - DataAbertura.Year;
    public double Faturamento {get; set;}

    public PessoaJuridica(int cnpj, string razaoSocial, string nomeFantasia, string inscricaoEstadual, DateTime dataAbertura, string endereco, string telefone, string email, double faturamento)
    : base(endereco, telefone, email)
    {
        Cnpj = cnpj;
        RazaoSocial = razaoSocial;
        NomeFantasia = nomeFantasia;
        InscricaoEstadual = inscricaoEstadual;
        DataAbertura = dataAbertura;
        Faturamento = faturamento;
    }

}