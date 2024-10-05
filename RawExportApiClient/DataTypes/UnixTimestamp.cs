using System;

namespace RawExportApiClient.DataTypes;

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

    public override bool Equals(object obj)
    {
        if (obj is null)
            return false;

        var type = GetType();
        if (obj.GetType() != type)
            return false;

        return Timestamp == ((UnixTimestamp)obj).Timestamp;
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override string ToString()
    {
        return Timestamp.ToString();
    }
}