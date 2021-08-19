using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Variables1
{
    class Program
        {
            static void Main(string[] args)
            {
                string name = "Chris Bradley";
                int year = 2021;
                char letter = 'Y';
                bool isFunny = true;
                double rate = 7.5;
                decimal pay = 75.00m;

                Console.WriteLine($"{name}, who joined TrueCoders in {year}; reasons {letter}, who knows. " +
                    $"{isFunny}, he is funny; though his humor is on a rate of {rate} on the rediculous scale. " +
                    $"Though, he does pay each of us {pay} par hour to laugh at his jokes.");
            }
    }
}