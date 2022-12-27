// See https://aka.ms/new-console-template for more information

interface IGeographicObject
{
    int X
    { set; get; }
    int Y
    { set; get; }
    public string Name
    { set; get; }
    public void WayToGetInfo()
    {

    }
}

class River : IGeographicObject
{
    public River(int x, int y, string name, string description)
    {
        X = x;
        Y = y;
        Name = name;
        Description = description;
    }

    public int X { get; set; }
    public int Y { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    void IGeographicObject.WayToGetInfo()
    {

    }

    private double FlowRate;
    private double Length;
}

class Mountain : IGeographicObject
{
    public Mountain(int x, int y, string name, string description)
    {
        X = x;
        Y = y;
        Name = name;
        Description = description;
    }

    public int X { get; set; }
    public int Y { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    void IGeographicObject.WayToGetInfo()
    {

    }
    private double HighestPoint;
}

