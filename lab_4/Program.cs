using lab_4;

Console.WriteLine("Enter Question number : ");
int question = Convert.ToInt32(Console.ReadLine());

switch (question)
{
    case 1:
        Console.WriteLine("1.integer\n2.double");
        int n = Convert.ToInt32(Console.ReadLine());
            Question1 question1 = new Question1();

        if (n == 1)
        {
            Console.WriteLine("Enter first number : ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number : ");
            double b = Convert.ToDouble(Console.ReadLine());

            question1.addition(a, b);
            
        }
        else if (n == 2)
        {
            Console.WriteLine("Enter first number : ");
            double da = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter second number : ");
            double db = Convert.ToDouble(Console.ReadLine());

            question1.addition(da, db);
            
        }
        else
        {
            Console.WriteLine("Enter valid number!!!");
        }
            
        break;

        case 2:
        Console.WriteLine("1.square\n2.rectangle");
        int n2 = Convert.ToInt32(Console.ReadLine());
        Question2 question2 = new Question2();

        if (n2 == 1)
        {
            Console.WriteLine("Enter square length : ");
            int length = Convert.ToInt32(Console.ReadLine());


            question2.area(length);
            
        }
        else if (n2 == 2)
        {
            Console.WriteLine("Enter rectangle length: ");
            int length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter rectangle height : ");
            int height = Convert.ToInt32(Console.ReadLine());

            question2.area(length, height);
        }
        else
        {
            Console.WriteLine("Enter valid number!!!");
        }
        break;

    case 3:
        Console.WriteLine("Enter principal : ");
        double principal = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter rate : ");
        double rate = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter time : ");
        int time = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("1.RBI\n2.HDFC\n3.SBI\n4.ICIC");
        int bankNo = Convert.ToInt32(Console.ReadLine());
        if (bankNo == 1)
        {
            RBI rbi = new RBI();
            rbi.calculateInterest(principal, time, rate);
        }
        else if (bankNo == 2)
        {
            HDFC hdfc = new HDFC();
            hdfc.calculateInterest(principal, time, rate);
        }
        else if (bankNo == 3)
        {
            SBI sbi = new SBI();
            sbi.calculateInterest(principal, time, rate);   
        }
        else if (bankNo == 4)
        {
            ICIC icic = new ICIC();
            icic.calculateInterest(principal, time, rate);
        }
        else
        {
            Console.WriteLine("Enter valid bank number!!!");
        }

            break;

    case 4:
        Gokul_Superspeciality gokul_Superspeciality = new Gokul_Superspeciality();
        gokul_Superspeciality.hospitalDetails();
        break;

    case 5:
        Console.WriteLine("1.square\n2.rectangle");
        int n5 = Convert.ToInt32(Console.ReadLine());
        Question5 question5 = new Question5();

        if (n5 == 1)
        {
            Console.WriteLine("Enter square length : ");
            int length = Convert.ToInt32(Console.ReadLine());


            question5.area(length);

        }
        else if (n5 == 2)
        {
            Console.WriteLine("Enter rectangle length: ");
            int length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter rectangle height : ");
            int height = Convert.ToInt32(Console.ReadLine());

            question5.area(length, height);
        }
        else if (n5 == 3)
        {
            Console.WriteLine("Enter circle radius : ");
            double radius = Convert.ToDouble(Console.ReadLine());

            question5.area(radius);
        }
        else
        {
            Console.WriteLine("Enter valid number!!!");
        }
        break;

    case 6:

        Console.WriteLine("Enter balance : ");
        int balance = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter account holder name : ");
        string accountHolderName = Console.ReadLine();
        BankAccount bankAccount = new BankAccount(balance, accountHolderName);

        Console.WriteLine("Enetr ammount to withdraw : ");
        int ammount = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter check number");
        int checkNo = Convert.ToInt32(Console.ReadLine());
        
        bankAccount.withdraw(ammount);
        bankAccount.withdraw(ammount, checkNo);

        break;
}