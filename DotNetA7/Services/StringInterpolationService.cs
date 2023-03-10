using DotNetA7.Utils;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;

namespace DotNetA7.Services;

public class StringInterpolationService : IStringInterpolationService
{
    private readonly ISystemDate _date;
    private readonly ILogger<IStringInterpolationService> _logger;

    public StringInterpolationService(ISystemDate date, ILogger<IStringInterpolationService> logger)
    {
        _date = date;
        _logger = logger;
        _logger.Log(LogLevel.Information, "Executing the StringInterpolationService");
    }

    //1. January 22, 2019 (right aligned in a 40 character field)
    public string Number01()
    {
        var date = _date.Now.ToString("MMMM dd, yyyy");
        var answer = $"{date,40}";
        Console.WriteLine($"1. {answer}");

        return answer;
    }

    public string Number02()
    {
        string answer = $"{_date.Now:yyyy.MM.dd}";
        Console.WriteLine($"2. {answer}");

        return answer;
    }

    public string Number03()
    {
        string answer = $"{_date.Now:'Day' dd 'of' MMMM, yyyy}";
        Console.WriteLine($"3. {answer}");

        return answer;
    }

    public string Number04()
    {
        string answer = $"{_date.Now:'Year:' yyyy, 'Month:' MM, 'Day:' dd}";
        Console.WriteLine($"4. {answer}");

        return answer;
    }

    public string Number05()
    {
        string answer = $"{_date.Now,10:dddd}";
        Console.WriteLine($"5. {answer}");

        return answer;
    }

    public string Number06()
    {
        string answer = $"{_date.Now,10:hh:mm tt}{_date.Now,10:dddd}";
        Console.WriteLine($"6. {answer}");

        return answer;
    }

    public string Number07()
    {
        string answer = $"{_date.Now:'h:'hh, 'm:'mm, 's:'ss}";
        Console.WriteLine($"7. {answer}");

        return answer;
    }

    public string Number08()
    {
        string answer = $"{_date.Now:yyyy.MM.dd.hh.mm.ss}";
        Console.WriteLine($"8. {answer}");

        return answer;
    }

    public string Number09()
    {
        var pi = Math.PI;
        string answer = $"{pi:c}";
        Console.WriteLine($"9. {answer}");

        return answer;
    }

    public string Number10()
    {
        var pi = Math.PI;
        string answer = $"{pi,10:f3}";
        Console.WriteLine($"10. {answer}");

        return answer;
    }

    public string Number11()
    {
        string answer = 2023.ToString("X");
        Console.WriteLine($"11. {answer}");

        return answer;
    }
}
