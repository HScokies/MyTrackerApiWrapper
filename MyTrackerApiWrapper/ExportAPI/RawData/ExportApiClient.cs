using System;
using System.Linq;
using System.Threading.Tasks;
using MyTrackerApiWrapper.DataTypes;
using MyTrackerApiWrapper.DataTypes.RawData;
using MyTrackerApiWrapper.ExportAPI.RawData.Cancel;
using MyTrackerApiWrapper.ExportAPI.RawData.Create;
using MyTrackerApiWrapper.ExportAPI.RawData.Create.Request;
using MyTrackerApiWrapper.ExportAPI.RawData.Get;
using MyTrackerApiWrapper.ExportAPI.RawData.Get.Result;
using MyTrackerApiWrapper.Helpers;

namespace MyTrackerApiWrapper.ExportAPI.RawData;

public sealed class ExportApiClient : IExportApiClient
{
    private readonly ApiClient _apiClient;

    public ExportApiClient(ApiClient apiClient)
    {
        _apiClient = apiClient;
    }
    
    
    public async Task<RawDataCreateResult> Create<TSelector>(CreateRequest<TSelector> request) where TSelector : Enum
    {
        var response = await _apiClient.PostAsync<RawDataResponse>(request);

        return new RawDataCreateResult
        {
            IsSuccess = response.Code == 200,
            ExportRequestId = response.Result?.RawExportId,
            Message = response.Result?.Error?.Message ?? response.Message
        };
    }

    public async Task<RawDataGetResult> Get(GetRequest request)
    {
        var response = await _apiClient.GetAsync<RawDataResponse>(request);

        return new RawDataGetResult
        {
            IsSuccess = response.Code == 200,
            IsCompleted = response.Result?.Files?.Any() ?? false,
            Progress = response.Result?.ExportProgress,
            ReportStatus = response.Result?.ReportStatus switch
            {
                "In progress" => ExportRawDataStatus.InProgress,
                "Error occurred" => ExportRawDataStatus.Error,
                "User error occurred" => ExportRawDataStatus.UserError,
                "Canceled by user" => ExportRawDataStatus.Canceled,
                _ => ExportRawDataStatus.Undocumented
            },
            Message = response?.Result?.Error?.Message ?? response?.Result?.ErrorMessage ?? response.Message,
            Files = response.Result?.Files?.Select(x => new ExportData
            {
                DownloadLink = x.DownloadLink,
                Expires = new UnixTimestamp(x.Expires)
            })
        };
    }

    public async Task<RawDataCancelResult> Cancel(CancelRequest request)
    {
        var response = await _apiClient.GetAsync<RawDataResponse>(request);

        return new RawDataCancelResult
        {
            IsSuccess = response.Code == 200,
            Message = response.Result?.Error?.Message ?? response.Result?.CancelMessage ?? response.Message
        };
    }
}