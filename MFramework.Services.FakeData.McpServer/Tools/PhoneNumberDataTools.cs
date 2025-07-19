using MFramework.Services.FakeData;
using ModelContextProtocol.Server;
using System.ComponentModel;

/// <summary>
/// Provides utility methods for generating random phone numbers in various formats.
/// </summary>
/// <remarks>This class includes methods for generating international, generic, and US-specific phone numbers in
/// predefined formats. The generated phone numbers are random and do not correspond to real-world phone
/// numbers.</remarks>
internal class PhoneNumberDataTools
{
    [McpServerTool]
    [Description("Generates a random international phone number.")]
    public string GetInternationalPhoneNumber()
    {
        return TextData.GetPatternString("00##-###-###-####");
    }

    [McpServerTool]
    [Description("Generates a random phone number.")]
    public string GetPhoneNumber()
    {
        return TextData.GetPatternString("01###-######");
    }

    [McpServerTool]
    [Description("Generates a random US phone number.")]
    public string GetUsPhoneNumber()
    {
        return TextData.GetPatternString("###-###-####");
    }
}