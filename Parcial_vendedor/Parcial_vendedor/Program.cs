public class Program
{
    private static void Main(string[] args)
    {
        decimal sueldoBase, venta1, venta2, venta3, com1, com2, com3, comTotal, SueldoTotal, ventaMayor, bono, promComisiones, totalVentas;
        Console.Write("Por favor inserte el salario base: ");
        sueldoBase = Convert.ToDecimal(Console.ReadLine());
        Console.Write("A continuacion ingrese el valor de las ventas del mes\nVenta 1: ");
        venta1 = Convert.ToDecimal(Console.ReadLine());
        Console.Write("\nVenta 2: ");
        venta2 = Convert.ToDecimal(Console.ReadLine());
        Console.Write("\nVenta 3: ");
        venta3 = Convert.ToDecimal(Console.ReadLine());
        com1 = (venta1 * 10) / 100;
        com2 = (venta2 * 10) / 100;
        com3 = (venta3 * 10) / 100;
        comTotal = com1 + com2 + com3;
        SueldoTotal = sueldoBase + comTotal;
        Console.Write($"\nDe comisiones recibirás en Total:{comTotal}");
        if (venta1 > venta2 && venta1 > venta3)
        {
            ventaMayor = venta1;
        }
        else if (venta2 > venta1 && venta2 > venta3)
        {
            ventaMayor = venta2;
        }
        else
        {
            ventaMayor = venta3;
        }
        promComisiones = (com1 + com2 + com3) / 3;
        totalVentas = venta1 + venta2 + venta3;
        if (totalVentas > 1000000)
        {
            bono = 100000;
            Console.Write($"¡Felicidades alcanzaste el bono extra!\ntu sueldo total con el bono y las comisiones es {(SueldoTotal + bono):C0}");
        }
        else
        {
            Console.Write($"No alcanzaste el bono =( \nasí que tu sueldo total con las comisiones es: {(SueldoTotal):C0}");
        }
    }
}