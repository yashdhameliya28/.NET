public abstract  class Sum
{
    public abstract int sumOfTwo(int a, int b);
    public abstract int sumOfThree(int a, int b, int c);
}

public class Calculate1 : Sum
{

    public override int sumOfTwo(int a, int b)
    {
        return a + b;
    }
    
    public override int sumOfThree(int a, int b, int c)
    {
        return a + b + c;
    }

    public void calculate(int n)
    {
        if (n == 1)
        {
            Console.WriteLine("Enter first number : ");
            int a = Convert.ToInt32 (Console.ReadLine());

            Console.WriteLine("Enter second number : ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Two number sum is : {sumOfTwo(a, b)}");
        }
        else if(n == 2) 
        {
            Console.WriteLine("Enter first number : ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number : ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter third number : ");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Three number sum is : {sumOfThree(a, b, c)}");

        }
        else
        {
            Console.WriteLine("Enter valid number!!!");
        }
    }
}