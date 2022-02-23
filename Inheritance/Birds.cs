using System;
namespace Inheritance
{
    public class Birds : Animal
    {
        public Birds()
        {
        }

        public bool livesByWater { get; set; }
        public string placeOfOrigin { get; set; }
        public string colorOfFeathers { get; set; }
        public int commonSize { get; set; }
    }
}
