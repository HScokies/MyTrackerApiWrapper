using System;
using System.Collections.Generic;
using MyTrackerApiWrapper.Enumerations.Dictionaries;
using MyTrackerApiWrapper.Interfaces;

namespace MyTrackerApiWrapper.ExportAPI.RawData.Create.Request.EventTypes;

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