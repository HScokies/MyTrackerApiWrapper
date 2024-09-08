using System;

namespace MyTrackerApiWrapper.Attributes;

[AttributeUsage(AttributeTargets.Property)]
internal sealed class QueryNameAttribute : QueryAttributeBase
{
    private readonly string _name;
    public QueryNameAttribute(string name)
    {
        _name = name;
    }

    public override string Get()
    {
        return _name;
    }
}