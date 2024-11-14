namespace Assignment2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
            Console.WriteLine("Would you like to select a (A) Circle or (B) Square?");
            string userSelection = Console.ReadLine();

            switch (userSelection)
            {
                case "A":
                case "a":
                    Console.WriteLine("Area of Circle has been selected");
                    Console.WriteLine("What is the radius?");
                    double radiusValue = Convert.ToDouble(Console.ReadLine());
                    Console.Write("The area of this circle is: ");
                    Console.WriteLine(Circle.CalculateArea(radiusValue));
                    break;

                case "B":
                case "b":
                    Console.WriteLine("Area of Square has been selected");
                    Console.WriteLine("How long is the length of the square?");
                    double squareValue = Convert.ToDouble(Console.ReadLine());
                    Console.Write("The area of this square is: ");
                        
                    Console.WriteLine(Square.CalculateArea(squareValue));
                    break;
            }
           






        }
    }
    }
