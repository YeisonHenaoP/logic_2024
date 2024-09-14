public class Program
{
    private static void Main(string[] args)
    {
        double a, b, x;   
        Console.Write("Ingrese los coeficientes de la ecuacion\na: ");
        a=Convert.ToDouble(Console.ReadLine());
        Console.Write("\nb: ");
        b = Convert.ToDouble(Console.ReadLine());
        x = (-b / a);
        if (a == 0)
        {
            Console.Write("\nLa ecuacion no tiene solucion\n\n\n\n\n");
        }
        else if (x == 0)
        {
            Console.Write("\nLa ecuacion tiene infinitas soluciones\n\n\n\n\n");
        }
        else
        {
            Console.WriteLine($"\nEl resultado Unico es: {x}\n\n\n\n\n");
        }
    }
}