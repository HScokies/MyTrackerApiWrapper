using System;
using System.Collections.Generic;
using RawExportApiClient.Enums.Dictionaries;
using RawExportApiClient.Interfaces;

namespace RawExportApiClient.Abstractions;

public abstract class CreateEventBase<TSelector> : IRequestElement where TSelector : Enum
{
    /// <summary>
    /// Event type
    /// </summary>
    public abstract Event EventType { get; }

    /// <summary>
    /// Field list for export
    /// </summary>
    public abstract ICollection<TSelector> Selectors { get; init; }
}