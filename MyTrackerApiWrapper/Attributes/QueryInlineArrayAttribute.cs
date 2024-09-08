using System;

namespace MyTrackerApiWrapper.Attributes;

/// <summary>
/// Indicates inline MyTracker query array format
/// <example>
/// ?query=1,2,3
/// </example>
/// </summary>
/// [AttributeUsage(AttributeTargets.Property)]
internal sealed class QueryInlineArrayAttribute : Attribute
{
}