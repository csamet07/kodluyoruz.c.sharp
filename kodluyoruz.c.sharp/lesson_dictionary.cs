using System;
using System.Collections.Generic;

namespace kodluyoruz.c.sharp
{
    public class lesson_dictionary
    {
        public void example()
        {
            Dictionary<int, string> users = new Dictionary<int, string>()
            {
                {10,"arda"}, 
                {12, "ahmet"}, 
                {18, "deniz"}
            };
            users.Add(20,"ozcan");

            Console.WriteLine(users[10]);
            Console.WriteLine(users.Count);
            Console.WriteLine(users.ContainsKey(10));
            Console.WriteLine(users.ContainsValue("deniz"));
            Console.WriteLine(users.Remove(12));

            foreach (var usersKey in users.Keys)
            {
                Console.WriteLine(usersKey);
            }
            foreach (var usersValue in users.Values)
            {
                Console.WriteLine(usersValue);
            }


        }
    }
}