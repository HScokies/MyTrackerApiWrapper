// See https://aka.ms/new-console-template for more information

using MyTrackerApiWrapper.Enumerations.Dictionaries;
using MyTrackerApiWrapper.Enumerations.Dictionaries.Selectors;
using MyTrackerApiWrapper.ExportAPI.RawData.Create.Request;
using MyTrackerApiWrapper.ExportAPI.RawData.Create.Request.EventTypes;
using MyTrackerApiWrapper.Helpers;


//DateTime.UtcNow.AddDays(-2)), DateTime.UtcNow
// idDevice,idDeviceModelTitle,customUserId,instanceId,eventName,params.name,params.value,tsEvent,idPartner,idPartnerTitle,idCampaign,idCampaignTitle
var selectors = new CreateCustomEvent(CustomEvents.DeviceId, CustomEvents.DeviceModelTitle, CustomEvents.CustomUserId,
    CustomEvents.InstanceId, CustomEvents.EventName, CustomEvents.ParamsName, CustomEvents.ParamsValue,
    CustomEvents.EventTimestamp, CustomEvents.PartnerId, CustomEvents.PartnerTitle, CustomEvents.CampaignId,
    CustomEvents.CampaignTitle);

var request = new CreateRequest<CustomEvents>(selectors, new DateOnly(2024, 08, 26), new DateOnly(2024, 09, 02))
{
    Timezone = Timezone.Utc,
};

var baseUrl = "https://tracker.my.com";
var query = request.ToQuery();
var url = UrlProvider.BuildUrl(baseUrl, request.GetPath(), query);

const int userId = 0;
const string apiKey = "HASH_KEY";

var signature = new AuthenticationProvider(apiKey).CreateSignature(HttpMethod.Post, url.ToString());

var client = new HttpClient();
client.DefaultRequestHeaders.Add("Authorization", "AuthHMAC " + userId + ":" + signature);

var response = await client.PostAsync(url, null);
var body = await response.Content.ReadAsStringAsync();
Console.Write(body);
Console.ReadLine();