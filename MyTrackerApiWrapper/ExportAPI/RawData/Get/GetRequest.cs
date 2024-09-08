using MyTrackerApiWrapper.Attributes;

namespace MyTrackerApiWrapper.ExportAPI.RawData.Get;

public sealed class GetRequest : RequestBase
{
    internal override string Path => "/api/raw/v1/export/get.json";
    
    [QueryName("idRawExport")]
    public int Id { get; init; }
}