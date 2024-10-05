using System;

namespace RawExportApiClient.Attributes;

/// <summary>
/// Indicates my tracker custom array
/// <example>
/// ?query=1,2,3
/// </example>
/// </summary>
[AttributeUsage(AttributeTargets.Property)]
internal sealed class QueryInlineArrayAttribute : Attribute
{
}