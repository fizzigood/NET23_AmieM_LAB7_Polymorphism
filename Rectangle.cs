using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET23_AmieM_LAB7_Polymorphism
{   //Klass som ärver från Geometry-klassen:

    class Rectangle : Geometry               
    {
        //Klassens egna properties;

        double Rwidth { get; set; }
        double Rlength { get; set; }

        //Constructor för rektangel:
        public Rectangle(double rwidth = 13, double rlength = 42)        //Värdet av Egenskaperna/Properties sätts i constructorn:
        {
            this.Rwidth = rwidth;
            this.Rlength = rlength;
        }

        public override double Area()                                  //Metod som overridar baksklassens Area()-metod och returnerar en double - area.
        {
            area = Rwidth * Rlength;
            return area;
        }

    }
}
