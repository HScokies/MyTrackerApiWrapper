using System;

namespace MyTrackerApiWrapper.Attributes;

/// <summary>
/// Indicates custom MyTracker query array format
/// <example>
/// query[]=1&query[]=2
/// </example>
/// </summary>
[AttributeUsage(AttributeTargets.Property)]
internal sealed class QueryCustomArray : Attribute
{
}