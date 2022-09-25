using System;

namespace BaiTap5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Console.WriteLine("chu nhat"); 
                break;
                case 2:
                    Console.WriteLine("thu hai");
                    break;
                case 3:
                    Console.WriteLine("thu ba");
                    break;
                case 4:
                    Console.WriteLine("thu tu");
                    break;
                case 5:
                    Console.WriteLine("cthu nam");
                    break;
                case 6:
                    Console.WriteLine("thu sau");
                    break;
                case 7:
                    Console.WriteLine("thu bay");
                    break;

                default :
                    Console.WriteLine("so nhap vao khong hop le");
                    break; 
            }
               
        }
    }
}
