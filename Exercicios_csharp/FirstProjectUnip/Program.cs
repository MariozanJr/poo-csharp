using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class Program
    {
        static void Main(String[] args)
        {

            Class1 p = new Class1 ();
            p.Attribute1 = 12.521;
            p.Attribute2 = 13;
            p.Attribute3 = "Any Product ";
           
            p.ViewAttribute();

            // Using Get Set 
            p.setAttribute3("Other Product");

            Console.WriteLine("Attribute3: "+ p.getAttribute3());


        }

    }
    
}
