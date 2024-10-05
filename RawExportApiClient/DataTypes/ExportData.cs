using System;

namespace RawExportApiClient.DataTypes;

public sealed class ExportData
{
    public Uri DownloadLink { get; init; }
    public UnixTimestamp Expires { get; init; }
}