namespace RawExportApiClient.Commands.Create;

public sealed class CreateResult
{
    public bool IsSuccess { get; init; }

    public int? ExportRequestId { get; init; }
    public string Message { get; init; }
}