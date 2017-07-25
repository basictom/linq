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
            foreach (var name in descend)
            {
                // Console.WriteLine(name);
            }


            // Build a collection of these numbers sorted in ascending order
            List<int> numbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            var sortedNumbers = numbers.OrderBy(num => num);

            foreach (var num in sortedNumbers)
            {
                // Console.WriteLine(num);
            }


            // Output how many numbers are in this list
            List<int> numbersTwo = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            // Console.WriteLine(numbersTwo.Count);

            List<double> purchases = new List<double>()
            {
                2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
            };

            var total = purchases.Sum();
            // Console.WriteLine(total);

            Console.WriteLine("-----------");
            /*
                Store each number in the following List until a perfect square
                is detected.

                Ref: https://msdn.microsoft.com/en-us/library/system.math.sqrt(v=vs.110).aspx
            */
            List<int> wheresSquaredo = new List<int>()
            {
                66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
            };
            var runSquare = wheresSquaredo.TakeWhile(number => Math.Sqrt(number) % 1 != 0);
            foreach (var square in runSquare)
            {
                // Console.WriteLine(square);
            }

                        // Create some banks and store in a List
                List<Bank> banks = new List<Bank>() {
                    new Bank(){ Name="First Tennessee", Symbol="FTB"},
                    new Bank(){ Name="Wells Fargo", Symbol="WF"},
                    new Bank(){ Name="Bank of America", Symbol="BOA"},
                    new Bank(){ Name="Citibank", Symbol="CITI"},
                };

                // Create some customers and store in a List
                List<Customer> customers = new List<Customer>() {
                    new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
                    new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
                    new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
                    new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
                    new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
                    new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
                    new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
                    new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
                    new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
                    new Customer(){ Name="Sid Brown", Balance=49582.68, Bank="CITI"}
                };

                var millionaireReport = from x in customers
                where x.Balance >= 1000000
                group x.Name by x.Bank into z
                select new { Name = z, Bank = z.Key };

                foreach (var z in millionaireReport)
                {
                    Console.WriteLine($"{z.Bank}: {z.Name.Count()}");
                }

        }
    }
        public class Customer
        {
            public string Name { get; set; }
            public double Balance { get; set; }
            public string Bank { get; set; }
        }
        public class Bank
        {
            public string Symbol { get; set; }
            public string Name { get; set; }
        }
}
