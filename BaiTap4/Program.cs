using System;

namespace BaiTap4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int x1, x2, delta;
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("phuong trinh tro thanh phuong trinh bac nhat");
            }
            else if (a == 0 && b == 0 && c != 0)
            {
                Console.WriteLine("phuong trinh vo nghiem");
            }
            else if (a == 0 && b == 0 && c == 0)
            {
                Console.WriteLine("phuong trinh co vo so nghiem");
            }
            else
            {
                delta = b * b - 4 * a * c;
                if (delta < 0)
                {
                    Console.WriteLine("phuong trinh vo nghiem");
                }
                else if (delta == 0)
                {
                    x = -b / (2 * a);
                    Console.WriteLine("phuong trinh co nghiem kep la : " + x);
                }
                else
                {
                    x1 = (int)(-b + Math.Sqrt(delta)) / (2 * a);
                    x2 = (int)(-b + Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("nghiem thu nhat la :" + x1);
                    Console.WriteLine("nghiem thu hai la : " + x2);
                }
            }
        }
    }
}

