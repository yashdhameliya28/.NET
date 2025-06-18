class Student
{
    public int enrollmentNo, semester;
    public string studentName;
    public double cpi, spi;

    public Student(int enrollmentNo, int semester, string studentName, double spi, double cpi)
    {
        this.enrollmentNo = enrollmentNo;
        this.semester = semester;
        this.studentName = studentName;
        this.cpi = cpi;
        this.spi = spi;
    }
    
    public void displayStudentDeatils()
    {
        Console.WriteLine($"Student name is {studentName} ");
        Console.WriteLine($"Student enrollment number is {enrollmentNo} ");
        Console.WriteLine($"Student semester is {semester} ");
        Console.WriteLine($"Student CPI is {cpi} ");
        Console.WriteLine($"Student SPI is {spi} ");
    }
}