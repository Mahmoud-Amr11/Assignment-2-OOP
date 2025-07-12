namespace Assignment_2_OOP
{
    //Q1
    public struct Person
    {
        public string Name { get; set; }
        public int Age{ get; set; }


        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1-Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.      

            Person[] persons =  {
            new Person() { Name = "Alice", Age = 30 },
            new Person() { Name = "Bob", Age = 25 },
            new Person() { Name = "Charlie", Age = 35 }
            };

            foreach (var person in persons)
            {
                Console.WriteLine(person);
            }
            #endregion
        }
    }
   
}
