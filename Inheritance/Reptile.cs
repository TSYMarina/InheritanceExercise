using System;
namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile()
        {

        }

        public string mainHabitat;
        public string scalesColor;
        public int maxLength;

        public void ReptileCard()
        {
            Console.WriteLine($"live in {mainHabitat}, have {scalesColor} as a primary color and can reach {maxLength} feet in length.");
        }

    }
}
