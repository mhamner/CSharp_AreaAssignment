using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_AreaAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            ////
            /// This app demonstrates using an abstract class for Shape and then deriving square, rectangle, and triangle
            /// from it.  Each derived class then overrides and provide unqiue implementation for the FindArea() method
            //// 
            bool keepGoing = true;
            bool validChoiceEntered = false;
            int area = 0;
            string choice = "";

            while (keepGoing)
            {
                //Ensure the user enters a valid choice; loop back if not
                while (!validChoiceEntered)
                {
                    Console.WriteLine("Would you like to find the area of a square, a rectangle, or a triangle?");
                    choice = Console.ReadLine();
                    if(choice == "square" || choice == "rectangle" || choice == "triangle")
                    {
                        validChoiceEntered = true;
                    }
                }

                switch(choice.ToLower())
                {
                    case "square":
                        Console.WriteLine("Please enter the length of one side of your square.");
                        string s = Console.ReadLine();
                        Square square = new Square();
                        area = square.FindArea(s);
                        Console.WriteLine($"The area of your square is: {area}.");
                        break;
                    case "rectangle":
                        Console.WriteLine("Please enter the length and width of your rectangle, separated by a comma.");
                        string lw = Console.ReadLine();                      
                        Rectangle rectangle = new Rectangle();
                        area = rectangle.FindArea(lw);
                        Console.WriteLine($"The area of youre rectangle is: {area}.");
                        break;
                    case "triangle":
                        Console.WriteLine("Please enter the base and height of your triangle, separated by a comma.");
                        string bh = Console.ReadLine();
                        Triangle triangle = new Triangle();
                        area = triangle.FindArea(bh);
                        Console.WriteLine($"The area of youre rectangle is: {area}.");
                        break;
                    default:                       
                        break;
                }

                Console.WriteLine("Would you like to find the area of another shape? Yes / No");
                string answer = Console.ReadLine();
                if(answer.ToLower() != "yes")
                {
                    keepGoing = false;
                }
                else
                {   
                    //Indicate that we want the user to choose their shape again
                    validChoiceEntered = false;
                }
            }
            Console.WriteLine("Press any key to end.");
            Console.ReadKey();
        }     
    }
}
