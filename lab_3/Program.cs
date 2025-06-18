using lab_Manual.lab_3;

Console.WriteLine("Enter question number : ");
int lab_3question = Convert.ToInt32(Console.ReadLine());

switch (lab_3question)
{
    case 1:
        Console.WriteLine("Enter n1 value");
        int n1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter n2 value : ");
        int n2 = Convert.ToInt32(Console.ReadLine());
        double ans;
        try
        {
            if (n2 == 0)
            {
                throw new CustomDivideByZero("Value of n2 is 0");
            }
            else
            {
                ans = n1 / n2;
                Console.WriteLine(ans);
            }
        }
        catch (CustomDivideByZero e)
        {
            Console.WriteLine(e);
        }
        break;



    case 8:
        Console.WriteLine("Enter a number : ");
        int n = Convert.ToInt32(Console.ReadLine());

        try
        {
            if (n % 2 != 0)
            {
                throw new NumberNotEven("Givern number is not even");
            }
        }
        catch (NumberNotEven e)
        {
            Console.WriteLine(e);
        }
        break;

    case 7:
        Console.WriteLine("1. Circle\n2. Triangle\n3. Square");
        int na = Convert.ToInt32(Console.ReadLine());
        FindArea fd = new FindArea();
        fd.area(na);
        break;

    case 6:
        Console.WriteLine("Enter a string : ");
        string str = Console.ReadLine();
        string newString = "";
        foreach (char ch in str)
        {
            if (char.IsLower(ch))
            {
                newString += ch.ToString().ToUpper();
            }
            else
            {
                newString += ch.ToString().ToLower();
            }
        }

        Console.WriteLine($"New string is : {newString}");
        break;

    case 5:
        Console.WriteLine("Enter a string : ");
        string str1 = Console.ReadLine();

        Console.WriteLine($"lower case to upper case : {str1.ToUpper()}");
        Console.WriteLine($"upper case to lower case : {str1.ToLower()}");
        Console.WriteLine($"string length : {str1.Length}");
        break;

    case 4:
        Console.WriteLine("1. addition\n2. subtraction");
        int userChoice = Convert.ToInt32(Console.ReadLine());
        Result result = new Result();
        result.mathOperaton(userChoice);
        break;

    case 3:
        Console.WriteLine("1. addition for two number\n2. addition for three number");
        int userChoice1 = Convert.ToInt32(Console.ReadLine());

        Calculate1 calculate1 = new Calculate1();
        calculate1.calculate(userChoice1);
        break;

    case 2:

        int[] numbers = new int[5];
        Console.WriteLine("Please enter 5 numbers:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Number {i + 1}: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        try
        {

            Console.WriteLine(numbers[5]);
        }
        catch (IndexOutOfRangeException e)
        {

            Console.WriteLine(e);
        }
        break;

    case 9:
        Console.WriteLine("Enter a string : ");
        string str2 = Console.ReadLine();

        string[] words = str2.Split(' ');
        int maxLen = int.MinValue;
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length > maxLen)
            {
                maxLen = words[i].Length;
            }
        }
        Console.WriteLine(maxLen);

        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length == maxLen)
            {
                Console.WriteLine(words[i]);
            }
        }
        break;

    case 10:
        Console.Write("Enter a character: ");
        char ch1 = Convert.ToChar(Console.Read());


        if (char.IsUpper(ch1))
        {
            Console.WriteLine("Lowercase: " + char.ToLower(ch1));
        }
        else
        {
            Console.WriteLine("Uppercase: " + char.ToUpper(ch1));
        }

        break;

}
