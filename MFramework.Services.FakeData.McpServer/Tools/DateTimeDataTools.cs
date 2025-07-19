using MFramework.Services.FakeData;
using ModelContextProtocol.Server;
using System.ComponentModel;

/// <summary>
/// Provides utility methods for generating random DateTime values.
/// </summary>
internal class DateTimeDataTools
{
    [McpServerTool]
    [Description("Generates a random DateTime.")]
    public string GetDatetime()
    {
        return DateTimeData.GetDatetime().ToString();
    }
    [McpServerTool]
    [Description("Generates a random DateTime between two dates.")]
    public string GetDatetime([Description("From date.")] DateTime from, [Description("To date.")] DateTime to)
    {
        return DateTimeData.GetDatetime(from, to).ToString();
    }
}