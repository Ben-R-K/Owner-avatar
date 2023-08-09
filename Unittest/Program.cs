

namespace Unittest 
{
    public class Program
    {
        static void Main(string[] args)
        {
            TaskClass taskclass= new TaskClass();
            Console.WriteLine("Hello World!");

            int TwinCount = taskclass.TwinNumberCounter();
            Console.WriteLine((TwinCount));

           bool Triplets = taskclass.Triplets();
            Console.WriteLine((Triplets));

            List<int> primenumbers= new List<int>();
            primenumbers = taskclass.TheseventhofEratosthenes(30);

            foreach(int i in primenumbers)
            {
                Console.WriteLine(i);
            }

            List<string> strings = new List<string>();
            strings = taskclass.HashFilter();
        }
    }
}