using System;

namespace ArchitectArithmetic
{
    class Program
    {
        public static  void Main(string[] args)
        {
            // Testing as per step 4
            /*
            Console.WriteLine(RectangleArea(4, 5));
            Console.WriteLine(CircleArea(4));
            Console.WriteLine(TriangleArea(10, 9));
            */
            
            // Various variables to support user input
            bool validInput = false;
            string? readResult;
            int result;
            double totalArea;
            double totalCost;

            do
            {
                Console.WriteLine("What monument would you like to work with?");
                Console.WriteLine("Press 1 for Teotihuacan.");
                Console.WriteLine("Press 2 for Taj Mahal.");
                Console.WriteLine("Press 3 for Great Mosque of Mecca.");
                readResult = Console.ReadLine();
                int.TryParse(readResult, out result);

                if (result > 0 && result < 4)
                {
                    switch (result)
                    {
                        case 1:
                            totalArea = RectangleArea(2500, 1500) + TriangleArea(750, 500) + (CircleArea(375) * 0.5);
                            validInput = true;
                            break;
                        
                        case 2:
                            // For challenge 1
                            totalArea = RectangleArea(90.5, 90.5) - (TriangleArea(24, 24) * 4);
                            validInput = true;
                            break;
                        
                        case 3:
                            // For challenge 2
                            totalArea = RectangleArea(200, 264) + TriangleArea(84, 264) + RectangleArea(180, 106);
                            validInput = true;
                            break;
                        
                        default:
                            totalArea = 0;
                            break;
                    }

                    totalCost = totalArea * 180;
                    Console.WriteLine($"It will cost {totalCost:C} for renovation.");
                    
                }
                
            }
            while (validInput == false);
        }

        static double RectangleArea (double length, double width)
        {
            return length * width;
        }

        static double CircleArea (double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        static double TriangleArea (double bottom, double height)
        {
            return 0.5 * bottom * height;
        }
    }
}