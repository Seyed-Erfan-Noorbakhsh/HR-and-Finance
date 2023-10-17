
class HumanResource : Unit
{
    private string employeeName;
    private int employeeID;

    public HumanResource(string unitName, string employeeName, int employeeID) : base(unitName)
    {
        this.employeeName = employeeName;
        this.employeeID = employeeID;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Employee Name: " + employeeName);
        Console.WriteLine("Employee ID: " + employeeID);
    }
}