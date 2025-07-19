using MFramework.Services.FakeData;
using ModelContextProtocol.Server;
using System.ComponentModel;

/// <summary>
/// Provides utility methods for generating random text data, such as alphabetical strings, alphanumeric strings,
/// numeric strings, sentences, and substrings based on specific patterns or character sets.
/// </summary>
/// <remarks>This class is designed to facilitate the creation of random text data for various use cases, such as
/// testing or generating placeholder content. Each method offers a specific type of text generation, allowing
/// customization through parameters like length, character sets, or patterns.</remarks>
internal class TextDataTools
{
    [McpServerTool]
    [Description("Generates a random double number.")]
    public string GetAlphabetical([Description("Character number.")] int length)
    {
        return TextData.GetAlphabetical(length);
    }

    [McpServerTool]
    [Description("Generates a random double number.")]
    public string GetAlphaNumeric([Description("Character number.")] int length)
    {
        return TextData.GetAlphaNumeric(length);
    }

    [McpServerTool]
    [Description("Generates a random double number.")]
    public string GetNumeric([Description("Character number.")] int length)
    {
        return TextData.GetNumeric(length);
    }

    [McpServerTool]
    [Description("Generates a random double number.")]
    public string GetPatternString([Description("String pattern.")] string pattern)
    {
        return TextData.GetPatternString(pattern);
    }

    [McpServerTool]
    [Description("Generates a random double number.")]
    public string GetSentence()
    {
        return TextData.GetSentence();
    }

    [McpServerTool]
    [Description("Generates a random double number.")]
    public string GetSentences([Description("Sentence number.")] int count)
    {
        return TextData.GetSentences(count);
    }

    [McpServerTool]
    [Description("Generates a random double number.")]
    public string GetSubString([Description("Character number.")] int length, [Description("Characters.")] string characters)
    {
        return TextData.GetSubString(length, characters);
    }
}