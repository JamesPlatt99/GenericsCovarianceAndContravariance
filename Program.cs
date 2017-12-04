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
            ContainerFiller containerFiller = new ContainerFiller();

            List<Thing> things = new List<Thing> { new Apple(Apple.Colours.Green), new Apple(Apple.Colours.Green), new Apple(Apple.Colours.Red), new Potato(), new Potato(), new Potato() };
            List<Box> boxes = new List<Box> { containerFiller.FillNewBox(2, 4, Thing.Colours.Red), containerFiller.FillNewBox(0, 1), containerFiller.FillNewBox(1, 7, Thing.Colours.Green) };
            List<Cart> carts = new List<Cart> {
                new Cart(new List<Box> { containerFiller.FillNewBox(6, 1, Thing.Colours.Red), containerFiller.FillNewBox(5, 4), containerFiller.FillNewBox(4, 6) }),
                new Cart(new List<Box> { containerFiller.FillNewBox(2, 1), containerFiller.FillNewBox(3, 4), containerFiller.FillNewBox(5, 6) }),
                new Cart(new List<Box> { containerFiller.FillNewBox(1, 4), containerFiller.FillNewBox(2, 3), containerFiller.FillNewBox(5, 0) })
            };

            CountRules rules = new CountRules();

            Counter<Cart> cartRedApplesCounter = new Counter<Cart>(carts, rules.CountRedApples);            
            Counter<Cart> cartAllApplesCounter = new Counter<Cart>(carts, rules.CountApples);
            Counter<Box> boxCounter = new Counter<Box>(boxes, rules.CountAll);            
            Counter<Thing> thingRedAppleCounter = new Counter<Thing>(things, rules.CountRedApples);

            List<ICountable> counters = new List<ICountable> { cartRedApplesCounter, cartAllApplesCounter, boxCounter, thingRedAppleCounter };
            Counter<ICountable> counterCounter = new Counter<ICountable>(counters, rules.CountAll);
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

        public enum ThingTypes
        {
            Apple,
            Potato
        }
    }
}
