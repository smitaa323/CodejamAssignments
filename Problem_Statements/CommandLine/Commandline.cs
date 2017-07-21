public class CalculateArea
{
    public static long Area(int l,int b)
    {
        // Test for invalid input
        if (l<0 || b<0)
        {
            return -1;
        }

        
        long area = 1;
        area = l * b;
        return area;
    }
}

class Commandline
{
    static int Main(string[] args)
    {
        // Test if input arguments were supplied:
        if (args.Length == 0)
        {
            System.Console.WriteLine("Please enter a numeric argument.");
            
            return 1;
        }

       
        // num = int.Parse(args[0]);
        int length,breadth;
        bool test1 = int.TryParse(args[0], out length);
        bool test2 = int.TryParse(args[0], out breadth);
        if (test1 == false || test2 == false)
        {
            System.Console.WriteLine("Please enter a numeric argument.");
            System.Console.WriteLine("Usage: Area(length,breadth)");
           
            return 1;
        }

        // Calculate area
        long result = CalculateArea.Area(length,breadth);

        // Print result.
        if (result == -1)
            System.Console.WriteLine("Input must be greater than 0.");
        else
            System.Console.WriteLine("The Factorial of {0}", result);

        System.Console.ReadLine();

        return 0;
    }
}