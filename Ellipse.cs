using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET23_AmieM_LAB7_Polymorphism
{   //Klass som ärver från Geometry-klassen:
    class Ellipse : Geometry
    {
        double Pi { get; set; }
        double Minor { get; set; }
        double Major { get; set; }

        //Constructor för Ellips:
        public Ellipse(double pi = Math.PI, double minor = 13, double major = 42)        //Värdet av Egenskaperna/Properties sätts i constructorn:
        {
            this.Pi = pi;
            this.Minor = minor / 2;
            this.Major = major / 2;
        }
        public override double Area()        //Override av basklassens metod, med värden från Ellipsens egenskaper/properties:
        {
            area = Pi * Minor * Major;
            return area;
        }
    }
}
