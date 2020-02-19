using System;
using System.Collections.Generic;

namespace ListCollections
{
    class ListSyntax
    {
        static void Main(string[] args)
        {
            var numbersList = new List<int>() { 6, 9, 4, 2, 6 };
            numbersList.Add(3); //Add a new value into the list at the last index
            numbersList.Add(-3);
            numbersList.Add(9);

            //For each number "n" in the list, console writes the value 
            Console.Write("Return the numbers in a list: ");
            foreach (var n in numbersList)
            {
                Console.Write($"{n}, ");
            }

            numbersList.Insert(2, 4); //Inserts the value 4 at the index 

            numbersList.Reverse(); //Reverses the order of the list

            //Takes multiple instances of the declared value "4" and returns the last index of that value
            var lastIn = numbersList.LastIndexOf(4); 
            Console.WriteLine(lastIn);

            numbersList.Remove(3); //Removes the value at index 3
        }
    }
}
