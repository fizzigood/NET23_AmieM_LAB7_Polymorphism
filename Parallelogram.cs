using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET23_AmieM_LAB7_Polymorphism
{   //Klass som ärver från Geometry-klassen:

    class Parallelogram : Geometry
    {
        double Pbase { get; set; }
        double Pheight { get; set; }

        //Constructor för Parallellogram:
        public Parallelogram(double pbase = 1701, double pheight = 1337)    //Värdet av Egenskaperna/Properties sätts i constructorn:
        {
            this.Pbase = pbase;
            this.Pheight = pheight;
        }
        public override double Area()                                    //Override av basklassens metod med värden från Parallellogrammets egenskaper/properties:
        {
            area = Pbase * Pheight;
            return area;
        }
    }
}
