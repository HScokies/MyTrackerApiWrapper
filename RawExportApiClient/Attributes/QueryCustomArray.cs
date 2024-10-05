using System;

namespace RawExportApiClient.Attributes;

/// <summary>
/// Indicates my tracker custom array
/// <example>
/// query[]=1&query[]=2
/// </example>
/// </summary>
[AttributeUsage(AttributeTargets.Property)]
internal sealed class QueryCustomArray : Attribute
{
}