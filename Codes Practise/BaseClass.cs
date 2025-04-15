public class BaseClass
{
    // Members of the base class
}

public class DerivedClass : BaseClass
{
    // Members of the derived class (inherits from BaseClass)
}


public class BaseClass
{
    public string CommonProperty { get; set; }
    public void CommonMethod()
    {
        Console.WriteLine("This is a common method.");
    }
}

public class DerivedClass : BaseClass
{
    public string SpecificProperty { get; set; }
    public void SpecificMethod()
    {
        Console.WriteLine("This is a specific method.");
    }
}