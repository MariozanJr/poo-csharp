using System;
using System.Xml.Linq;

namespace FirstProject
{
    public class Class1
    {

        public double Attribute1;
        public int Attribute2;
        public string? Attribute3;

        public void ViewAttribute()
        {

            Console.WriteLine("Attribute1: " + Attribute1);
            Console.WriteLine("Attribute2: " + Attribute2);
            Console.WriteLine("Attribute3: " + Attribute3);

        }

        public string getAttribute3()
        {
            return Attribute3;
        }
        public void setAttribute3(string attribute3)
        {
            Attribute3 = attribute3;
        }
    }
}