using System;

namespace MyTrackerApiWrapper.Attributes;

public abstract class QueryAttributeBase : Attribute
{
    public abstract string Get();
}