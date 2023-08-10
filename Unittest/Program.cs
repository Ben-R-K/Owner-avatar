

namespace Unittest 
{
    public class Program
    {
        static void Main(string[] args)
        {
            TaskClass taskclass= new TaskClass();
            Console.WriteLine("Hello World!");
            int[] Bigints = { 190, 291, 145, 209, 280, 200 };
            Console.WriteLine(taskclass.NumberSelecter(Bigints));

            int[] Twinints = { 1, 3, 7, 7, 5, 3, 2, 2, 2, 2 };
            int TwinCount = taskclass.TwinNumberCounter(Twinints);
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

            foreach(string s in strings)
            {
                Console.WriteLine(s);
            }
        }
    }
}