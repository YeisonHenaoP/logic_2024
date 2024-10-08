public class Program
{
    private static void Main(string[] args)
    {
        bool jugarDeNuevo = true;
        while (jugarDeNuevo)
        {
            Console.Clear();
            Console.WriteLine("¡bienvenidos al juego 'Adivina el número'!");
            int numJugadores = 0;
            while (numJugadores < 2 || numJugadores > 4)
            {
                Console.Write("ingrese la cantidad de jugadores (entre 2 y 4): ");
                numJugadores = int.Parse(Console.ReadLine());
            }
            int rangoMax = 0;
            if (numJugadores == 2) rangoMax = 50;
            if (numJugadores == 3) rangoMax = 100;
            if (numJugadores == 4) rangoMax = 200;
            Random random = new Random();
            int numeroSecreto = random.Next(0, rangoMax + 1);
            Console.WriteLine($"Se ha generado un número secreto entre 0 y {rangoMax}. ¡Que comience el juego!");
            bool numeroAdivinado = false;
            int turno = 0;
            while (!numeroAdivinado)
            {
                int jugadorActual = (turno % numJugadores) + 1;
                Console.Write($"Jugador {jugadorActual}, ingrese su intento: ");
                int intento = int.Parse(Console.ReadLine());
                if (intento < numeroSecreto)
                {
                    Console.WriteLine("MAYOR");
                }
                else if (intento > numeroSecreto)
                {
                    Console.WriteLine("MENOR");
                }
                


    }
}