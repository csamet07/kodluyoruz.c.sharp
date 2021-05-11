using System;

namespace kodluyoruz.c.sharp
{
    public class lesson_enum
    {
        public void example()
        {
            Console.WriteLine(gunler.çarşamba);
            Console.WriteLine((int)gunler.cuma);

            int sicaklık = 32;

            if (sicaklık <= (int)hava_durumu.normal)
            {
                Console.WriteLine("ısınmasını bekle");
            } else if (sicaklık <= (int)hava_durumu.sıcak)
            {
                Console.WriteLine("hava sıcak");
            }else if (sicaklık <= (int)hava_durumu.çok_sıcak)
            {
                Console.WriteLine("çıkabilirsin");
            }
        }
    }

    enum gunler
    {
        pazartesi = 1,
        salı,
        çarşamba,
        perşembe,
        cuma,
        cumartesi,
        pazar
    }

    enum hava_durumu
    {
        soguk = 5,
        normal = 20,
        sıcak = 25,
        çok_sıcak = 30
    }
}