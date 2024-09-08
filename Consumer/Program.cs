using MyTrackerApiWrapper.Enumerations.Dictionaries;
using MyTrackerApiWrapper.Enumerations.Dictionaries.Selectors;
using MyTrackerApiWrapper.ExportAPI.RawData;
using MyTrackerApiWrapper.ExportAPI.RawData.Cancel;
using MyTrackerApiWrapper.ExportAPI.RawData.Create.Request;
using MyTrackerApiWrapper.ExportAPI.RawData.Create.Request.EventTypes;
using MyTrackerApiWrapper.ExportAPI.RawData.Get;
using MyTrackerApiWrapper.Helpers;


var apiClient = new ApiClient(new HttpClient
{
    BaseAddress = new Uri("https://tracker.my.com")
}, 0, "API_KEY");
var exportApiClient = new ExportApiClient(apiClient);

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

var getResult = await exportApiClient.Get(new GetRequest
{
    Id = createResult.ExportRequestId!.Value
});

var cancelResult = await exportApiClient.Cancel(new CancelRequest
{
    Id = 19788637
});


Console.ReadLine();