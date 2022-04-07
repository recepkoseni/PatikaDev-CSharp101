using System;
using System.Collections.Generic;

namespace Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<string> cumleal=new List<string>();
            List<string> cumle=new List<string>();
            cumleal.Add(Console.ReadLine());
            string[] harfler={"a","A","e","E","i","I","o","O","u","U"};
            
            for (int i = 0; i < cumleal.Count; i++)
            {
             for (int k = 0; k < harfler.Length; k++)
             {
                 if(cumleal[i].Contains(harfler[k]))
                 {
                     cumle.Add(harfler[k]);
                 }
             }   
            }
            Console.WriteLine("Unlu Harfler:");
            foreach (var item in cumle)
            {
             Console.Write(item+" ");   
            }
        }

    }
}
