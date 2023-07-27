

using System.Drawing;
using API.Controllers;

namespace API;

public class WeatherForecast
{
    public DateOnly Date { get; set; }

    public int TemperatureC { get; set; }

    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    public string? Summary { get; set; }

}
public class Car 
{
public int NumberOfTires {get;set;}
public int NumberOfDoors  {get;set;}
public int EngineSize {get;set;}

}

