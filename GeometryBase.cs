using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET23_AmieM_LAB7_Polymorphism
{   //ParentClass Geometry:

    abstract class Geometry             //Väljer att ha en abstrakt "ParentClass" eftersom det är meningen att dess ärvande klasser ska implementera och/eller override(a) dess metoter.
    {                                  //... den innehåller inga egna värden, vilka istället sätts via de ärvande klasserna.

        protected double area { get; set; }         //Väljer protected eftersom jag endast vill att deriving classes ska ha access till att ändra värdet.
        public abstract double Area();           //Metoden Area() som returnerar en double. Public pga access från Program-klassen.

    }
}
