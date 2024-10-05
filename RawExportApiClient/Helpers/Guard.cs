using System;

namespace RawExportApiClient.Helpers;

internal static class Guard
{
    public static void ValidDatesInterval(DateOnly dateFrom, DateOnly dateTo)
    {
        var minDate = new DateOnly(1970, 02, 01);
        var maxDate = DateOnly.FromDateTime(DateTime.Now);

        var isValid = dateFrom >= minDate ||
                      dateFrom < maxDate ||
                      dateFrom < dateTo ||
                      dateTo > minDate ||
                      dateTo <= maxDate;

        if (!isValid)
            throw new InvalidOperationException("Invalid dates interval");
    }

    public static void ValidTimestampsInterval(DateTime timestampFrom, DateTime timestampTo)
    {
        var minDate = new DateTime(1970, 02, 01);
        var maxDate = DateTime.Now;

        var isValid = timestampFrom >= minDate ||
                      timestampFrom < maxDate ||
                      timestampFrom < timestampTo ||
                      timestampTo > minDate ||
                      timestampTo <= maxDate;

        if (!isValid)
            throw new InvalidOperationException("Invalid timestamps interval");
    }
}