
namespace lab1
{
    class Program
    {
        //    static void Main(string[] args) {
        //        Student s1 = new Student(1, "Arjun", 12);
        //        List<Student> students = new List<Student>()
        //        {
        //            new Student(1, "Arjun", 20),
        //            new Student(2, "Ayush", 22),
        //            new Student(3, "Ram", 12),
        //            new Student(4, "Shyam", 18)
        //        };
        //        Console.WriteLine("******************StudentWithStartingLetterA *************");
        //        var StudentWithStartingLetterA = from s in students where s.Name.StartsWith("A") select s;
        //        foreach (var student in StudentWithStartingLetterA) {
        //            student.Display();
        //        }
        //        Console.WriteLine("************ studentBelow18 ********************");
        //        var studentBelow18 = students.Where(s => s.Age < 18);
        //        foreach (var student in studentBelow18)
        //        {
        //            student.Display();
        //        }
        //    }
        //}
        public abstract class Shape
        {
            public abstract double Area();
            public void Display()
            {
                Console.WriteLine("This is a shape.");
            }
        }
        public class Rectangle : Shape
        {
            public override double Area()
            {
                return 10 * 5;
            }
        }

        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            double area = rectangle.Area();
            Console.WriteLine("Area of rectangle: " + area);
            rectangle.Display();
        }


    }
}
