using lab_Manual.lab_2;

Console.WriteLine("Enter question number : ");
int question = Convert.ToInt32(Console.ReadLine());

switch (question)
{
    case 1:
        Candidate1 c1 = new Candidate1();

        Console.WriteLine("Enter candidate id: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter candidate name: ");
        string name = Console.ReadLine();

        Console.WriteLine("Enter candidate age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter candidate weight: ");
        int weight = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter candidate height: ");
        int height = Convert.ToInt32(Console.ReadLine());

        c1.getCandidateDetails(id, name, age, weight, height);
        c1.displayCandidateDetails();
        break;

    case 2:
        Staff[] s1 = new Staff[5];
        for (int i = 0; i < s1.Length; i++)
        {
            s1[i] = new Staff();
        }

        for (int i = 0; i < s1.Length; i++)
        {
            s1[i].getStaffDetails();
        }

        for (int i = 0; i < s1.Length; i++)
        {
            if (s1[i].designation.ToLower() == "hod")
            {
                Console.WriteLine(s1[i].name);
                Console.WriteLine(s1[i].salary);
            }
        }
        break;

    case 3:
        Bank_Account b1 = new Bank_Account();
        b1.getAccountDetails();
        b1.displayAccountDetails();
        break;

    case 4:

        Console.WriteLine("Enter student name : ");
        string studentName = Console.ReadLine();

        Console.WriteLine("Enter student enrollment number : ");
        int enrollmentNo = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter student semester : ");
        int semester = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter student SPI : ");
        double spi = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter student CPI : ");
        double cpi = Convert.ToDouble(Console.ReadLine());

        Student student1 = new Student(enrollmentNo, semester, studentName, spi, cpi);
        student1.displayStudentDeatils();

        break;

    case 5:
        Console.WriteLine("Enter rectangle length : ");
        int rectangleLength = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter rectangle height : ");
        int rectangleHeight = Convert.ToInt32(Console.ReadLine());

        Rectangle r1 = new Rectangle(rectangleLength, rectangleHeight);
        break;

    case 6:
        Interest i1 = new Interest();

        i1.calculateInterest();

        break;

    case 7:
        Console.WriteLine("Enter basic salary :");
        double basic = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter TA salary : ");
        double ta = Convert.ToDouble(Console.ReadLine());
        Salary sa = new Salary(basic, ta);
        sa.calculateSalary();
        break;

    case 8:
        Console.WriteLine("Enter first distance : ");
        double dis1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter second distance : ");
        double dis2 = Convert.ToDouble(Console.ReadLine());
        Distance ds = new Distance(dis1, dis2);
        ds.additionDis3();
        ds.display();
        break;

    case 9:

        Console.WriteLine("Enter furniture material :");
        string material = Console.ReadLine();

        Console.WriteLine("Enter furniture price : ");
        double price = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter table height : ");
        double tableHeight = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter table surface area : ");
        double surfaceArea = Convert.ToDouble(Console.ReadLine());

        Table t1 = new Table(tableHeight, surfaceArea, material, price);
        t1.displayTableDetails();
        break;

    case 10:
        Employee e1 = new Employee(1200, 1300, 450, 12000);
        e1.basic_sal();
        break;
}