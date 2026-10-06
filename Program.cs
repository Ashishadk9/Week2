using System;
using System.Collections.Generic;

namespace VariablesAndDatatypes
{
    class Program
    {
        static void Main()
        {
            // ---- Task 1: variables and interpolated strings ----

            // TODO 1: declare a variable called userName that holds your name.
            //         Text needs the type string.
            string userName = "Ram";

            // TODO 2: declare a variable called luckyNumber holding your
            //         favourite single-digit number. A whole number is int.
            int luckyNumber = 7;

            // TODO 3: print ONE line that reads exactly:
            //         Hello, <your name>! Your lucky number is <the number>.
            //         Use string interpolation, not the + operator,
            Console.WriteLine($"Hello, Ram! Your lucky number is 7");
            // ---- Task 2: constants ----

            // TODO 2: create a Circle object and print Circle.PI.
            Circle circle = new Circle();
            Console.WriteLine($"Circle PI: {Circle.PI}");

            // TODO 3: (Deleted line: Circle.PI = 3.15; -> Triggered CS0131 because constants cannot be reassigned)


            // ---- Task 3: data types and type conversion ----


            byte tiny = 200;
            short small = 30000;

            // TODO 4: declare one variable for each specified type.
            int normalNumber = 100000;
            long largeNumber = 9000000000L;
            float singlePrecision = 3.14f;
            double doublePrecision = 3.1415926535;
            decimal price = 19.99m;
            char initial = 'A';
            bool isActive = true;

            // TODO 5: convert the number 42 into a string.
            string numberAsString = 42.ToString();

            // TODO 6: convert the string "3.14" into a double.
            double parsedDouble = double.Parse("3.14");

            // Model output lines
            Console.WriteLine($"byte   = {tiny} (type: byte)");
            Console.WriteLine($"short  = {small} (type: short)");

            // TODO 7: print one labelled line for each of the remaining variables.
            Console.WriteLine($"int    = {normalNumber}(type: int)");
            Console.WriteLine($"long   = {largeNumber}(type: long)");
            Console.WriteLine($"float  = {singlePrecision}(type: float)");
            Console.WriteLine($"double = {doublePrecision}(type: double)");
            Console.WriteLine($"decimal= {price}(type: decimal)");
            Console.WriteLine($"char   = {initial}(type: char)");
            Console.WriteLine($"bool   = {isActive}(type: bool)");
            Console.WriteLine($"strNum = {numberAsString}(type: string)");
            Console.WriteLine($"parsed = {parsedDouble}(type: double)");


            // ---- Task 4: arrays and Array methods ----

            int[] numbers = { 42, 7, 19, 3, 88 };

            // TODO 8: print numbers in original order on one line.
            Console.WriteLine($"Original : {string.Join(", ", numbers)}");

            // TODO 9: sort ascending and print.
            Array.Sort(numbers);
            Console.WriteLine($"Sorted: {string.Join(", ", numbers)}");

            // TODO 10: reverse and print.
            Array.Reverse(numbers);
            Console.WriteLine($"Reversed: {string.Join(", ", numbers)}");

            // TODO 11: print each element with its index using a for loop.
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"[{i}] = {numbers[i]}");
            }

            // TODO 12: use Array.IndexOf to find positions of 19 and 100.
            int index19 = Array.IndexOf(numbers, 19);
            int index100 = Array.IndexOf(numbers, 100);
            Console.WriteLine($"IndexOf(19)  = {index19}");
            Console.WriteLine($"IndexOf(100) = {index100}");


            // ---- Task 5: DateTime and TimeSpan ----

            DateTime birthDate = new DateTime(2004, 3, 15);

            // TODO 13: declare DateTime for current date and time.
            DateTime today = DateTime.Now;

            // TODO 14: subtract birthDate from today to get ageSpan.
            TimeSpan ageSpan = today - birthDate;

            // TODO 15: calculate age in whole years.
            int years = (int)(ageSpan.TotalDays / 365.25);

            // TODO 16: print required details.
            Console.WriteLine($"Birth date : {birthDate:yyyy-MM-dd}");
            Console.WriteLine($"Today      : {today:yyyy-MM-dd}");
            Console.WriteLine($"Total days : {(int)ageSpan.TotalDays}");
            Console.WriteLine($"Age        : {years} years");
            Console.WriteLine($"Birth + 10 days : {birthDate.AddDays(10):yyyy-MM-dd}");


            // ---- Task 6: List<T> and Dictionary<K,V> ----

            List<string> fruits = new() { "Apple", "Mango", "Banana" };

            // TODO 17: add one fruit to the end of the list.
            fruits.Add("Orange");

            // TODO 18: remove one fruit from the list.
            fruits.Remove("Mango");

            // TODO 19: print every remaining fruit using foreach.
            foreach (string fruit in fruits)
            {
                Console.WriteLine($"{fruit}");
            }

            // TODO 20: declare Dictionary<int, string> byId with keys 1, 2, 3.
            Dictionary<int, string> byId = new Dictionary<int, string>
            {
                { 1, "Apple" },
                { 2, "Mango" },
                { 3, "Banana" }
            };

            // TODO 21: add a fourth entry and print all pairs using foreach.
            byId.Add(4, "Orange");

            foreach (KeyValuePair<int, string> kvp in byId)
            {
                Console.WriteLine($" {kvp.Key} -> {kvp.Value}");
            }
        }

    }
}