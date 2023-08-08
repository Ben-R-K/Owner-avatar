

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
        }
    }
}