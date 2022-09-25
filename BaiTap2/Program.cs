using System;

namespace BaiTap2
{
    class Program
    {
        static void Main(string[] args)
        {
            int chuvi = 0;
            int dientich = 1; 
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if(a > 0 && b > 0)
            {
                chuvi = (a + b) * 2;
                dientich = a * b;
                Console.WriteLine("chu vi hinh chu nhat la : " + chuvi);
                Console.WriteLine("dien tich hinh chu nhat la :" + dientich); 
            }
            else
            {
                Console.WriteLine("so khong hop le !!");
            }
        }
    }
}
