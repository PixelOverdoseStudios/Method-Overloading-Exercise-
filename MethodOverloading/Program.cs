namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            //example using the methods
            Console.WriteLine(Add(2, 4, true));
        }

        static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        static string Add(int num1, int num2, bool inDollars)
        {
            int sum = num1 + num2;

            if (inDollars)
                return sum == 1 ? $"{sum} dollar" : $"{sum} dollars";
            else
                return "No instructions given if boolean is false.";
        }
    }
}
