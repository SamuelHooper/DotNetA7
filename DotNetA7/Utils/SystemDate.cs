using System;

namespace DotNetA7.Utils;

public class SystemDate : ISystemDate
{
    public DateTime Now => DateTime.Now;
}
