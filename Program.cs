// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main()
    {
        double x1, y1, x2, y2;

        Console.Write("Enter x-coordinate of point A: ");
        if (double.TryParse(Console.ReadLine(), out x1))
        {
            Console.Write("Enter y-coordinate of point A: ");
            if (double.TryParse(Console.ReadLine(), out y1))
            {
                Console.Write("Enter x-coordinate of point B: ");
                if (double.TryParse(Console.ReadLine(), out x2))
                {
                    Console.Write("Enter y-coordinate of point B: ");
                    if (double.TryParse(Console.ReadLine(), out y2))
                    {
                        double distance = CalculateDistance(x1, y1, x2, y2);
                        Console.WriteLine($"The distance between A and B is: {distance}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input for y-coordinate of point B.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input for x-coordinate of point B.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input for y-coordinate of point A.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input for x-coordinate of point A.");
        }
    }

    static double CalculateDistance(double x1, double y1, double x2, double y2)
    {
        return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    }
}