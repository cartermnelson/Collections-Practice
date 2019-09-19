using System;
using System.Collections.Generic;

namespace CollectionsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numarr = new int[10];
            for (int i = 0; i < numarr.Length; i++)
            {
                numarr[i] = i;
            }

            string[] stringarr = { "Tim", "Martin", "Nikki", "Sara" };

            bool[] boolarr = new bool[10];
            for (int i = 0; i < boolarr.Length; i++)
            {
                if (i % 2 == 0 || i == 0)
                {
                    boolarr[i] = true;
                }
                else
                {
                    boolarr[i] = false;
                }
            }

            List<string> flavors = new List<string>();
            flavors.Add("Vanilla");
            flavors.Add("Chocolate");
            flavors.Add("Strawberry");
            flavors.Add("Cookies and Cream");
            flavors.Add("Rocky Road");
            Console.WriteLine(flavors.Count);
            Console.WriteLine(flavors[2]);
            flavors.RemoveAt(3);
            Console.WriteLine(flavors.Count);

            Dictionary<string, string> dict = new Dictionary<string, string>();
            Random rand = new Random();
            foreach (var name in stringarr)
            {
                dict.Add(name, flavors[rand.Next(0, flavors.Count - 1)]);
            }
        }
    }
}
