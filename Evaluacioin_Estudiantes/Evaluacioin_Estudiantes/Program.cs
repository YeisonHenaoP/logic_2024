public class Program
{
    private static void Main(string[] args)
    {
        bool continuar = true;

        while (continuar)
        {
            Console.Clear();
            Console.WriteLine("sistema de Evaluación de Notas de Estudiantes");
            int estudiantesGanaron = 0;
            int estudiantesPerdieron = 0;
            Console.Write("Ingrese la cantidad de estudiantes: ");
            int cantidadEstudiantes = int.Parse(Console.ReadLine());
            for (int i = 1; i <= cantidadEstudiantes; i++)
            {
                Console.WriteLine($"\nEstudiante {i}:");
                Console.Write("Ingrese la cantidad de notas del estudiante: ");
                int cantidadNotas = int.Parse(Console.ReadLine());
                double sumaNotas = 0;
                for (int j = 1; j <= cantidadNotas; j++)
                {
                    Console.Write($"Ingrese la nota {j}: ");
                    double nota = double.Parse(Console.ReadLine());
                    sumaNotas += nota;
                }
                double promedio = sumaNotas / cantidadNotas;
                Console.WriteLine($"Promedio del estudiante {i}: {promedio:F2}");
                if (promedio >= 4.5)
                {
                    Console.WriteLine("Categoría: Excelente");
                    estudiantesGanaron++;
                }
                else if (promedio >= 4.0 && promedio <= 4.4)
                {
                    Console.WriteLine("Categoría: Sobresaliente");
                    estudiantesGanaron++;
                }
                else if (promedio >= 3.5 && promedio <= 3.9)
                {
                    Console.WriteLine("Categoría: Bueno");
                    estudiantesGanaron++;
                }
                else
                {
                    Console.WriteLine("Categoría: Insuficiente");
                    estudiantesPerdieron++;
                }
            }
            Console.WriteLine("\nResumen:");
            Console.WriteLine($"Estudiantes que ganaron: {estudiantesGanaron}");
            Console.WriteLine($"Estudiantes que perdieron: {estudiantesPerdieron}");
            Console.Write("\n¿Desea ingresar otro grupo de estudiantes? (s/n): ");
            string respuesta = Console.ReadLine().ToLower();
            continuar = (respuesta == "s");
        }
    }
    }