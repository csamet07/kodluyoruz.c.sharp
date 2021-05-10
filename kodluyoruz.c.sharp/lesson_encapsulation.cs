using System;

namespace kodluyoruz.c.sharp
{
    public class lesson_encapsulation
    {
        public void example()
        {
            var ogrenci = new student();

            ogrenci.Name = "samet";
            ogrenci.SurName = "can";
            ogrenci.Class = 5;
            ogrenci.Number = 654;

            ogrenci.getStudentDetails();
        }
    }
    public class student
    {
        private string _name;
        private string _surname;
        private int _number;
        private int _class;

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string SurName
        {
            get => _surname;
            set => _surname = value;
        }

        public int Number
        {
            get => _number;
            set => _number = value;
        }
        public int Class
        {
            get => _class;
            set
            {
                if (value < 1)
                {
                    Console.WriteLine("sınıf 1'den küçük olamaz");
                    _class = 1;
                }
                else
                {
                    _class = value;
                }
            }
        }

        public student(string name, string surname, int number, int class_)
        {
            this.Name = name;
            this.SurName = surname;
            this.Number = number;
            this.Class = class_;
        }
        public student()
        {
            
        }

        public void getStudentDetails()
        {
            Console.WriteLine("Öğrenci Adı: " + this.Name);
            Console.WriteLine("Öğrenci Soyadı: " + this.SurName);
            Console.WriteLine("Öğrenci Numarası: " + this.Number);
            Console.WriteLine("Öğrenci Sınıfı: " + this.Class);
        }

        public void upClass()
        {
            this.Class += 1;
        }
        public void downClass()
        {
            this.Class -= 1;
        }
    }
}