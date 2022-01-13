using System;

namespace ThomasWeller.EasyAppVerif
{
    enum Severity
    {
        Ignore = 0,
        Information = 3,
        Warning = 15,
        Error = 63
    }

    [Flags]
    enum Flavor
    {
        None = 32,
        StopOnce = 16,
        NonContinuable = 2,
    }

    [Flags]
    enum ErrorReport
    {
        Active = 1,
        NoBreak = 0,
        Breakpoint = 32, // do not combine with Exception
        Exception = 64, // do not combine with Breakpoint
        LogToFile = 128,
        LogStackTrace = 256
    }

    // Inactive = Severity.Ignore + Flavor.None + !ErrorReport.Active

    class ApplicationVerifierStop
    {
    }
}
