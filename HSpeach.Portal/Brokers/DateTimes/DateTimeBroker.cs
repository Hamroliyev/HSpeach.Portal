// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE ALL GOOD HEART Developers
// ---------------------------------------------------------------

using System;

namespace HSpeach.Portal.Brokers.DateTimes
{
    public class DateTimeBroker
    {
        public DateTimeOffset ConvertToDateTimeOffSet(int totalSeconds) =>
            DateTimeOffset.FromUnixTimeSeconds(totalSeconds);
    }
}
