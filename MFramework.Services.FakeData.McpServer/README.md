# MCP Sunucu : Fake Data Generator

Bu, Model Ba�lam Protokol� (MCP) i�in bir feka veri �reteci MCP sunucusudur. Test veya geli�tirme gibi �e�itli uygulamalarda kullan�labilen rastgele say�lar ve dizeler �retmenin basit bir yolunu sa�lar.

## Yerel(Local) olarak kullanarak

Bu MCP sunucusunu, derlenmi� bir MCP sunucu paketi kullanmadan kaynak kodundan (yerel olarak) test etmek i�in, GitHub reposunu indridikten sonra IDE'nizi projeyi do�rudan `dotnet run` kullanarak �al��t�racak �ekilde yap�land�rabilirsiniz.

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

Yap�land�r�ld�ktan sonra, Copilot Chat'ten rastgele bir say� isteyebilirsiniz; �rne�in, ``Bana 3 rastgele isim ver``. `MFramework.Services.FakeData.McpServer` MCP sunucusunda `get_first_name` arac�n� kullanman�z istenecek ve sonu�lar g�sterilecektir.

## NuGet.org'dan MCP Sunucusunu Kullanma

MCP sunucu paketi NuGet.org'da yay�nland�ktan sonra, tercih etti�iniz IDE'de yap�land�rabilirsiniz. Hem VS Code hem de Visual Studio, MCP sunucu paketini NuGet.org'dan indirip y�klemek i�in `dnx` komutunu kullan�r. (Bu MCP tool u kal�c� olmadan indirip o an uygulama gibi �al��t�rmak i�in kullan�l�r.) 

Esas uygulama alan� a�a��daki ad�mlar� izleyerek MCP sunucusunu yap�land�rabilirsiniz: B�ylece IDE/Edit�r MCP sunucusunu kullanabilir.

- **VS Code**: `<WORKSPACE DIRECTORY>/.vscode/mcp.json` dosyas� olu�turun
- **Visual Studio**: `<SOLUTION DIRECTORY>\.mcp.json` dosyas� olu�turun

Hem VS Code hem de Visual Studio i�in yap�land�rma dosyas� a�a��daki sunucu tan�m�n� kullan�r:

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

Bir den fazla MCP Tool kullanacaksan�z `servers` b�l�m�ne birden fazla MCP sunucu tan�m� ekleyebilirsiniz. Her sunucu i�in `type`, `command`, `args` ve `env` gibi alanlar� belirlemeniz gerekir.

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
    // Di�er MCP sunucular� i�in benzer tan�mlar ekleyebilirsiniz
    // ...
  }
}
```