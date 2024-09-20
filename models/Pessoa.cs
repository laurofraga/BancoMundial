using System;

public abstract Pessoa
{
    public static int NumeroDePessoas { get; set; }
    public interface Id {get; private set;}
    public string Endereco {get; set;}
    public string Telefone {get; set;}
    public string Email {get; set;}

    public Pessoa(string endereco, string telefone, string email)
    {
        NumeroDePessoas++;
        Id = NumeroDePessoas;
        Endereco = endereco;
        Telefone = telefone;
        Email = email;
        
    }
}