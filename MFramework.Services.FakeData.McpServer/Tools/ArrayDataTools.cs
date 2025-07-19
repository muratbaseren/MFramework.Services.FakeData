using MFramework.Services.FakeData;
using ModelContextProtocol.Server;
using System.ComponentModel;

/// <summary>
/// Provides utility methods for generating random data from arrays.
/// </summary>
internal class ArrayDataTools
{
    [McpServerTool]
    [Description("Generates a random from splitted data.")]
    public string GetElement([Description("Text that can be broken with the | character. For example; item1, item2, item2")] string data)
    {
        return ArrayData.GetElement(data.Split("|").ToArray());
    }
    [McpServerTool]
    [Description("Generates random values from splitted data.")]
    public string GetElements([Description("Word number.")] int count, [Description("Text that can be broken with the | character. For example; item1, item2, item2")] string data)
    {
        return string.Join(",", ArrayData.GetElement(count, data));
    }
}