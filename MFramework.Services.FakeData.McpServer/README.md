# MCP Sunucu : Fake Data Generator

Bu, Model Baðlam Protokolü (MCP) için bir feka veri üreteci MCP sunucusudur. Test veya geliþtirme gibi çeþitli uygulamalarda kullanýlabilen rastgele sayýlar ve dizeler üretmenin basit bir yolunu saðlar.

## Yerel(Local) olarak kullanarak

Bu MCP sunucusunu, derlenmiþ bir MCP sunucu paketi kullanmadan kaynak kodundan (yerel olarak) test etmek için, GitHub reposunu indridikten sonra IDE'nizi projeyi doðrudan `dotnet run` kullanarak çalýþtýracak þekilde yapýlandýrabilirsiniz.

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

Yapýlandýrýldýktan sonra, Copilot Chat'ten rastgele bir sayý isteyebilirsiniz; örneðin, ``Bana 3 rastgele isim ver``. `MFramework.Services.FakeData.McpServer` MCP sunucusunda `get_first_name` aracýný kullanmanýz istenecek ve sonuçlar gösterilecektir.

## NuGet.org'dan MCP Sunucusunu Kullanma

MCP sunucu paketi NuGet.org'da yayýnlandýktan sonra, tercih ettiðiniz IDE'de yapýlandýrabilirsiniz. Hem VS Code hem de Visual Studio, MCP sunucu paketini NuGet.org'dan indirip yüklemek için `dnx` komutunu kullanýr. (Bu MCP tool u kalýcý olmadan indirip o an uygulama gibi çalýþtýrmak için kullanýlýr.) 

Esas uygulama alaný aþaðýdaki adýmlarý izleyerek MCP sunucusunu yapýlandýrabilirsiniz: Böylece IDE/Editör MCP sunucusunu kullanabilir.

- **VS Code**: `<WORKSPACE DIRECTORY>/.vscode/mcp.json` dosyasý oluþturun
- **Visual Studio**: `<SOLUTION DIRECTORY>\.mcp.json` dosyasý oluþturun

Hem VS Code hem de Visual Studio için yapýlandýrma dosyasý aþaðýdaki sunucu tanýmýný kullanýr:

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

Bir den fazla MCP Tool kullanacaksanýz `servers` bölümüne birden fazla MCP sunucu tanýmý ekleyebilirsiniz. Her sunucu için `type`, `command`, `args` ve `env` gibi alanlarý belirlemeniz gerekir.

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
    // Diðer MCP sunucularý için benzer tanýmlar ekleyebilirsiniz
    // ...
  }
}
```