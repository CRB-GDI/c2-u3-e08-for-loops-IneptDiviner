using System.Runtime.ExceptionServices;

namespace Exercise8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine ("Please enter a whole number to be the maximum");
            int count = 0;
            int n = int.Parse(Console.ReadLine());


            for (count = 0; count <= n; count+=2)
            {
              Console.WriteLine(count);
            }
        }
    }
}