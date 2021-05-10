using System;
using System.Collections;
using System.Collections.Generic;

namespace kodluyoruz.c.sharp
{
    public class lesson_array_list
    {
        public void example()
        {
            var arrayList = new ArrayList();


            arrayList.Add("samet");
            arrayList.Add(2);
            arrayList.Add(true);
            arrayList.Add('A');

            Console.WriteLine(arrayList[0]);
            foreach (var o in arrayList)
            {
                Console.WriteLine(o);
            }

            var colors = new List<string> {"blue", "red", "purpler"};
            arrayList.AddRange(colors);
            arrayList.Sort();

            Console.WriteLine(arrayList.BinarySearch("blue"));

            arrayList.Reverse();
            arrayList.Clear();
        }
    }
}