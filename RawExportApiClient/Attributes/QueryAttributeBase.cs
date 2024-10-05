using System;

namespace RawExportApiClient.Attributes;

public abstract class QueryAttributeBase : Attribute
{
    public abstract string Get();
}