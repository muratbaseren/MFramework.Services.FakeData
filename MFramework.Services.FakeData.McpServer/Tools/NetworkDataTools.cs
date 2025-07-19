using MFramework.Services.FakeData;
using ModelContextProtocol.Server;
using System.ComponentModel;

/// <summary>
/// Provides tools for generating random network-related data, such as domains, email addresses, IP addresses, and MAC
/// addresses.
/// </summary>
/// <remarks>This class includes methods for generating random network-related data with optional customization,
/// such as specifying a domain name or providing first and last names for email generation. It is intended for use in
/// scenarios where mock or randomized network data is required, such as testing or simulation environments.</remarks>
internal class NetworkDataTools
{
    [McpServerTool]
    [Description("Generates a random domain.")]
    public string GetDomain()
    {
        return NetworkData.GetDomain();
    }

    [McpServerTool]
    [Description("Generates a random domain with name.")]
    public string GetDomain([Description("Custom domain name.")]string name)
    {
        return NetworkData.GetDomain(name);
    }

    [McpServerTool]
    [Description("Generates a random email address.")]
    public string GetEmail()
    {
        return NetworkData.GetEmail();
    }

    [McpServerTool]
    [Description("Generates a random email address with domain.")]
    public string GetEmail([Description("Custom domain name.")]string domain)
    {
        return NetworkData.GetEmail(domain);
    }

    [McpServerTool]
    [Description("Generates a random email address with first and last name.")]
    public string GetEmail([Description("First and last name for email address.")]string firstName, string lastName)
    {
        return NetworkData.GetEmail(firstName, lastName);
    }

    [McpServerTool]
    [Description("Generates a random ip address.")]
    public string GetIpAddress()
    {
        return NetworkData.GetIpAddress();
    }

    [McpServerTool]
    [Description("Generates a random mac address.")]
    public string GetMacAddress()
    {
        return NetworkData.GetMacAddress();
    }
}