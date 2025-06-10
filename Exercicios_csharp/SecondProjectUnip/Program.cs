using System;
using System.Xml.Linq;

namespace SecondProject
{
    public class Class1
    {

        private double _Attribute1;
        private int _Attribute2;
        private string? _Attribute3;


        public Class1() 
        {
        }

        public Class1(double Attribute1, int Attribute2, string? Attribute3)
        {

            _Attribute1 = Attribute1;
            _Attribute2 = Attribute2;
            _Attribute3 = Attribute3;

        }


        public void ViewAttribute()
        {

            Console.WriteLine("Attribute1: " + _Attribute1);
            Console.WriteLine("Attribute2: " + _Attribute2);
            Console.WriteLine("Attribute3: " + _Attribute3);

        }

    }
}