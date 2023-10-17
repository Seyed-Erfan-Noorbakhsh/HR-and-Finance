// کلاس یونیت برای دوتا گروه اچ آر و فایننس 
class Unit
{
    protected string name;

    public Unit(string name)
    {
        this.name = name;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine("Unit Name: " + name);
    }
}
