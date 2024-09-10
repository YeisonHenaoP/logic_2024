public class Program
{
    // YEISON DAVID HENAO PAREJA
    // YARITZA MISHELL SARMIENTO PINEDA
    private static void Main(string[] args)
    {
        double num1, num2, num3, mayor, medio, menor; ;
        Console.Write("Este programa ordena 3 números de mayor a menor\n");
        Console.Write("Igrese el primer número: ");
        num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Igrese el segundo número: ");
        num2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Igrese el tercer número: ");
        num3 = Convert.ToDouble(Console.ReadLine());
        if (num1 > num2 && num1 > num3)
        {
            mayor = num1;
            if (num2 > num3)
            {
                medio = num2;
                menor = num3;
            }
            else
            {
                medio = num3;
                menor = num2;
            }
        }
        else if (num2 > num1 && num2 > num3)
        {
            mayor = num2;
            if (num1 > num3)
            {
                medio = num1;
                menor = num3;
            }
            else
            {
                medio = num3;
                menor = num1;
            }
        }
        else
        {
            mayor = num3;
            if (num1 > num2)
            {
                medio = num1;
                menor = num2;
            }
            else
            {
                medio = num2;
                menor = num1;
            }
        }
        Console.WriteLine($"El número mayor es: {mayor}");
        Console.WriteLine($"El número medio es: {medio}");
        Console.WriteLine($"El número menor es: {menor}");
    }
}
