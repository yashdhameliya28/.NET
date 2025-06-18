Console.WriteLine("Enter question number : ");
int questionNumber = Convert.ToInt32(Console.ReadLine());

switch (questionNumber)
{
    case 1:
        Console.WriteLine("Yash Dhameliya");
        Console.WriteLine("Rajkot, Gujrat");
        Console.WriteLine("932717407");
        Console.WriteLine("Rjkot");
        break;

    case 2:
        Console.WriteLine("Enter value of first number : ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter value of second number : ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(num2);
        Console.WriteLine(num1);
        break;

    case 3:
        Console.WriteLine("Enter your name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter your city:");
        string country = Console.ReadLine();

        Console.WriteLine($"Hello {name} from country {country}");
        break;

    case 4:
        Console.WriteLine("Enter length(in square-feet):");
        double lenght = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter width(in square-feet):");
        double width = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Area is {lenght * width}");
        break;

    case 5:
        Console.WriteLine("1. Square \n2. Rectangle \n3. Circle");
        int userChoice = Convert.ToInt32(Console.ReadLine());

        switch (userChoice)
        {
            case 1:
                Console.WriteLine("Enter length of square:");
                double length = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Area of square is : " + (length * length));
                break;

            case 2:
                Console.WriteLine("Enter length(in square-feet):");
                double l = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter width(in square-feet):");
                double w = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"Area of rectangle is {l * w}");
                break;

            case 3:
                Console.WriteLine("Enter radius of circle:");
                double radius = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Area of circle is " + (3.14 * radius * radius));
                break;

            default:
                Console.WriteLine("Enter valid number!!!");
                break;
        }
        break;

    case 6:
        Console.WriteLine("1. celsius to fahrenheit\n2. fahrenheit to celsius");
        int uChoice = Convert.ToInt32(Console.ReadLine());

        switch (uChoice)
        {
            case 1:
                Console.WriteLine("Enter celsius: ");
                double celsius = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("fahrenheit is " + ((9 / 5) * celsius + 32));
                break;

            case 2:
                Console.WriteLine("Enter fahrenheit: ");
                double fahrenheit = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("celsius is " + ((fahrenheit - 32) * (5 / 9)));
                break;
        }
        break;

    case 7:
        Console.WriteLine("Enter principal for find interest : ");
        double principal = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter rate for find interest : ");
        double rate = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter time for find interest : ");
        int time = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Interest is : " + ((principal * rate * time) / 100));
        break;

    case 8:
        Console.WriteLine("Enter operator (+, -, *, /)");
        char o = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("Enter value of first number : ");
        int n1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter value of second number : ");
        int n2 = Convert.ToInt32(Console.ReadLine());

        switch (o)
        {
            case '+':
                Console.WriteLine("sum of num1 and num2 is : " + (n1 + n2));
                break;

            case '-':
                Console.WriteLine("substration of num1 and num2 is : " + (n1 - n2));
                break;

            case '*':
                Console.WriteLine("multiplaction of num1 and num2 is : " + (n1 * n2));
                break;

            case '/':
                Console.WriteLine("division of num1 and num2 is : " + (n1 / n2));
                break;

            default:
                Console.WriteLine("Enter valid operator");
                break;
        }
        break;

    case 9:
        Console.WriteLine("Enter value of first number : ");
        int nm1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter value of second number : ");
        int nm2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("value of num1 is " + nm1 + " and value of num2 is " + nm2);

        nm1 = nm1 + nm2;
        nm2 = nm1 - nm2;
        nm1 = nm1 - nm2;

        Console.WriteLine("value of num1 is " + nm1 + " and value of num2 is " + nm2);
        break;

    case 10:
        Console.WriteLine("Enter value of first number : ");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter value of second number : ");
        int y = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter value of third number : ");
        int num3 = Convert.ToInt32(Console.ReadLine());

        int temp = x > y ? x : y;
        int maxNumber = num3 > temp ? num3 : temp;

        Console.WriteLine("Maximum number is : " + maxNumber);
        break;

    default:
        Console.WriteLine("Enter valid question number");
        break;
}

