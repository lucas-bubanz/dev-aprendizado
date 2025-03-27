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
        cpf = new string(cpf.Where(char.IsDigit).ToArray());

        if (string.IsNullOrWhiteSpace(cpf) || cpf.Length != 11 || !long.TryParse(cpf, out _) || cpf.Distinct().Count() == 1)
        {
            return false;
        }
        int[] multiplicadores1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
        int[] multiplicadores2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

        string tempCpf = cpf.Substring(0, 9);

        int soma = tempCpf.Select((t, i) => (t - '0') * multiplicadores1[i]).Sum();
        int resto = (soma * 10) % 11;
        int primeiroDigito = resto == 10 ? 0 : resto;

        tempCpf += primeiroDigito;
        soma = tempCpf.Select((t, i) => (t - '0') * multiplicadores2[i]).Sum();
        resto = (soma * 10) % 11;
        int segundoDigito = resto == 10 ? 0 : resto;

        return cpf.EndsWith($"{primeiroDigito}{segundoDigito}");
    }
    public static void Main()
    {
        Console.Write("Digite o CPF: ");
        string? cpf = Console.ReadLine();

        if (!ValidaCPF(cpf))
        {
            Console.WriteLine("Erro: CPF inválido! Certifique-se de que o CPF contém 11 dígitos numéricos e se é válido.");
        }
        else
        {
            string cpfFormatado = FormataCPF(cpf);
            Console.WriteLine($"CPF válido: {cpfFormatado}");
        }
    }
}