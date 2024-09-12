using System;

public class Program
{
    private static void Main(string[] args)
    {
        //9. Construir un programa que pida por pantalla 3 números
        //y luego diga cuál es el mayor de los números ingresados.
        int num1, num2, num3, mayor;
        Console.Write("Este Algoritmo encuentra el mayor número entre 3 números introducidos por teclado \nEmpecemos...\n");
        Console.Write("Introduzca el primer número entero :");
        num1=Convert.ToInt32(Console.ReadLine());
        Console.Write("Introduzca ahora el segundo número entero :");
        num2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Por último introduzca tercer número entero :");
        num3 = Convert.ToInt32(Console.ReadLine());
        if (num1 == num2 && num1 == num3 && num2 == num3)
        {
            Console.Write("\n¡Introduzca numeros diferentes gonorrea!\n");
            Console.Write("         ¡Trateme serio!\n\n\n\n");
        }
        else
        {
            if (num1 >= num2 && num1 >= num3)
            {
                mayor = num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                mayor = num2;
            }
            else
            {
                mayor = num3;
            }
            Console.Write($"\n¡El número mayor es!: {mayor}\n\n\n\n");
        }
    }
}