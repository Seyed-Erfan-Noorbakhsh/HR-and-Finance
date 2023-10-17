using System;


class Program
{
    static void Main(string[] args)
    {
        HumanResource hrUnit = new HumanResource("Human Resource", "John Doe", 12345);
        Finance financeUnit = new Finance("Finance", 5000000);

        Console.WriteLine("Details for Human Resource Unit:");
        hrUnit.DisplayInfo();
        Console.WriteLine();

        Console.WriteLine("Details for Finance Unit:");
        financeUnit.DisplayInfo();
    }
}
