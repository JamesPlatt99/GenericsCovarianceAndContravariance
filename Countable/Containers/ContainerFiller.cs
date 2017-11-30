using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericsCovarianceAndContravariance;

namespace GenericsCovarianceAndContravariance.Countable.Containers
{
    class ContainerFiller
    {
        public Box FillNewBox(int apples, int potatos, Things.Thing.Colours appleColour =  Things.Thing.Colours.Unknown, Things.Thing.Colours potatoColour = Things.Thing.Colours.Unknown)
        {
            Box box = new Box();
            box.Add(apples, Program.ThingTypes.Apple, appleColour);
            box.Add(potatos, Program.ThingTypes.Potato, potatoColour);
            return box;
        }

        public ICountable GetInstanceOfThing(Enum type, Things.Thing.Colours colour)
        {
            Things.Thing thing;
            switch (type)
            {
                case Program.ThingTypes.Apple:
                    thing = new Things.Apple(colour);
                    break;
                case Program.ThingTypes.Potato:
                    thing = new Things.Potato(colour);
                    break;
                default:
                    thing = null;
                    break;
            }
            return thing;
        }
    }
}
