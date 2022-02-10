using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 99;
            string isim = "muhamme şahar";
            bool kar = 10 > 33;

            DateTime zaman = DateTime.Now;

            Console.WriteLine("değişkenlerimiz\n " + " \n "+ num + "\n  " + isim + "\n  " + kar + " \n " + zaman);
            Console.ReadKey();
        }
    }
}
