using System;

namespace BaiTap6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0; 
            if( n < 2)
            {
                Console.WriteLine("khong phai la so nguyen to !!!"); 
            }

            for(int i = 2; i <= Math.Sqrt(n); i++)
            {
                if(n % i == 0)
                {
                    count++; 
                }
            }
            if(count == 0)
            {
                Console.WriteLine("n la so nguyen to");
            }
            else
            {
                Console.WriteLine("n khong phai la so nguyen to !!!"); 
            }
        }
    }
}
