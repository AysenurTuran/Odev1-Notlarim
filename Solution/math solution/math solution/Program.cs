using System;

namespace math_solution
{
    class Program
    {

        static void Main(string[] args)
        {
            Yeni inst = new Yeni();
            inst.birinci = 10;
            inst.ikinci = 20;
            int araUzaklik = 100;
            float araMesafe = araUzaklik * 0.62f;

            //10'un ikinci kuvveti
            //en küçük değer
            //mutlak değer 

            float one = -5.6f;
            float two = -2.8f;

            Console.WriteLine(araMesafe);
            Console.WriteLine(inst.birinci + inst.ikinci);
            Console.WriteLine(inst.toplama());
            Console.WriteLine(Math.Pow(10f, 3));
            Console.WriteLine(Math.Min(20 - 15, 10.5f));
            Console.WriteLine(Math.Abs(-24.5f + 12.5f));
            Console.WriteLine(Math.Abs(one * two));
            Console.WriteLine("Hello World!");
            Console.ReadLine();
            
        }
    }
    class Yeni
    {
        public int birinci;
        public int ikinci;
        public int toplama()
        {
            return birinci + ikinci;
        }
    }
}
