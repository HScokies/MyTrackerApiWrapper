using System.Collections.Generic;
using RawExportApiClient.Abstractions;
using RawExportApiClient.Attributes;
using RawExportApiClient.Enums.Dictionaries;
using RawExportApiClient.Enums.Dictionaries.Selectors;

namespace RawExportApiClient.Commands.Create.EventTypes;

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