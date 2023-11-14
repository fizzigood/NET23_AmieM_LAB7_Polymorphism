using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET23_AmieM_LAB7_Polymorphism
{   //Klass som ärver från Geometry-klassen:

    class Square : Geometry
    {


            //Fyrkantens area = length * length,
            //därför behövs bara en property/egenskap - Length, utöver den ärvda - Area:
            double Flength { get; set; }

            //Constructor för fyrkant:
            public Square(double flength = 42)     //Värdet av Egenskapen/Property sätts i constructorn:
            {
                this.Flength = flength;
            }
            public override double Area()        //Override av basklassens metod, med värden från Fyrkantens egenskaper/properties;
            {
                area = Flength * Flength;
                return area;
            }
        
    }
}
