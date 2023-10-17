
class Finance : Unit
{
    private int companyBalance;

    public Finance(string unitName, int companyBalance) : base(unitName)
    {
        this.companyBalance = companyBalance;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Company Balance: $" + companyBalance);
    }
}