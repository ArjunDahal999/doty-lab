//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace lab1
//{
//    internal class polymorphism
//    {
//        class Shape
//        {
//            // Method to calculate area
//            public virtual double CalculateArea()
//            {
//                return 0;
//            }
//        }

//        // Derived class Circle
//        class Circle : Shape
//        {
//            // Radius of the circle
//            private double radius;

//            // Constructor
//            public Circle(double radius)
//            {
//                this.radius = radius;
//            }

//            // Override the CalculateArea method
//            public override double CalculateArea()
//            {
//                return Math.PI * radius * radius;
//            }
//        }

//        static void Main(string[] args)
//        {
//            Circle c = new Circle(4);
//            Console.WriteLine(c.CalculateArea());
//        }
//    }
//}
