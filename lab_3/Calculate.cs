interface Calculate
{
    public int addition(int a, int b);
    public int subtraction(int a, int b);
}

public class Result : Calculate
{
    public int addition(int a, int b)
    {
        return a + b;
    }

    public int subtraction(int a, int b) { return a - b; }

    public void mathOperaton(int n)
    {
        if (n == 1)
        {
            Console.WriteLine("Enter first number : ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number : ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Addition of given number is : {addition(a, b)}");
        }
        else if (n == 2)
        {
            Console.WriteLine("Enter first number : ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number : ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Subtraction of given number is : {subtraction(a, b)}");
        }
        else
        {
            Console.WriteLine("Enter valid number!!!");
        }
    }
}