namespace Topic3VariablesAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int roomNumber = 37;
            string courseName = "Visual Arts";
            double price = 24.95;
            string fullName = "Mercedes Fleming";
            int graduationYear = 2027;
            int r = 3;
            double area = (Math.PI * r * r);
            double rounded = Math.Round(area, 2);
            Console.WriteLine("Class is in room " + roomNumber + "!");
            Console.WriteLine("My favorite class is " + courseName + ".");
            Console.WriteLine("The price of my favorite book is " + price + ".");
            Console.WriteLine("    ");
            Console.WriteLine("My name is " + fullName + " and I will garduate in " + graduationYear + "!");
            Console.WriteLine("    ");
            Console.WriteLine(Math.PI * r * r); // Pi * R^2
            Console.WriteLine("The area is " + rounded);
        }
    }
}
