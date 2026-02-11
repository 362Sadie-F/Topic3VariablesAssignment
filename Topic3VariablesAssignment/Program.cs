namespace Topic3VariablesAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int roomNumber = 37;
            string courseName = "Visual Arts";
            double price = 24.95 * 1.13;
            double priceRounded = Math.Round(price, 2);
            string fullName = "Mercedes Fleming";
            int graduationYear = 2027;
            int r = 3;
            double area = (Math.PI * (r * r));
            double rounded = Math.Round(area, 2);
            Console.WriteLine("Class is in room " + roomNumber + "!");
            Console.WriteLine("My favorite class is " + courseName + ".");
            Console.WriteLine("The price of my favorite book is " + "$" + priceRounded + ".");
            Console.WriteLine("    ");
            Console.WriteLine("My name is " + fullName + " and I will graduate in " + graduationYear + "!");
            Console.WriteLine("    ");
            Console.WriteLine("The area of a circle is " + Math.PI * (r * r)); // Pi * R^2
            Console.WriteLine("Therefore the area is " + rounded + " cm^2");
            Console.WriteLine("    ");
            Console.WriteLine();
        }
    }
}
