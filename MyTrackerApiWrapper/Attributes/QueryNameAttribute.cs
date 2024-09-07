namespace MyTrackerApiWrapper.Attributes;

[AttributeUsage(AttributeTargets.Property)]
public class QueryNameAttribute : Attribute
{
    private readonly string _name;
    public QueryNameAttribute(string name)
    {
        _name = name;
    }
}