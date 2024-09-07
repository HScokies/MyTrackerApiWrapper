namespace MyTrackerApiWrapper.Attributes;

[AttributeUsage(AttributeTargets.Field)]
public class QueryValueAttribute : Attribute
{
    private readonly string _value;

    public QueryValueAttribute(string value)
    {
        _value = value;
    }
}