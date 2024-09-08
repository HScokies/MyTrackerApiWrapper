using System;

namespace MyTrackerApiWrapper.Helpers;

internal static class ReflectionHelpers
{
    public static bool IsInitialized(object value)
    {
        if (value is null)
            return false;

        var type = value.GetType();
        if (type.TypeInitializer is {} initializer)
        {
            return value.Equals(initializer.Invoke(null, null)) is false;
        }

        if (type.IsArray)
        {
            return ((Array)value).Length > 0;
        }
        return value.Equals(Activator.CreateInstance(type)) is false;
    }
}