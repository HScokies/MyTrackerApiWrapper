using MyTrackerApiWrapper.Enumerations.Dictionaries;
using MyTrackerApiWrapper.Enumerations.Dictionaries.Selectors;
using MyTrackerApiWrapper.ExportAPI.RawData;
using MyTrackerApiWrapper.ExportAPI.RawData.Create.Request;
using MyTrackerApiWrapper.ExportAPI.RawData.Create.Request.EventTypes;
using MyTrackerApiWrapper.ExportAPI.RawData.Get;
using MyTrackerApiWrapper.ExportAPI.ReportDownloader;
using MyTrackerApiWrapper.Helpers;


var apiClient = new ApiClient(new HttpClient
{
    BaseAddress = new Uri("https://tracker.my.com")
}, 0, "API_KEY");
var exportApiClient = new ExportApiClient(apiClient);

// Create export task
var selectors = new CreateCustomEvent(
    CustomEvents.DeviceId,
    CustomEvents.DeviceModelTitle,
    CustomEvents.CustomUserId,
    CustomEvents.InstanceId,
    CustomEvents.EventName,
    CustomEvents.ParamsName,
    CustomEvents.ParamsValue,
    CustomEvents.EventTimestamp,
    CustomEvents.PartnerId,
    CustomEvents.PartnerTitle,
    CustomEvents.CampaignId,
    CustomEvents.CampaignTitle);
var request = new CreateRequest<CustomEvents>(selectors, new DateOnly(2024, 08, 26), new DateOnly(2024, 09, 02))
{
    Timezone = Timezone.Utc,
    AccountId = new[] { 33629 },
    ProjectId = new[] { 64743 },
    AppId = new[] { 86972 }
};
var createResult = await exportApiClient.Create(request);
if (!createResult.IsSuccess)
{
    Console.WriteLine("Failed to create export data:" + createResult.Message);
    return;
}

// GET export status
var getResult = await exportApiClient.Get(new GetRequest
{
    Id = createResult.ExportRequestId!.Value
});
while (getResult.IsSuccess && !getResult.IsCompleted)
{
    await Task.Delay(TimeSpan.FromSeconds(10));
    getResult = await exportApiClient.Get(new GetRequest
    {
        Id = createResult.ExportRequestId!.Value
    });
}
if (!getResult.IsSuccess)
{
    Console.WriteLine("Failed to get export data:" + getResult.Message);
    return;
}

// Download report
var downloadRequest = new DownloadRequest(getResult.Files.First().DownloadLink)
{
    DownloadPath = "/home/hscokies/Downloads/output.csv"
};
var fileData = await exportApiClient.Download(downloadRequest);
if (!fileData.IsSuccess)
{
    Console.WriteLine("Failed to download file");
    return;
}

using var sr = new StreamReader(fileData.File);
Console.WriteLine("Begin csv file");
while (!sr.EndOfStream)
{
    var line = sr.ReadLine();
    Console.WriteLine(line);
}

Console.WriteLine("End csv file");


Console.ReadLine();