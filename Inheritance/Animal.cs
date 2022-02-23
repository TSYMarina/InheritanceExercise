using System;
namespace Inheritance
{
    public class Animal
    {
        public Animal()
        {

        }

        public bool hasFur { get; set; }
        public bool isDomesticated { get; set; }
        public string name { get; set; }
        public int numberOfLegs { get; set; }


        public void Speak(string voice)
        {
           Console.WriteLine($"{voice}");
        }

    }
}
