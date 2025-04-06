public class House
{
    public string _owner;
    public Blind _kitchen;
    public Blind _livingRoom;
}

public class Blind{
    public string _color;
    public string _material;
    public string _size;
    public string _style;
    public string _brand;
    public string _price;
    public string _warranty;
    public string _color;
    public string _type;
    public string _lenght;
    public string _width;
    public string _hihght;
    plblic string _wight;
    public string _thickness;
    public string _cordLength;
    public string _cordType;
    public string _cordcolor;
    public string _cordMaterial;
    public string _cordsize;
    public string _cordstyle;
    public string _cordbrand;
    public string _cordprice;
    public string _cordwarranty;
}

{
    
House johnsonHome = new House();

johnsonHome._kitchen = new Blind();
johnsonHome._livingRoom = new Bind();
}

{
    public class House
{
    public string _owner = "";
    public Blind _kitchen = new Blind();
    public Blind _livingRoom = new Blind();
}
}

{
    
House johnsonHome = new House();
johnsonHome._owner = "Johnson Family";

{
    
johnsonHome._kitchen._width = 60;
}
}

{
    public class House
{
    public string _owner;
    public List<Blind> _blinds = new List<Blind>();
}
}

{
    johnsonHome._blinds.Add(kitchen);
}

{
    double amount = johnsonHome._blinds[0].GetArea();
}

{
    
foreach (Blind b in johnsonHome._blinds)
{
    double amount = b.GetArea();
}
}