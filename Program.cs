using System.Drawing;

namespace NET23_AmieM_LAB7_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();                                  //Nytt objekt/instans av klassen Rectangle.
            Console.WriteLine("Area Rektangel: " + rectangle.Area());               //Kallar på metoden Area() från basklassen med sin egen implementering.
            Console.WriteLine();

            Square square = new Square();                                           //Nytt objekt/instans av klassen Square.
            Console.WriteLine("Area Fyrkant : " + square.Area());                    //Kallar på metoden Area() från basklassen med sin egen implementering.
            Console.WriteLine();

            Circle circle = new Circle();                                           //Nytt objekt/instans av klassen Circle.
            Console.WriteLine("Area Cirkel: " + circle.Area());                     //Kallar på metoden Area() från basklassen med sin egen implementering.
            Console.WriteLine();

            Parallelogram parallelogram = new Parallelogram();                      //Nytt objekt/instans av klassen Parallelogram.
            Console.WriteLine("Area Parallellogram: " + parallelogram.Area());      //Kallar på metoden Area() från basklassen med sin egen implementering.
            Console.WriteLine();

            Ellipse ellipse = new Ellipse();                                        //Nytt objekt/instans av klassen Ellipse.
            Console.WriteLine("Area Ellips: " + ellipse.Area());                   //Kallar på metoden Area() från basklassen sin egen implementering.
            Console.WriteLine();
        }
    }
}