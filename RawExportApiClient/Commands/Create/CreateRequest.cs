using System;
using System.Collections.Generic;
using RawExportApiClient.Abstractions;
using RawExportApiClient.Attributes;
using RawExportApiClient.DataTypes;
using RawExportApiClient.Enums.Dictionaries;
using RawExportApiClient.Helpers;

namespace RawExportApiClient.Commands.Create;

public class CreateRequest<TSelector> : RequestBase where TSelector : Enum
{
    internal override string Path => "/api/raw/v1/export/create.json";

    private CreateRequest(CreateEventBase<TSelector> eventType)
    {
        ExportInformation = eventType;
    }

    public CreateRequest(
        CreateEventBase<TSelector> eventType,
        DateOnly dateFrom,
        DateOnly dateTo
    ) : this(eventType)
    {
        Guard.ValidDatesInterval(dateFrom, dateTo);

        DateFrom = dateFrom;
        DateTo = dateTo;
    }

    public CreateRequest(
        CreateEventBase<TSelector> eventType,
        DateTime timestampFrom,
        DateTime timestampTo
    ) : this(eventType)
    {
        Guard.ValidTimestampsInterval(timestampFrom, timestampTo);
        TimestampFrom = new UnixTimestamp(timestampFrom);
        TimestampTo = new UnixTimestamp(timestampTo);
    }

    /// <summary>
    /// Filter by app id
    /// <remarks>
    /// When you use <see cref="AppId"/> and <see cref="SdkKey"/> filters simultaneously, you get data that meet at least one condition
    /// </remarks>
    /// </summary>
    [QueryCustomArray, QueryName("idApp")]
    public ICollection<int> AppId { get; init; }

    /// <summary>
    /// Filter by SDK keys
    /// <remarks>
    /// When you use <see cref="AppId"/> and <see cref="SdkKey"/> filters simultaneously, you get data that meet at least one condition
    /// </remarks>
    /// </summary>
    [QueryCustomArray, QueryName("SDKKey")]
    public ICollection<int> SdkKey { get; init; }

    /// <summary>
    /// Filter by account id
    /// </summary>
    [QueryName("idAccount")]
    public ICollection<int> AccountId { get; init; }

    /// <summary>
    /// Filter by tracking link id
    /// </summary>
    [QueryName("idAd")]
    public ICollection<int> AdId { get; init; }

    /// <summary>
    /// Filter by campaign id
    /// </summary>
    [QueryName("idCampaign")]
    public ICollection<int> CampaignId { get; init; }

    /// <summary>
    /// Filter by country id
    /// </summary>
    [QueryName("idCountry")]
    public ICollection<Country> CountryId { get; init; }

    /// <summary>
    /// Filter by project id
    /// </summary>
    [QueryName("idProject")]
    public ICollection<int> ProjectId { get; init; }

    /// <summary>
    /// Event type, selectors and event - specific data
    /// </summary>
    public CreateEventBase<TSelector> ExportInformation { get; init; }

    /// <summary>
    /// Filter by date, from which the export begins
    /// <remarks>
    /// Cannot be less than 1970-01-01; cannot be more than the current date; must not be more than <see cref="DateTo"/>; use with the timezone parameter to set the correct timezone (<see cref="Timezone.EuropeMoscow"/>, by default)
    /// </remarks>
    /// </summary>
    [QueryName("dateFrom")]
    public DateOnly DateFrom { get; }

    /// <summary>
    /// Filter by date to which the export complete
    /// <remarks>
    /// Cannot be more than the current date;
    /// must not be less than <see cref="DateFrom"/>; use with the timezone parameter to set the correct timezone (<see cref="Timezone.EuropeMoscow"/>, by default)
    /// </remarks>
    /// </summary>
    [QueryName("dateTo")]
    public DateOnly DateTo { get; }

    /// <summary>
    /// Filter by event timestamp from which the export begins
    /// <remarks>
    /// Cannot be more than the current timestamp; must not be more than <see cref="TimestampTo"/>
    /// </remarks>
    /// </summary>
    [QueryName("tsFrom")]
    public UnixTimestamp TimestampFrom { get; }

    /// <summary>
    /// Filter by event timestamp to which the export complete
    /// <remarks>
    /// Cannot be more than the current timestamp; must not be less than <see cref="TimestampFrom"/>
    /// </remarks>
    /// </summary>
    [QueryName("tsTo")]
    public UnixTimestamp TimestampTo { get; }

    /// <summary>
    /// Filter by timestamp of event appearance in the system, from which the export begins
    /// <remarks>
    /// Must be less than the current timestamp minus 3 hours; must not be more than <see cref="AvailabilityTimestampTo"/>
    /// </remarks>
    /// </summary>
    [QueryName("availabilityTsFrom")]
    public UnixTimestamp AvailabilityTimestampFrom { get; init; }

    /// <summary>
    /// Filter by timestamp of event appearance in the system to which the export complete
    /// <remarks>
    /// Must be less than the current timestamp minus 3 hours; must not be less than <see cref="AvailabilityTimestampFrom"/>
    /// </remarks>
    /// </summary>
    [QueryName("availabilityTsTo")]
    public UnixTimestamp AvailabilityTimestampTo { get; init; }

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
    public ICollection<int> PartnerId { get; init; }
}