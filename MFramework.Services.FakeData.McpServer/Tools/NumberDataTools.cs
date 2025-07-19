using MFramework.Services.FakeData;
using ModelContextProtocol.Server;
using System.ComponentModel;

/// <summary>
/// Provides utility methods for generating random numeric values.
/// </summary>
/// <remarks>This class includes methods for generating random integers and doubles, with options to specify
/// minimum and maximum bounds for integer generation. It is designed for use in scenarios where random numeric data is
/// required.</remarks>
internal class NumberDataTools
{

    [McpServerTool]
    [Description("Generates a random double number.")]
    public double GetDouble()
    {
        return NumberData.GetDouble();
    }

    [McpServerTool]
    [Description("Generates a random int number between 0 and max integer value.")]
    public int GetNumber()
    {
        return NumberData.GetNumber();
    }

    [McpServerTool]
    [Description("Generates a random int number between 0 and max value.")]
    public int GetNumber([Description("Max value.")] int max)
    {
        return NumberData.GetNumber(max);
    }

    [McpServerTool]
    [Description("Generates a random int number between min and max value.")]
    public int GetNumber([Description("Min value.")] int min, [Description("Max value.")] int max)
    {
        return NumberData.GetNumber(min, max);
    }

}
