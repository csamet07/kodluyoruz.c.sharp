using System;

namespace kodluyoruz.c.sharp
{
    public class lesson_static_class
    {
        
    }

    public class static_lesson_calisan
    {
        private static int calisanSayisi;
        public static int _calisanSayisi { get => calisanSayisi; }
        private string Name;
        private string Surname;
        private string Departman;

        static static_lesson_calisan()
        {
            calisanSayisi = 0;
        }

        public static_lesson_calisan(string name, string surname, string departman)
        {
            this.Name = name;
            this.Surname = surname;
            this.Departman = departman;

            calisanSayisi++;
        }
    }
}