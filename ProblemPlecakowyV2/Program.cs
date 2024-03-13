namespace ProblemPlecakowyV2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Podaj ilosc przedmiotow:");
            int val = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj seeda:");
            int seed = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj pojemnosc plecaka: ");
            int capacity = int.Parse(Console.ReadLine());

            Problem problem = new Problem(val, seed);

            problem.Solve(capacity);
        }
    }
}