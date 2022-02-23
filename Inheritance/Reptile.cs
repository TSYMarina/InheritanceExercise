using System;
namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile()
        {

        }

        public string MainHabitat;
        public string ScalesColor;
        public int MaxLength;

        public void ReptileCard()
        {
            Console.WriteLine($"Main Habitat: {MainHabitat}, \nPrimary Color: {ScalesColor},\nMax Size: {MaxLength} feet.");
        }

    }
}
