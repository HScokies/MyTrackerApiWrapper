using System;
using MyTrackerApiWrapper.DataTypes;

namespace MyTrackerApiWrapper.ExportAPI.RawData.Get.Result;

public sealed class ExportData
{
    public Uri DownloadLink { get; init; }
    public UnixTimestamp Expires { get; init; }
}