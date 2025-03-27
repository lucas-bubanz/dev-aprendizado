/*Implemente um algoritmo que valide se um CPF fornecido pelo usuário é válido ou não.*/

using System;

class Program
{
    public static string FormataCPF(string cpf)
    {
        try
        {
            return Convert.ToUInt64(cpf).ToString(@"000\.000\.000\-00");
        }
        catch (System.Exception e)
        {            
            throw new Exception("Erro ao formatar CPF", e);
        }
    }

    public static bool ValidaCPF(string cpf)
    {
        if (string.IsNullOrWhiteSpace(cpf) || cpf.Length != 11 || !long.TryParse(cpf, out _))
        {
            return false;
        }
        return true;
    }
    public static void Main()
    {
        Console.Write("Digite o CPF: ");
        string? cpf = Console.ReadLine();

        if (!ValidaCPF(cpf))
        {
            Console.WriteLine("Erro: CPF inválido! Certifique-se de que o CPF contém 11 dígitos numéricos e é válido.");
        }
        else
        {
            string cpfFormatado = FormataCPF(cpf);
            Console.WriteLine($"CPF válido: {cpfFormatado}");
        }
    }
}