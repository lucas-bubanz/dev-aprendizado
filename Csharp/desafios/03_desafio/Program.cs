/* Implemente um programa que permita adicionar, remover, buscar e listar contatos usando uma List<Pessoa>, 
   onde Pessoa é uma classe que contém o Nome, Telefone e Email. */

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static List<Pessoa> pessoas = new List<Pessoa>();

    static void Main()
    {
        string opcao;
        do
        {
            ExibirMenu();            
            opcao = Console.ReadLine();
            Console.Clear();

            switch (opcao)
            {
                case "1":
                    AdicionarPessoa();
                    break;
                case "2":
                    RemoverPessoa();
                    break;
                case "3":
                    BuscarPessoa();
                    break;
                case "4":
                    ListarPessoas();
                    break;
                case "5":
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        } while (opcao != "5");
    }

    static void ExibirMenu()
    {
        Console.WriteLine("1 - Adicionar");
        Console.WriteLine("2 - Remover");
        Console.WriteLine("3 - Buscar");
        Console.WriteLine("4 - Listar");
        Console.WriteLine("5 - Sair");
        Console.Write("Opção: ");
    }

    static void AdicionarPessoa()
    {
        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        Console.Write("Telefone: ");
        string telefone = Console.ReadLine();
        Console.Write("Email: ");
        string email = Console.ReadLine();

        pessoas.Add(new Pessoa(nome, telefone, email));
        Console.WriteLine("Pessoa adicionada com sucesso!");
    }

    static void RemoverPessoa()
    {
        Console.Write("Nome da pessoa a remover: ");
        string nomeRemover = Console.ReadLine();
        Pessoa pessoaRemover = pessoas.FirstOrDefault(p => p.Nome.Equals(nomeRemover, StringComparison.OrdinalIgnoreCase));

        if (pessoaRemover != null)
        {
            pessoas.Remove(pessoaRemover);
            Console.WriteLine("Pessoa removida com sucesso!");
        }
        else
        {
            Console.WriteLine("Pessoa não encontrada!");
        }
    }

    static void BuscarPessoa()
    {
        Console.Write("Nome da pessoa a buscar: ");
        string nomeBuscar = Console.ReadLine();
        Pessoa pessoaBuscar = pessoas.FirstOrDefault(p => p.Nome.Equals(nomeBuscar, StringComparison.OrdinalIgnoreCase));

        if (pessoaBuscar != null)
        {
            Console.WriteLine($"Nome: {pessoaBuscar.Nome}");
            Console.WriteLine($"Telefone: {pessoaBuscar.Telefone}");
            Console.WriteLine($"Email: {pessoaBuscar.Email}");
        }
        else
        {
            Console.WriteLine("Pessoa não encontrada!");
        }
    }

    static void ListarPessoas()
    {
        if (pessoas.Count == 0)
        {
            Console.WriteLine("Nenhuma pessoa cadastrada.");
            return;
        }

        foreach (Pessoa pessoa in pessoas)
        {
            Console.WriteLine($"Nome: {pessoa.Nome}");
            Console.WriteLine($"Telefone: {pessoa.Telefone}");
            Console.WriteLine($"Email: {pessoa.Email}");
            Console.WriteLine();
        }
    }
}

class Pessoa
{
    public string Nome { get; set; }
    public string Telefone { get; set; }
    public string Email { get; set; }

    public Pessoa(string nome, string telefone, string email)
    {
        Nome = nome;
        Telefone = telefone;
        Email = email;
    }
}