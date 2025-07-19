using MFramework.Services.FakeData;
using ModelContextProtocol.Server;
using System.ComponentModel;

/// <summary>
/// Provides utility methods for generating random names and related data.
/// </summary>
/// <remarks>This class includes methods for generating various types of random names, such as first names, full
/// names, surnames, and names for specific domains like departments, titles, banks, and e-commerce categories. Each
/// method returns a randomly generated string appropriate to its purpose.</remarks>
internal class NameDataTools
{
    [McpServerTool]
    [Description("Generates a random first name.")]
    public string GetFirstName()
    {
        return NameData.GetFirstName();
    }

    [McpServerTool]
    [Description("Generates a random full name.")]
    public string GetFullName()
    {
        return NameData.GetFullName();
    }

    [McpServerTool]
    [Description("Generates a random male first name.")]
    public string GetMaleFirstName()
    {
        return NameData.GetMaleFirstName();
    }

    [McpServerTool]
    [Description("Generates a random surname.")]
    public string GetSurname()
    {
        return NameData.GetSurname();
    }

    [McpServerTool]
    [Description("Generates a random department name.")]
    public string GetDepartmentName()
    {
        return NameData.GetDepartmentName();
    }

    [McpServerTool]
    [Description("Generates a random title name.")]
    public string GetTitleName()
    {
        return NameData.GetTitleName();
    }

    [McpServerTool]
    [Description("Generates a random bank name.")]
    public string GetBankName()
    {
        return NameData.GetBankName();
    }

    [McpServerTool]
    [Description("Generates a random user name.")]
    public string GetUserName()
    {
        return NameData.GetUserName();
    }

    [McpServerTool]
    [Description("Generates a random brand name.")]
    public string GetCarBrandName()
    {
        return NameData.GetCarBrandName();
    }

    [McpServerTool]
    [Description("Generates a random category name.")]
    public string GetECommerceCategoryName()
    {
        return NameData.GetECommerceCategoryName();
    }

    [McpServerTool]
    [Description("Generates a random product name.")]
    public string GetECommerceProductName()
    {
        return NameData.GetECommerceProductName();
    }
}