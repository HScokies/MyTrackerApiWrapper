using System;

namespace MyTrackerApiWrapper.DataTypes;
/// <summary>
/// Represents a Unix timestamp in seconds
/// </summary>
public readonly struct UnixTimestamp
{
    public readonly long Timestamp;
    public readonly DateTime DateTime;
    public UnixTimestamp(DateTime timestamp)
    {
        DateTime = timestamp;
        Timestamp = ((DateTimeOffset)timestamp).ToUnixTimeSeconds();
    }

    public UnixTimestamp(long timestamp)
    {
        Timestamp = timestamp;
        DateTime = DateTimeOffset.FromUnixTimeSeconds(timestamp).DateTime;
    }
    

    public override string ToString()
    {
        return Timestamp.ToString();
    }
}