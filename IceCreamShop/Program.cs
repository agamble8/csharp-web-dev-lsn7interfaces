using System;
using System.Collections.Generic;

namespace IceCreamShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Case menu = new Case();
            List<Flavor> availableFlavors = menu.Flavors;
            List<Cone> availableCones = menu.Cones;

            // TODO: Use a Comparer class to sort the 'flavors' array alphabetically by the 'name'
            //  field.
            //flavors before sorting
            Console.WriteLine("Unsorted flavors: ");
            foreach (Flavor item in availableFlavors)
            {
                Console.WriteLine(item.Name);
            }
           
            //comparer for flavors
            FlavorComparer comparer = new FlavorComparer();
            availableFlavors.Sort(comparer);
            //flavors after sorting
            Console.WriteLine("\nSorted flavors by allergen: ");
            foreach (Flavor item in availableFlavors)
            {
                Console.WriteLine(item.Name);
            }

            //cones before sorting
            Console.WriteLine("\nUnsorted cones: ");
            foreach (Cone item in availableCones)
            {
                Console.WriteLine(item.Name + ": $" + item.Cost);
            }

            //comparer for cones
            ConeComparer anotherComparer = new ConeComparer();
            availableCones.Sort(anotherComparer);

            //comparer for cones after sorting
            Console.WriteLine("\nSorted cones by price: ");
            foreach (Cone item in availableCones)
            {
                Console.WriteLine(item.Name + ": $" + item.Cost);
            }


            // TODO: Use a Comparator class to sort the 'cones' array in increasing order by the 'cost'
            //  field.

            // TODO: Print the 'flavors' and 'cones' lists (in a clear manner) to verify the sorting.
        }
    }
}
