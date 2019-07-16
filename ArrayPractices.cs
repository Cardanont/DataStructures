using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructures
{
    class ArrayPractices
    {

        // Create a method that reverses a string

        public void ReverseString(string normal)
        {

            if (string.IsNullOrEmpty(normal) || normal.Length < 2 ||  normal.GetType() != typeof(string))
            {
                Console.WriteLine("Hmmm something is not good my friend");
            }

            string[] splited = normal.Split();
            List<string> reversed = new List<string>();


            int totalItems = normal.Split().Length - 1;

            for (int i = totalItems; i >= 0; i--)
            {
                reversed.Add(splited[i]);
            }

            foreach (var item in reversed)
            {
                Console.Write(item + " ");
            }
        }
    }
}
