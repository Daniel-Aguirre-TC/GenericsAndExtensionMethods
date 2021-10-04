using System;
using System.Collections;
using System.IO;
using System.Linq;

namespace Generics
{
    class Program
    {
        //Generics
        //TODO Create a class called "Storage" that has a generic Type "T". Set a constraint to for the type so that T must conform to IStorable.
        //TODO In your class create a property List called "Bin". Set the list type to "T".
        //TODO Create two more classes. One class called "Boxes". The second class called "Food". Both classes will conform to IStoreable interface.
        //TODO create two instances of type Storage in the Main method. First Instance will hold type "<Equipment>". The second instance will hold "<food>".
        //TODO create some instanes of type Food and Equipment and Add them the correct storage bins.

        static void Main(string[] args)
        {

            var equipment = new Storage<Boxes>()
            {
                Bin = new System.Collections.Generic.List<Boxes>()
                {
                    new Boxes(), new Boxes(), new Boxes()
                }               
            };

            var food = new Storage<Food>(new Food[] { new Food(), new Food(), new Food() }.ToList());

            var numbers = new int[] { 12, 4, 6, 432, 5, 64, 123, 432, 123, 6435, 13, 543, 1, 4, 5 };

            Console.WriteLine(numbers.First());
            Console.WriteLine(numbers.SortArray().First());
            Console.ReadKey();

            var plural = new string[] { "word", "wall", "try", "spy", "fly" };
            Console.WriteLine();
            plural.ToList().ForEach(x =>
            {
                Console.WriteLine($"{x} when plural is {x.Pluralize()}\n");            
            });

            Console.ReadKey();

        }
      

        //ExtensionMethods
        //TODO Create a static class called "ExtensionMethods"
        //TODO in your new class create a static extension method called "pluralize" this method should take a string and add an s to the end of it.
        //
        //(***BONUS*** if string ends in y you can replace y with ies to pluralize it)

        //TODO Create an extension method called "SortArray". This method will take an array of type T. Then it will use a LINQ statement to OrderBy.
        //TODO call both extension methods in the Main. Use the method on the numbers Array.


    }
}
