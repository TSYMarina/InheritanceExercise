using System;
namespace Inheritance
{
    public class Animal
    {
        public bool HasFur { get; set; }
        public bool IsDomesticated { get; set; }
        public string Name { get; set; }
        public int NumberOfLegs { get; set; }


        public void Speak(string voice)
        {
           Console.WriteLine($"{voice}");
        }

    }
}
