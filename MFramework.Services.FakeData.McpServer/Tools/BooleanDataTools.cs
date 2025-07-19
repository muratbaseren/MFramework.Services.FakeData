using MFramework.Services.FakeData;
using ModelContextProtocol.Server;
using System.ComponentModel;

/// <summary>
/// Provides utility methods for working with boolean data.
/// </summary>
/// <remarks>This class includes methods for generating and manipulating boolean values.</remarks>
internal class BooleanDataTools
{
    [McpServerTool]
    [Description("Generates a random boolean value.")]
    public bool GetBoolean()
    {
        return BooleanData.GetBoolean();
    }
}