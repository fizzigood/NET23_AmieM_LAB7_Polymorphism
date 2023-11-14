using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET23_AmieM_LAB7_Polymorphism
{   //Klass som ärver från Geometry-klassen:

    class Circle : Geometry
    {
        double Pi { get; set; }
        double Cradius { get; set; }

        //Constructor för Cirkel:
        public Circle(double pi = Math.PI, double cradius = 42)         //Värdet av Cirkelns Egenskaper/Properties sätts i constructorn:
        {
            this.Pi = pi;
            this.Cradius = cradius;
        }
        public override double Area()                               //Override av basklassens abstracta metod med värden från Cirkelns egenskaper/properties.
        {
            area = Pi * Cradius * Cradius;
            return area;
        }
    }
}
