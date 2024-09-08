using System;
using System.Threading.Tasks;
using MyTrackerApiWrapper.ExportAPI.RawData.Create.Request;

namespace MyTrackerApiWrapper.ExportAPI.RawData;

public interface IExportApiClient
{
    Task Create<TSelector>(CreateRequest<TSelector> request) where TSelector : Enum;
}