using System;
using System.Collections.Generic;
using System.Linq;

namespace linq
{
    class Program
    {
        static void Main(string[] args)
        {
            // Order these student names alphabetically, in descending order (Z to A)
            List<string> names = new List<string>()
            {
                "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
                "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
                "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
                "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
                "Francisco", "Tre"
            };

            var descend = names.OrderByDescending(name => name);
            foreach(var name in descend)
            {
                // Console.WriteLine(name);
            }


            // Build a collection of these numbers sorted in ascending order
            List<int> numbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            var sortedNumbers = numbers.OrderBy(num => num);

            foreach(var num in sortedNumbers)
            {
                // Console.WriteLine(num);
            }


            // Output how many numbers are in this list
            List<int> numbersTwo = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };
            // var finalCount = numbersTwo.Aggregate(0, (count, number) => number.Length);
            int finalCount = numbersTwo.Sum();
            Console.WriteLine(finalCount);

            List<double> purchases = new List<double>()
            {
                2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
            };

            var total = purchases.Sum();
            Console.WriteLine(total);
        }
    }
}
