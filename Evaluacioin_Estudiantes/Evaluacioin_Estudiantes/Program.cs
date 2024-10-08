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
                

            }
        }