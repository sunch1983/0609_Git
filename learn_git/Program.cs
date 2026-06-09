//last_update:20260609
using Scalar.AspNetCore;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast =  Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast");

app.MapGet("/currenttime", () =>
{
    var now = DateTime.Now;
    var utcNow = DateTime.UtcNow;
    
    var timeInfo = new CurrentTimeInfo(
        LocalTime: now,
        UtcTime: utcNow,
        TimeZone: TimeZoneInfo.Local.DisplayName,
        UnixTimestamp: DateTimeOffset.Now.ToUnixTimeSeconds(),
        DayOfWeek: now.DayOfWeek.ToString(),
        DayOfYear: now.DayOfYear
    );
    
    return timeInfo;
})
.WithName("GetCurrentTime")
.WithDescription("取得當前時間資訊，包含本地時間、UTC 時間、時區等");

app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}

record CurrentTimeInfo(
    DateTime LocalTime,
    DateTime UtcTime,
    string TimeZone,
    long UnixTimestamp,
    string DayOfWeek,
    int DayOfYear
);
