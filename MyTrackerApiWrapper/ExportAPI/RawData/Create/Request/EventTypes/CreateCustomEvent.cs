using System.Collections.Generic;
using MyTrackerApiWrapper.Attributes;
using MyTrackerApiWrapper.Enumerations.Dictionaries;
using MyTrackerApiWrapper.Enumerations.Dictionaries.Selectors;

namespace MyTrackerApiWrapper.ExportAPI.RawData.Create.Request.EventTypes;

public sealed class CreateCustomEvent : CreateEventBase<CustomEvents>
{
    [QueryName("event")]
    public override Event EventType => Event.CustomEvents;

    /// <summary>
    /// Field list for export
    /// </summary>
    [QueryInlineArray, QueryName("selectors")]
    public override ICollection<CustomEvents> Selectors { get; init; }
    
    /// <summary>
    /// Filter by custom event name
    /// </summary>
    [QueryCustomArray, QueryName("eventName")]
    public ICollection<string> EventName { get; init; }
    
    /// <summary>
    /// Invert the eventName filter (exclude specified custom events from export) 
    /// </summary>
    [QueryName("eventNameInvert")]
    public InvertEventName InvertEventName { get; init; }

    public CreateCustomEvent(
        params CustomEvents[] selectors
    )
    {
        Selectors = selectors;
    }

    static CreateCustomEvent()
    {
    }
}