class Staff
{
    public string name, department, designation, expirence;
    public int salary;

    public void getStaffDetails()
    {
        Console.WriteLine("Enter staff name : ");
        name = Console.ReadLine();

        Console.WriteLine("Enter staff department : ");
        department = Console.ReadLine();

        Console.WriteLine("Enter staff designation : ");
        designation = Console.ReadLine();

        Console.WriteLine("Enter staff expirence: ");
        expirence = Console.ReadLine();

        Console.WriteLine("Enter staff salary : ");
        salary = Convert.ToInt32(Console.ReadLine());
    }

}