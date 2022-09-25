using System;

namespace BaiTap3
{
    class Program
    {
        static void Main(string[] args)
        {
            // giai phuong trinh bac nhat 
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int x; 

            if(a == 0 && b != 0)
            {
                Console.WriteLine("phuong trinh vo nghiem");
            }
            else if(b == 0)
            {
                Console.WriteLine("phuong trinh co vo so nghiem");
            }
            else
            {
                x = -b / a;
                Console.WriteLine("nghiem cua phuong trinh la :" + x); 
            }
        }
    }
}
