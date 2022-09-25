using System;

namespace BaiTap1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            // a 
            if(n % 2 == 0)
            {
                Console.WriteLine("n la so chan");
            }
            else
            {
                Console.WriteLine("n la so le"); 
            } 

            if(n > 0)
            {
                Console.WriteLine("n la so duong");
            }
            else
            {
                Console.WriteLine("n la so am"); 
            }
        }
    }
}
