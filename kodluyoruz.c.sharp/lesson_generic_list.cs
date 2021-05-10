using System;
using System.Collections.Generic;

namespace kodluyoruz.c.sharp
{
    public class lesson_generic_list
    {
        public void example()
        {
            List<int> numberList = new List<int>();
            numberList.Add(23);
            numberList.Add(4);
            numberList.Add(5);
            numberList.Add(92);
            numberList.Add(34);

            List<string> colorList = new List<string>();
            colorList.Add("Kırmızı");
            colorList.Add("Mavi");
            colorList.Add("Sarı");


            Console.WriteLine(numberList.Count);
            Console.WriteLine(colorList.Count);

            numberList.Remove(3);
            colorList.Remove("Sarı");

            numberList.RemoveAt(0);
            colorList.RemoveAt(1);

            numberList.ForEach(Console.WriteLine);
            colorList.ForEach(Console.WriteLine);


            if(numberList.Contains(5))
                Console.WriteLine("5 founded");

            Console.WriteLine(colorList.BinarySearch("Sarı"));


            colorList.Clear();


            string[] animals = new[] {"at", "arı", "ayı"};
            List<string> strAnimals = new List<string>(animals);



            List<User> users = new List<User>();
            users.Add(new User()
            {
                age = 2,
                name = "naaame",
                surname = "suuurrrnameee"
            });
        }
    }

    public class User
    {
        public string name { get; set; }
        public string surname { get; set; }
        public int age { get; set; }
    }
}