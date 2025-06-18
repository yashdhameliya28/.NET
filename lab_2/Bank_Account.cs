class Bank_Account
{
    public int accountNo, accountBalance;
    public string email, userName, accountType;

    public void getAccountDetails()
    {
        Console.WriteLine("Enter your account number : ");
        accountNo = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter your account balance : ");
        accountBalance = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter your email : ");
        email = Console.ReadLine();

        Console.WriteLine("Enter user name: ");
        userName = Console.ReadLine();

        Console.WriteLine("Enter your account type : ");
        accountType = Console.ReadLine();
    }

    public void displayAccountDetails()
    {
        Console.WriteLine($"Your account number is {accountNo}");
        Console.WriteLine($"Your user name is {userName}");
        Console.WriteLine($"Your email is {email}");
        Console.WriteLine($"Your account type is {accountType}");
        Console.WriteLine($"Your account balance is {accountBalance}");
    }

}