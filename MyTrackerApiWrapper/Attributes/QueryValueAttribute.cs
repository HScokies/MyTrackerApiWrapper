﻿using System;

namespace MyTrackerApiWrapper.Attributes;

[AttributeUsage(AttributeTargets.Field)]
internal sealed class QueryValueAttribute : QueryAttributeBase
{
    private readonly string _value;

    public QueryValueAttribute(string value)
    {
        _value = value;
    }

    public override string Get()
    {
        return _value;
    }
}