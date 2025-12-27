
namespace AppCurso.Fundamentos;

public class FuncMat
{
    public static void Executar()
    {
        // Declarando variaveis
        double x = 3.0;
        double y = 4.0;
        double z = -5.0;
        double A, B, C;

        // funcao raiz quadrada
        A = Math.Sqrt(x);
        B = Math.Sqrt(y);
        C = Math.Sqrt(25.0);
        Console.WriteLine($"Raiz quadrada de {x} = {A:F2}"); // usando interpolação
        Console.WriteLine("Raiz quadrada de " + y + " = " + B );
        Console.WriteLine("Raiz quadrada de 25 = " + C );
        
    }
}