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

            hummingbird.name = "hummingbird";
            hummingbird.livesByWater = false;
            hummingbird.placeOfOrigin = "South America";
            hummingbird.colorOfFeathers = "green and gray";
            hummingbird.commonSize = 3;
            hummingbird.numberOfLegs = 2;
            
            Console.WriteLine($"We will be learning about some fascinating creatures today. The first one is {hummingbird.name}. These birds first originated in {hummingbird.placeOfOrigin} and are primarily {hummingbird.colorOfFeathers} color. Although when they move it may appear that they change colors and an attentive birdwatcher may see blue, purple and pink shades. \nThis is a smallest bird and their average size is {hummingbird.commonSize} inches.");
            Console.WriteLine("Their voice sounds like: ");
            hummingbird.Speak("\"chirp\"");

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            var kD = new Reptile();
                kD.name = "Komodo Dragon";
                kD.mainHabitat  = "Lesser Sunda Islands of Indonesia";
                kD.scalesColor = "yellow-gray";
                kD.maxLength = 10;

            Console.Write($"\n\nThe second one is {kD.name}.");
            Console.WriteLine($"They are remarkable because these are the largest reptiles and can reach {kD.maxLength} feet in length. They primarily are found in {kD.mainHabitat}.");

        }

    }
}
