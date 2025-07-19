using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Reflection;

var builder = Host.CreateApplicationBuilder(args);

// Configure all logs to go to stderr (stdout is used for the MCP protocol messages).
builder.Logging.AddConsole(o => o.LogToStandardErrorThreshold = LogLevel.Trace);

// Add the MCP services: the transport to use (stdio) and the tools to register.
builder.Services
    .AddMcpServer()
    .WithStdioServerTransport()
    .WithTools<ArrayDataTools>()
    .WithTools<BooleanDataTools>()
    .WithTools<DateTimeDataTools>()
    .WithTools<EnumDataTools>()
    .WithTools<NameDataTools>()
    .WithTools<NetworkDataTools>()
    .WithTools<NumberDataTools>()
    .WithTools<PhoneNumberDataTools>()
    .WithTools<PlaceDataTools>()
    .WithTools<TextDataTools>();

await builder.Build().RunAsync();
