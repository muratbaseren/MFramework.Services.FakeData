using MFramework.Services.FakeData;
using ModelContextProtocol.Server;
using System.ComponentModel;

/// <summary>
/// Provides utility methods for generating random place-related data, such as addresses, city names, and postal codes.
/// </summary>
/// <remarks>This class includes methods for generating random data related to geographical locations, such as
/// addresses, cities,  countries, and postal codes. It is intended for use in scenarios where mock or placeholder
/// location data is required,  such as testing or data generation tools.</remarks>
internal class PlaceDataTools
{
    [McpServerTool]
    [Description("Generates a random address.")]
    public string GetAddress()
    {
        return PlaceData.GetAddress();
    }

    [McpServerTool]
    [Description("Generates a random city name.")]
    public string GetCity()
    {
        return PlaceData.GetCity();
    }

    [McpServerTool]
    [Description("Generates a random country name.")]
    public string GetCountry()
    {
        return PlaceData.GetCountry();
    }

    [McpServerTool]
    [Description("Generates a random county name.")]
    public string GetCounty()
    {
        return PlaceData.GetCounty();
    }

    [McpServerTool]
    [Description("Generates a random postal code.")]
    public string GetPostCode()
    {
        return PlaceData.GetPostCode();
    }

    [McpServerTool]
    [Description("Generates a random state name.")]
    public string GetState()
    {
        return PlaceData.GetState();
    }

    [McpServerTool]
    [Description("Generates a random street name.")]
    public string GetStreetName()
    {
        return PlaceData.GetStreetName();
    }

    [McpServerTool]
    [Description("Generates a random zip code.")]
    public string GetZipCode()
    {
        return PlaceData.GetZipCode();
    }

    [McpServerTool]
    [Description("Generates a random street number.")]
    public int GetStreetNumber()
    {
        return PlaceData.GetStreetNumber();
    }
}