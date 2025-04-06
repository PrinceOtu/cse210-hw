
public class Blind
{
    public double _width;
    public double _height;
    public string _color;
    
    public double GetArea()
    {
        return _width * _height;
    }
}
public class Window : Blind
{
    public string _material;
    public string _style;

    public string _type;
    public string _location;
    public string _view;
    public string _framecolor;
    public string _glasscoor;

    double materialAmount = kitchen.GetArea();
}