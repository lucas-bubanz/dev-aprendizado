/*Crie um jogo da forca simples em que o usuário precisa adivinhar uma palavra oculta. 
O jogo deve permitir tentativas e mostrar a palavra oculta com os caracteres corretos revelados progressivamente.*/

using System;
using System.Collections.Generic;
using System.Linq;

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{

    static void Main()
    {                
        string palavraSecreta = "banana";        
        char[] palavraEscondida = new string('_', palavraSecreta.Length).ToCharArray();
        HashSet<char> letrasErradas = new();
        int tentativasRestantes = 6;

        while (tentativasRestantes > 0 && palavraEscondida.Contains('_'))
        {
            Console.Clear();
            Console.WriteLine($"Palavra: {string.Join(" ", palavraEscondida)}");
            Console.WriteLine($"Tentativas restantes: {tentativasRestantes}");
            Console.WriteLine($"Letras erradas: {string.Join(", ", letrasErradas)}");

            Console.Write("Digite uma letra: ");
            char tentativa = Console.ReadLine().ToLower()[0];

            if (palavraSecreta.Contains(tentativa))
            {
                // Revela a letra correta
                for (int i = 0; i < palavraSecreta.Length; i++)
                {
                    if (palavraSecreta[i] == tentativa)
                        palavraEscondida[i] = tentativa;
                }
            }
            else if (!letrasErradas.Contains(tentativa))
            {
                // Adiciona letra errada e reduz tentativas
                letrasErradas.Add(tentativa);
                tentativasRestantes--;
            }

            // Verifica vitória
            if (!palavraEscondida.Contains('_'))
            {
                Console.Clear();
                Console.WriteLine($"Parabéns! Você adivinhou a palavra: {palavraSecreta}");
                return;
            }
        }

        Console.WriteLine($"Fim de jogo! A palavra era: {palavraSecreta}");
    }
}