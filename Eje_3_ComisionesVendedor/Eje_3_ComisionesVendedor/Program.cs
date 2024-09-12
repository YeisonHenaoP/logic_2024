public class Program
{
    private static void Main(string[] args)
    {
        //3. Un vendedor recibe un sueldo base más un 10% extra por comisión
        //de sus ventas, el vendedor desea saber cuánto dinero obtendrá por concepto
        //de comisiones por las tres ventas que realiza en el mes y el total que recibirá
        //en el mes tomando en cuenta su sueldo base y comisiones.
        decimal sueldoBase, venta1, venta2, venta3, totalComision, totalSueldo, totalVentas;
        Console.Write("Ingrese su sueldo base: ");
        sueldoBase = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Ingrese las 3 ventas del mes: ");
        Console.Write("Ingrese la venta 1: ");
        venta1 = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Ingrese la venta 2: ");
        venta2 = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Ingrese la venta 3: ");
        venta3 = Convert.ToDecimal(Console.ReadLine());
        totalVentas = venta1 + venta2 + venta3;
        totalComision = (totalVentas * 10)/100;
        totalSueldo=sueldoBase+totalComision;
        Console.WriteLine($"el total de comisiones por las ventas es de: {totalComision:C0}");
        Console.WriteLine($"el sueldo total sumando las comisiones es de: {totalSueldo:C0}");
    }
}