﻿namespace UrlShortener.Shared.Services.Implementations;

public class DateTimeProvider : IDateTimeProvider
{
    public DateTimeOffset GetCurrentDateTime()
    {
        return DateTimeOffset.UtcNow;
    }
}
