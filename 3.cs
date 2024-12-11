using System;

class Program
{
    static void Main()
    {
        // Entrada do dia e horário inicial
        Console.Write("Dia de início: ");
        int diaInicio = int.Parse(Console.ReadLine().Split(' ')[1]);

        Console.Write("Hora de início (hh:mm:ss): ");
        string[] tempoInicio = Console.ReadLine().Split(':');
        int horaInicio = int.Parse(tempoInicio[0]);
        int minutoInicio = int.Parse(tempoInicio[1]);
        int segundoInicio = int.Parse(tempoInicio[2]);

        // Entrada do dia e horário final
        Console.Write("Dia de término: ");
        int diaTermino = int.Parse(Console.ReadLine().Split(' ')[1]);

        Console.Write("Hora de término (hh:mm:ss): ");
        string[] tempoTermino = Console.ReadLine().Split(':');
        int horaTermino = int.Parse(tempoTermino[0]);
        int minutoTermino = int.Parse(tempoTermino[1]);
        int segundoTermino = int.Parse(tempoTermino[2]);

        // Convertendo tudo para segundos
        int inicioEmSegundos = segundoInicio + minutoInicio * 60 + horaInicio * 3600 + diaInicio * 86400;
        int terminoEmSegundos = segundoTermino + minutoTermino * 60 + horaTermino * 3600 + diaTermino * 86400;

        // Diferença total em segundos
        int duracaoEmSegundos = terminoEmSegundos - inicioEmSegundos;

        // Calculando dias, horas, minutos e segundos
        int dias = duracaoEmSegundos / 86400;
        duracaoEmSegundos %= 86400;

        int horas = duracaoEmSegundos / 3600;
        duracaoEmSegundos %= 3600;

        int minutos = duracaoEmSegundos / 60;
        int segundos = duracaoEmSegundos % 60;

        // Saída formatada
        Console.WriteLine($"{dias} dia(s)");
        Console.WriteLine($"{horas} hora(s)");
        Console.WriteLine($"{minutos} minuto(s)");
        Console.WriteLine($"{segundos} segundo(s)");
    }
}