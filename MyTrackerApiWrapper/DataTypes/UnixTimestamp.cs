namespace MyTrackerApiWrapper.DataTypes;
/// <summary>
/// Represents a Unix timestamp in seconds
/// </summary>
public readonly struct UnixTimestamp
{
    private readonly long _timestamp;

    private UnixTimestamp(DateTimeOffset offset)
    {
        _timestamp = offset.ToUnixTimeSeconds();
    }
    
    public UnixTimestamp(DateTime timestamp) : this((DateTimeOffset) timestamp)
    {
    }

    public override string ToString()
    {
        return _timestamp.ToString();
    }
}