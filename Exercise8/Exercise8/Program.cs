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

            int ast = 0;
            int a = int.Parse(Console.ReadLine());
            for (ast=0; ast<a; ast++)
            {
                Console.Write("*");
            }
        }
    }
}