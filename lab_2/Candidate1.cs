class Candidate1
{

    int id, age, weight, height;
    string name;

    public void getCandidateDetails(int id, string name, int age, int weight, int height)
    {
        this.id = id;
        this.name = name;
        this.age = age;
        this.weight = weight;
        this.height = height;
    }

    public void displayCandidateDetails()
    {
        Console.WriteLine("candidate id : " + id);
        Console.WriteLine("candidate name : " + name);
        Console.WriteLine("candidate age : " + age);
        Console.WriteLine("candidate weight : " + weight);
        Console.WriteLine("candidate height : " + height);
    }

}