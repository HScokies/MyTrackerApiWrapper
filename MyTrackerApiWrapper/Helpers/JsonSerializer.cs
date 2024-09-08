using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;

namespace MyTrackerApiWrapper.Helpers;

internal static class JsonSerializer
{
    public static async Task<T> Deserialize<T>(this HttpContent content)
    {
        await using var ms = await content.ReadAsStreamAsync();
        var serializer = new DataContractJsonSerializer(typeof(T));
        return (T)serializer.ReadObject(ms)!;
    }
}