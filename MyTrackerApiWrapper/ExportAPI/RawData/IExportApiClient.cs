using System;
using System.Threading.Tasks;
using MyTrackerApiWrapper.ExportAPI.RawData.Cancel;
using MyTrackerApiWrapper.ExportAPI.RawData.Create;
using MyTrackerApiWrapper.ExportAPI.RawData.Create.Request;
using MyTrackerApiWrapper.ExportAPI.RawData.Get;
using MyTrackerApiWrapper.ExportAPI.RawData.Get.Result;

namespace MyTrackerApiWrapper.ExportAPI.RawData;

public interface IExportApiClient
{
    Task<RawDataCreateResult> Create<TSelector>(CreateRequest<TSelector> request) where TSelector : Enum;
    Task<RawDataGetResult> Get(GetRequest request);
    Task<RawDataCancelResult> Cancel(CancelRequest request);
}