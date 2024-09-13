public class Program
{
    private static void Main(string[] args)
    {
        //11. La pizzería Bella Napoli ofrece pizzas vegetarianas y no vegetarianas
        //a sus clientes. Los ingredientes para cada tipo de pizza aparecen a continuación.
        //· Ingredientes vegetarianos: Pimiento y tofu.
        //· Ingredientes no vegetarianos: Peperoni, Jamón y Salmón.
        //Escribir un programa en C# que pregunte al usuario si quiere una pizza
        //vegetariana o no, y en función de su respuesta le muestre un menú con los
        //ingredientes disponibles para que elija. Solo se puede elegir un ingrediente además de la
        //mozzarella y el tomate que están en todas las pizzas.Al final se debe mostrar por pantalla
        //si la pizza elegida es vegetariana o no y todos los ingredientes que lleva.
        int NumEleccion, ingredienteVegano, ingredienteNormal;
        string ingV,ingN;
        string ingredientesFijos = "Mozzarella, Tomate";
        Console.Write("¡Bienvenido a la pizzeria Bella Napoli!\n\n" +
            "Primero elige una de las siguientes opciones:\n\n" +
            "1 si quieres una Pizza Vegetariana\n2 si quieres una Pizza Normal\n\nIngresa aquí tu eleccion:");
        NumEleccion=Convert.ToInt32(Console.ReadLine());
        if (NumEleccion == 1)
        {
            Console.Write("\nAhora Elige un ingrediente:\n1 Pimiento\n2 Tofu\n\nIngresa aquí tu eleccion:");
            ingredienteVegano = Convert.ToInt32(Console.ReadLine());
            if (ingredienteVegano == 1)
            {
                ingV = "Pimiento";
            }
            else
            {
                ingV = "Tofu";
            }
            Console.Write($"\nTu pizza queda así:\n{ingredientesFijos} y {ingV}\n\n\n\n\n");
        }
        else if (NumEleccion == 2)
        {
            Console.Write("\nAhora Elige un ingrediente:\n1 Peperoni\n2 Jamón\n3 Salmón\n\nIngresa aquí tu eleccion:");
            ingredienteNormal = Convert.ToInt32(Console.ReadLine());
            if (ingredienteNormal == 1)
            {
                ingN = "Peperoni";
            }
            else if (ingredienteNormal == 2)
            {
                ingN = "Jamón";
            }
            else
            {
                ingN = "Salmón";
            }
            Console.Write($"\nTu pizza queda así:\n{ingredientesFijos} y {ingN}\n\n\n\n\n");    
        }
        }
}