using System;
using System.Collections.Generic;
using GenericsCovarianceAndContravariance.Countable;
using GenericsCovarianceAndContravariance.Countable.Containers;
using GenericsCovarianceAndContravariance.Countable.Things;

namespace GenericsCovarianceAndContravariance
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Thing> things = new List<Thing> { new Apple(), new Apple(), new Apple(), new Potato(), new Potato(), new Potato() };
            List<Box> boxes = new List<Box> { CreateNewBox(2, 4), CreateNewBox(0, 1), CreateNewBox(1, 7) };
            List<Cart> carts = new List<Cart> {
                new Cart(new List<Box> { CreateNewBox(6, 1), CreateNewBox(5, 4), CreateNewBox(4, 6) }),
                new Cart(new List<Box> { CreateNewBox(2, 1), CreateNewBox(3, 4), CreateNewBox(5, 6) }),
                new Cart(new List<Box> { CreateNewBox(1, 4), CreateNewBox(2, 3), CreateNewBox(5, 0) })
            };

            Counter<Cart> cartCounter = new Counter<Cart>(carts);            
            Counter<Box> boxCounter = new Counter<Box>(boxes);            
            Counter<Thing> thingCounter = new Counter<Thing>(things);

            List<ICountable> counters = new List<ICountable> { cartCounter, boxCounter, thingCounter };
            Counter<ICountable> counterCounter = new Counter<ICountable>(counters);
            counters.Add(counterCounter);

            DisplayCounts(counters);

            Console.ReadLine();
        }

        private static void DisplayCounts(List<ICountable> counts)
        {
            foreach (ICountable counter in counts)
            {
                Console.WriteLine(counter.Count);
            }
        }

        private static Box CreateNewBox(int apples, int potatos)
        {
            Box box = new Box();
            box.Add(apples, ThingTypes.Apple);
            box.Add(potatos, ThingTypes.Potato);
            return box;
        }

        public enum ThingTypes
        {
            Apple,
            Potato
        }
    }
}
