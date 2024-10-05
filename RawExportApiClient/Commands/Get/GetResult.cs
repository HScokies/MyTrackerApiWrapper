using System.Collections.Generic;
using RawExportApiClient.DataTypes;
using RawExportApiClient.Enums;

namespace RawExportApiClient.Commands.Get;

public sealed class GetResult
{
    public bool IsSuccess { get; init; }

    public bool IsCompleted { get; init; }
    public string Progress { get; init; }
    public ExportRawDataStatus ReportStatus { get; init; }
    public string Message { get; init; }
    public IEnumerable<ExportData> Files { get; init; }
}