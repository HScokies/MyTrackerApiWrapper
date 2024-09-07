using MyTrackerApiWrapper.Attributes;
using MyTrackerApiWrapper.DataTypes;
using MyTrackerApiWrapper.Dictionaries;

namespace MyTrackerApiWrapper.ExportAPI.RawData.Requests;

public sealed class CreateRequest
{
    private static string Path => "/raw/v1/export/create.json";
    
    
    /// <summary>
    /// Field list for export
    /// </summary>
    [QueryName("selectors")]
    public IEnumerable<Selector> Selectors { get; init; } // TODO: Add ctor
    
    /// <summary>
    /// Filter by date, from which the export begins
    /// <remarks>
    /// Cannot be less than 1970-01-01; cannot be more than the current date; must not be more than <see cref="DateTo"/>; use with the timezone parameter to set the correct timezone (<see cref="Timezone.EuropeMoscow"/>, by default) 
    /// </remarks>
    /// </summary>
    [QueryName("dateFrom")]
    public DateOnly DateFrom { get; init; } // TODO: Add check & ctor
    
    /// <summary>
    /// Filter by date to which the export complete
    /// <remarks>
    /// Cannot be more than the current date;
    /// must not be less than <see cref="DateFrom"/>; use with the timezone parameter to set the correct timezone (<see cref="Timezone.EuropeMoscow"/>, by default)
    /// </remarks>
    /// </summary>
    [QueryName("dateTo")]
    public DateOnly DateTo { get; init; } // TODO: Add check & ctor
    
    /// <summary>
    /// Filter by event timestamp from which the export begins
    /// <remarks>
    /// Cannot be more than the current timestamp; must not be more than <see cref="TimestampTo"/> 
    /// </remarks>
    /// </summary>
    [QueryName("tsFrom")]
    public UnixTimestamp TimestampFrom { get; init; } // TODO: Add check & and ctor
    
    /// <summary>
    /// Filter by event timestamp to which the export complete
    /// <remarks>
    /// Cannot be more than the current timestamp; must not be less than <see cref="TimestampFrom"/>
    /// </remarks>
    /// </summary>
    [QueryName("tsTo")]
    public UnixTimestamp TimestampTo { get; init; } // TODO: Add check & and ctor
    
    /// <summary>
    /// Filter by timestamp of event appearance in the system, from which the export begins
    /// <remarks>
    /// Must be less than the current timestamp minus 3 hours; must not be more than <see cref="AvailabilityTimestampTo"/>
    /// </remarks>
    /// </summary>
    [QueryName("availabilityTsFrom")]
    public UnixTimestamp AvailabilityTimestampFrom { get; init; } // TODO: Add check on set block
    
    /// <summary>
    /// Filter by timestamp of event appearance in the system to which the export complete
    /// <remarks>
    /// Must be less than the current timestamp minus 3 hours; must not be less than <see cref="AvailabilityTimestampFrom"/>
    /// </remarks>
    /// </summary>
    [QueryName("availabilityTsTo")]
    public UnixTimestamp AvailabilityTimestampTo { get; init; } // TODO: Add check on set block
    
    /// <summary>
    /// indicates whether Jailbreak or root access has been detected on the device.
    /// <remarks>
    /// </remarks>
    /// Jailbreak refers to the iOS, while root access refers to Android
    /// </summary>
    [QueryName("rooted")]
    public Rooted Rooted { get; init; }
    
    /// <summary>
    /// Time zone for dates interpretation
    /// <remarks>
    /// The timezone <see cref="Timezone.EuropeMoscow"/> is set by default
    /// </remarks>
    /// </summary>
    [QueryName("timezone")]
    public Timezone Timezone { get; init; }
    
    /// <summary>
    /// Filter by ad mediator
    /// Only for <see cref="Event.AdMonetization"/> and <see cref="Event.UserAdMonetization"/>  
    /// </summary>
    [QueryName("idAdMediator")]
    public AdMediator AdMediatorId { get; init; }
    
    /// <summary>
    /// Filter by segment ID
    /// <remarks>
    /// Only for events <see cref="Event.Hits"/> and <see cref="Event.Installs"/>  
    /// </remarks>
    /// </summary>
    [QueryName("idSegment")]
    public int SegmentId { get; init; }
    
    /// <summary>
    /// Filter by partner id
    /// </summary>
    [QueryName("idPartner")]
    public IEnumerable<int> PartnerId { get; init; }
}