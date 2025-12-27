using System;
using System.Globalization;

namespace AppCurso.Fundamentos;

public class InputDates
{
    public static void Executar()
    {
        int n1 = int.Parse(Console.ReadLine()); // convertendo string para int
        char ch = char.Parse(Console.ReadLine()); // convertendo string para char
        double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        
        string [] vet = Console.ReadLine().Split(' '); // lendo varios valores em uma unica linha
        
        string nome = vet[0];
        char sexo = char.Parse(vet[1]); // convertendo string para char
        int idade = int.Parse(vet[2]);
        double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

        Console.WriteLine("**** Você digitou ****:");
        Console.WriteLine(n1);
        Console.WriteLine(ch);
        Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture)); // "F2" para formatar com 2 casas decimais

        Console.WriteLine(nome);
        Console.WriteLine(sexo);
        Console.WriteLine(idade);
        Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
    }
}