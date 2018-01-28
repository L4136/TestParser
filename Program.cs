using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestParser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna haluamasi lukujono merkkijonona, luvut pilkulla eroteltuina: ");
            string syote = Console.ReadLine();
            int count = ItParser.Count(syote);
            int sum = ItParser.Sum(syote);
            int average = ItParser.Average(syote);
            Console.WriteLine("Merkkijonossa " + syote +" on " + count + " lukua. Lukujen summa on " + sum +" ja keskiarvo on " + average +".");
        }
    }
}
