using MFramework.Services.FakeData;
using ModelContextProtocol.Server;
using System.ComponentModel;

/// <summary>
/// Provides utility methods for generating random enum values.
/// </summary>
internal class EnumDataTools
{
    [McpServerTool]
    [Description("Generates a random enum value.")]
    public string GetElement()
    {
        return EnumData.GetElement<string>().ToString();
    }
}