using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class MyArray
    {
        public int Length { get; set; }
        public List<string> StringData { get; set; }

        public MyArray()
        {
            Length = 0;
            StringData = new List<string>();
        }

        public string Get(int index)
        {
            return StringData[index];
        }

        public int Push(string item)
        {
            StringData[Length] = item;
            Length++;
            return Length;
        }
    }
}
