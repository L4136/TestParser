using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestParser
{
    class ItParser
    {
        //int Count(string syote);
        //int Sum(string syote);
        //int Average(string syote);

        public static int Count(string syote)
        {
            int count = 1;
            foreach (char x in syote)
            {
                if (x == ',') count++;
            }
            return count;
        }

        public static int Sum(string syote)
        {
            int sum = 0;
            int strInt = 0;
            List<string> stringNum = new List<string>();
            string charString = "";

            foreach (char y in syote)
            {
                //add char to temp string
                if (y != ',')
                {
                    charString += y;
                }
                //add temp string to list and clear temp string
                if (y == ',')
                {
                    stringNum.Add(charString);
                    charString = "";
                }
            }

            //list strings to int, sum ints
            stringNum.Add(charString);
            foreach (string e in stringNum)
            {
                strInt = int.Parse(e);
                sum += strInt;
                strInt = 0;
            }
            return sum;
        }

        public static int Average(string syote)
        {
            int elements = Count(syote);
            int sum = Sum(syote);
            int average = sum / elements;
            return average;
        }
    }
}
