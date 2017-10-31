using System;
using System.Collections.Generic;

namespace CSharp7._0
{
    public class Program
    {
        private static void Main(string[] args)
        {
            OutParameter();

            Tuples();

            var listOfObjects = new List<object>
            {
                23,
                "house",
                false,
                42,
                42.42
            };

            PatternMatching(listOfObjects);

            NumericLiteralImprovements();
        }

        private static void OutParameter()
        {
            // pre C# 7.0
            string outMessage;
            OldOutParamter(out outMessage);

            Console.WriteLine(outMessage);

            // new out parameter
            NewOutParamter(out string newMessage);

            Console.WriteLine(newMessage);
        }

        private static void OldOutParamter(out string outMessage)
        {
            outMessage = "Old out Message";
        }

        private static void NewOutParamter(out string newMessage)
        {
            newMessage = "New out Message";
        }

        private static void Tuples()
        {
            var name = GetTupleReturnValue();

            Console.WriteLine($"Hello {name.firstName} {name.lastName}");
        }

        private static (string firstName, string lastName) GetTupleReturnValue()
        {
            return ("Wolfgang", "Ofner");
        }

        private static void PatternMatching(IEnumerable<object> listOfObjects)
        {
            double sum = 0;

            foreach (var item in listOfObjects)
            {
                switch (item)
                {
                    case int val:
                        sum += val;
                        break;

                    case double val:
                        sum += val;
                        break;

                    case string val:
                        Console.WriteLine($"list contains string: {val}");
                        break;
                }
            }

            Console.WriteLine($"The sum is {sum}");
        }

        private static void NumericLiteralImprovements()
        {
            const int billion = 1_000_000_000;
            const int hex = 0x400_123;

            Console.WriteLine(billion);
            Console.WriteLine(hex);
        }
    }
}