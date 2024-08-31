public class Program
{
    //muestre las coordenadas de dos puntos y que muestre la distancia entre los dos puntos
    private static void Main(string[] args)
    {
        double x1, x2, y1, y2, d;
        Console.Write("por favor ingrese el valor de x1: ");
        x1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("por favor ingrese el valor de y1: ");
        y1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("por favor ingrese el valor de x2: ");
        x2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("por favor ingrese el valor de y2: ");
        y2 = Convert.ToDouble(Console.ReadLine());
        double x = (x2 - x1) * (x2 - x1);
        double y = (y2 - y1) * (y2 - y1);
        double suma = x + y;
        d = Math.Sqrt(suma);
        Console.Write("la distancia es: "+d);
    }
}