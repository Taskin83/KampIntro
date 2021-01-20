using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya başlangıç için tmel kurs";
            string kurs3 = "java";
            string kurs4 = "python";

            string[] kurslar = new string[] 
            { "Yazılım Geliştirici Yetiştirme Kampı",
              "Programlamaya başlangıç için tmel kurs","java","Python","C#" };

            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
