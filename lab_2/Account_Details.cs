class Account_details
{
    public static double balance;
    public int account_no;
    public string accountName;

    public void getAccountDetails()
    {
        Console.WriteLine("Enter account balance : ");
        balance = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter account name : ");
        accountName = Console.ReadLine();

        Console.WriteLine("Enter account number : ");
        account_no = Convert.ToInt32(Console.ReadLine());
    }
}

class Interest : Account_details
{
    public double rate;
    public int time;

    public void calculateInterest()
    {
        
        double interest;
        Console.WriteLine("Enter rate :");
        rate = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter time : ");
        time = Convert.ToInt32(Console.ReadLine());

        interest = (balance * rate * time) / 100;
        Console.WriteLine($"Your interest is {interest}");
    }

}