using System.Globalization;

namespace AppCurso.Fundamentos;

public class InputDate
{
    public static void Executar()
    {
        string frase = Console.ReadLine();
        string x = Console.ReadLine();
        string y = Console.ReadLine();
        string z = Console.ReadLine();
        
        //string s = Console.ReadLine(); incluindo diretamente na vetorização
        
        // Vetorização da string
        string[] vet = Console.ReadLine().Split(' ');
        string p1 = vet[0];
        string p2 = vet[1];
        string p3 = vet[2];
        
        Console.WriteLine("Você digitou: " + frase);
        Console.WriteLine("Você digitou: " + x);
        Console.WriteLine("Você digitou: " + y);
        Console.WriteLine("Você digitou: " + z);

        Console.WriteLine(p1);
        Console.WriteLine(p2);
        Console.WriteLine(p3);
    }
}