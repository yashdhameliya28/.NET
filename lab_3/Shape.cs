using System.Runtime.Intrinsics.Arm;

interface Shape
{
    double Circle(double radius);
    double Triangle(double triBase, double height);
    double Square(double  length);
}

public class FindArea: Shape
{
    public int user;

    public void area(int n)
    {
        if (n == 1)
        {
            Console.WriteLine("Enter circle radius : ");
            double radius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Circle area is : {Circle(radius)}");
        }
        else if (n == 2)
        {
            Console.WriteLine("Enter triangle base value : ");
            double triBase = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter triangle height : ");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Triangle area is : {Triangle(triBase, height)}");
        }

        else if (n == 3)
        {
            Console.WriteLine("Enter square lenght : ");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Square area is : {Square(length)}");
        }
        else
        {
            Console.WriteLine("Enter valid number!!!!");
        }
    }

    public double Circle(double radius)
    {
        return radius * radius * Math.PI;
    }

    public double Triangle(double triBase, double height)
    {
        return (triBase * height) / 2;
    }

    public double Square(double length) {
        return length * length;
    } 
}