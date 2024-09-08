using MyTrackerApiWrapper.Attributes;

namespace MyTrackerApiWrapper.ExportAPI.RawData.Cancel;

public sealed class CancelRequest : RequestBase
{
    internal override string Path => "/api/raw/v1/export/cancel.json";
    
    [QueryName("idRawExport")]
    public int Id { get; init; }
}