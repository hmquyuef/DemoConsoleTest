using System;

namespace DemoConsole
{

    class Program
    {
        //o day
        public static float TinhTong(float A, float B , float C = 5.0f)
        {
            return A + B + C;
        }
        public static void TinhTong(int A, int B, out int S)
        {
            S = A + B;
        }
        static void Main(string[] args)
        {
            float a = 10, b = 6, c = 8;

            float s1 = TinhTong(a, b, c);
            float s2 = TinhTong(a, b);

            Console.WriteLine(s1);

            Console.WriteLine(s2);

            Console.ReadKey();
        }
        //o day
    }
}
