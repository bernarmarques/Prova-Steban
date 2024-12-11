using System;
class Program
{
    static void Main()
    {
        // Leitura das entradas
        string palavra1 = "";
        string palavra2 = "";
        string palavra3 = "";

        Console.WriteLine("Escreva primeira palavra1:");
        palavra1 = Console.ReadLine().ToLower();
        
        Console.WriteLine("Escreva primeira palavra2:");
        palavra2 = Console.ReadLine().ToLower();
        
        Console.WriteLine("Escreva primeira palavra3:");
        palavra3 = Console.ReadLine().ToLower();
        
        
        // Determinação do animal baseado nas entradas
        string resultado = "";

        if (palavra1 == "vertebrado")
        {
            if (palavra2 == "ave")
            {
                if (palavra3 == "carnivoro")
                    resultado = "AGUIA";
                else if (palavra3 == "onivoro")
                    resultado = "POMBA";
            }
            else if (palavra2 == "mamifero")
            {
                if (palavra3 == "onivoro")
                    resultado = "HOMEM";
                else if (palavra3 == "herbivoro")
                    resultado = "VACA";
            }
        }
        else if (palavra1 == "invertebrado")
        {
            if (palavra2 == "inseto")
            {
                if (palavra3 == "hematofago")
                    resultado = "PULGA";
                else if (palavra3 == "herbivoro")
                    resultado = "LAGARTA";
            }
            else if (palavra2 == "anelideo")
            {
                if (palavra3 == "hematofago")
                    resultado = "SANGUESSUGA";
                else if (palavra3 == "onivoro")
                    resultado = "MINHOCA";
            }
        }

        // Impressão do resultado
        Console.WriteLine(resultado);
        
    }
}