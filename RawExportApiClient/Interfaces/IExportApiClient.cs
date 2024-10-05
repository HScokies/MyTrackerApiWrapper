using System;
using System.Threading.Tasks;
using RawExportApiClient.Commands.Cancel;
using RawExportApiClient.Commands.Create;
using RawExportApiClient.Commands.Download;
using RawExportApiClient.Commands.Get;

namespace RawExportApiClient.Interfaces;

public interface IExportApiClient
{
    Task<CreateResult> Create<TSelector>(CreateRequest<TSelector> request) where TSelector : Enum;
    Task<GetResult> Get(GetRequest request);
    Task<CancelResult> Cancel(CancelRequest request);
    Task<DownloadResult> Download(DownloadRequest request);
}