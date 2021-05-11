using System;

namespace kodluyoruz.c.sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine($"Çalışan sayısı: {static_lesson_calisan._calisanSayisi}");
            var calisan = new static_lesson_calisan("samet", "can", "muh");
            Console.WriteLine($"Çalışan sayısı: {static_lesson_calisan._calisanSayisi}");

        }
    }
}
