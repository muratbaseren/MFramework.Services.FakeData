# MCP Sunucu : Fake Data Generator

Bu, Model Bağlam Protokolü (MCP) için bir feka veri üreteci MCP sunucusudur. Test veya geliştirme gibi çeşitli uygulamalarda kullanılabilen rastgele sayılar ve dizeler üretmenin basit bir yolunu sağlar.

## Nuget
**MFramework.Services.FakeData.McpServer** nuget paketini [inceleyebilirsiniz.](https://www.nuget.org/packages/MFramework.Services.FakeData.McpServer)

## Yerel(Local) olarak kullanarak

Bu MCP sunucusunu, derlenmiş bir MCP sunucu paketi kullanmadan kaynak kodundan (yerel olarak) test etmek için, GitHub reposunu indridikten sonra IDE'nizi projeyi doğrudan `dotnet run` kullanarak çalıştıracak şekilde yapılandırabilirsiniz.

```json
{
  "servers": {
    "MFramework.Services.FakeData.McpServer": {
      "type": "stdio",
      "command": "dotnet",
      "args": [
        "run",
        "--project",
        "<PATH TO PROJECT DIRECTORY>"
      ]
    }
  }
}
```

## MCP Sunucusunu Test Etme

Yapılandırıldıktan sonra, Copilot Chat'ten rastgele bir sayı isteyebilirsiniz; örneğin, ``Bana 3 rastgele isim ver``. `MFramework.Services.FakeData.McpServer` MCP sunucusunda `get_first_name` aracını kullanmanız istenecek ve sonuçlar gösterilecektir.

## NuGet.org'dan MCP Sunucusunu Kullanma

MCP sunucu paketi NuGet.org'da yayınlandıktan sonra, tercih ettiğiniz IDE'de yapılandırabilirsiniz. Hem VS Code hem de Visual Studio, MCP sunucu paketini NuGet.org'dan indirip yüklemek için `dnx` komutunu kullanır. (Bu MCP tool u kalıcı olmadan indirip o an uygulama gibi çalıştırmak için kullanılır.) 

Esas uygulama alanı aşağıdaki adımları izleyerek MCP sunucusunu yapılandırabilirsiniz: Böylece IDE/Editör MCP sunucusunu kullanabilir.

- **VS Code**: `<WORKSPACE DIRECTORY>/.vscode/mcp.json` dosyası oluşturun
- **Visual Studio**: `<SOLUTION DIRECTORY>\.mcp.json` dosyası oluşturun

Hem VS Code hem de Visual Studio için yapılandırma dosyası aşağıdaki sunucu tanımını kullanır:

```json
{
  "inputs": [],
  "servers": {
    "MFramework.Services.FakeData.McpServer": {
      "type": "stdio",
      "command": "dnx",
      "args": ["MFramework.Services.FakeData.McpServer@0.2.0", "--yes"],
      "env": {}
    }
  }
}
```

Bir den fazla MCP Tool kullanacaksanız `servers` bölümüne birden fazla MCP sunucu tanımı ekleyebilirsiniz. Her sunucu için `type`, `command`, `args` ve `env` gibi alanları belirlemeniz gerekir.

```json
{
  "inputs": [],
  "servers": {
    "MFramework.Services.FakeData.McpServer": {
      "type": "stdio",
      "command": "dnx",
      "args": ["MFramework.Services.FakeData.McpServer@0.2.0", "--yes"],
      "env": {}
    },
    // ...
    // Diğer MCP sunucuları için benzer tanımlar ekleyebilirsiniz
    // ...
  }
}
```
