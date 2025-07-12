namespace Assignment_2_OOP
{
    //Q1
    public struct Person
    {
        public string Name { get; set; }
        public int Age { get; set; }


        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }
    }

    //Q2
    public struct Point
    {
        public int X{ get; set; }
        public int Y { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1-Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.      
            //Person[] persons =  {
            //new Person() { Name = "Alice", Age = 30 },
            //new Person() { Name = "Bob", Age = 25 },
            //new Person() { Name = "Charlie", Age = 35 }
            //};

            //foreach (var person in persons)
            //{
            //    Console.WriteLine(person);
            //}
            #endregion



            #region 2-Create a struct called "Point" to represent a 2D point with properties "X" and   "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.
            Point point = new Point();
            Console.WriteLine("Enter the X coordinate of the first point:");
            point.X = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Y coordinate of the first point:");
            point.Y = int.Parse(Console.ReadLine());

            Point point2 = new Point();
            Console.WriteLine("Enter the X coordinate of the second point:");
            point2.X = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Y coordinate of the second point:");
            point2.Y = int.Parse(Console.ReadLine());

            double distance = Math.Sqrt(Math.Pow(point2.X - point.X, 2) + Math.Pow(point2.Y - point.Y, 2));

            Console.WriteLine($"The distance between the points ({point.X}, {point.Y}) and ({point2.X}, {point2.Y}) is: {distance}");
            #endregion


        }
    }

}
