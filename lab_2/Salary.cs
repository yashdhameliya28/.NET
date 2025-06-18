class Salary
{
    public double basic, ta, da, hra;

    public Salary(double basic, double ta, double da = 0.1, double hra = 0.1)
    {

        this.basic = basic;
        this.ta = ta;
        this.hra = (hra/100)*basic;
        this .da = (da/100)*basic;
    }

    public void calculateSalary()
    {
        double salary = this.basic + this.ta + this.hra + this.da;
        Console.WriteLine($"Salary is {salary}");
    }

}
