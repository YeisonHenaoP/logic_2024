public class Program
{
    private static void Main(string[] args)
    {
        decimal sueldoBase, venta1, venta2, venta3, com1, com2, com3, comTotal;
        Console.Write("Por favor inserte el salario base: ");
        sueldoBase = Convert.ToDecimal(Console.ReadLine());
        Console.Write("A continuacion ingrese el valor de las ventas del mes\nVenta 1: ");
        venta1= Convert.ToDecimal(Console.ReadLine());
        Console.Write("\nVenta 2: ");
        venta2 = Convert.ToDecimal(Console.ReadLine());
        Console.Write("\nVenta 3: ");
        venta3 = Convert.ToDecimal(Console.ReadLine());
        com1 = (venta1 * 10) / 100;
        com2 = (venta2 * 10) / 100;
        com3 = (venta3 * 10) / 100;
        comTotal = com1 + com2 + com3;
    }
}