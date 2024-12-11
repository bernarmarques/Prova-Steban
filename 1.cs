using System;

class Program
{
    static void Main()
    {
        // Lendo as notas do aluno (quatro valores de ponto flutuante)
        string[] entradas = Console.ReadLine().Split(' ');
        float n1 = float.Parse(entradas[0]);
        float n2 = float.Parse(entradas[1]);
        float n3 = float.Parse(entradas[2]);
        float n4 = float.Parse(entradas[3]);

        // Calculando a média com os respectivos pesos
        float media = (n1 * 2 + n2 * 3 + n3 * 4 + n4 * 1) / 10;

        // Exibindo a média com uma casa decimal
        Console.WriteLine($"Media: {media:F1}");

        // Verificando a situação do aluno
        if (media >= 7.0)
        {
            Console.WriteLine("Aluno aprovado.");
        }
        else if (media >= 5.0 && media <= 6.9)
        {
            Console.WriteLine("Aluno em exame.");
            
            // Lendo a nota do exame
            float notaExame = float.Parse(Console.ReadLine());
            Console.WriteLine($"Nota do exame: {notaExame:F1}");

            // Recalculando a média final
            float mediaFinal = (media + notaExame) / 2;

            // Verificando se o aluno foi aprovado ou reprovado após o exame
            if (mediaFinal >= 5.0)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else
            {
                Console.WriteLine("Aluno reprovado.");
            }

            // Exibindo a média final
            Console.WriteLine($"Media final: {mediaFinal:F1}");
        }
        else
        {
            Console.WriteLine("Aluno reprovado.");
        }
    }
}