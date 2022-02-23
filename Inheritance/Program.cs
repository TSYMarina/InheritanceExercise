using System;

namespace Inheritance
{
    class Program
    {
        // TODO Be sure to follow best practice when creating your classes

        // Create a class Animal - done
        // give this class 4 members that all Animals have in common - done


        // DONE Create a class Bird 
        //      give this class 4 members that are specific to Bird 
        //      Set this class to inherit from your Animal Class


        // DONE Create a class Reptile
        //      give this class 4 members that are specific to Reptile
        //      Set this class to inherit from your Animal Class


        /*Create an object of your Bird class
         *  give values to your members using the object of your Bird class
         *  
         * Creatively display the class member values 
         */

        static void Main(string[] args)
        {
            var hummingbird = new Birds();

            hummingbird.Name = "hummingbird";
            hummingbird.LivesByWater = false;
            hummingbird.PlaceOfOrigin = "South America";
            hummingbird.ColorOfFeathers = "green and gray";
            hummingbird.CommonSize = 3;
            hummingbird.NumberOfLegs = 2;
            
            Console.WriteLine($"We will be learning about some fascinating creatures today. The first one is {hummingbird.Name}. These birds first originated in {hummingbird.PlaceOfOrigin} and are primarily {hummingbird.ColorOfFeathers} color. Although when they move it may appear that they change colors and an attentive birdwatcher may see blue, purple and pink shades. \nThis is a smallest bird and their average size is {hummingbird.CommonSize} inches.");
            Console.WriteLine("Their voice sounds like: ");
            hummingbird.Speak("\"chirp\"");

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            var kD = new Reptile();
                kD.Name = "Komodo Dragon";
                kD.MainHabitat  = "Lesser Sunda Islands of Indonesia";
                kD.ScalesColor = "yellow-gray";
                kD.MaxLength = 10;

            Console.Write($"\n\nThe second one is {kD.Name}.\n");
            kD.ReptileCard();

        }

    }
}
