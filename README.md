# DataProcessor
## Working with Files in C# 10 

### 1 - Managing Files and Directories
Verificar se um arquivo existe ou n�o, utilizando o m�todo est�tico da classe File:

```csharp
File.Exists()
```



Verificar a exist�ncia de um diret�rio utilizando o m�todo est�tico da classe Directory:

```csharp
Directory.Exists()
```

> PS: A classe File e Directory existe no namespace system.io. 

Criar um novo diret�rio:

```csharp
Directory.CreateDirectory()
```

Previnir lan�amentos de  exce��o se o diret�rio n�o existir.

```csharp
if (!Directory.Exists(backupDirectoryPath))
{
    WriteLine($"Creating {backupDirectoryPath}");
    Directory.CreateDirectory(backupDirectoryPath);
}
```

Copiar arquivos:

```csharp
File.Copy()
```

Mover arquivos:

```csharp
File.Move()
```

Deletar o diret�rio 

```csharp
Directory.Delete()
```

Obter uma lista de arquivos em um diret�rio:

```csharp
Directory.GetFiles()
```

Utilidade do `Path.Combine()` da classe `Path` que tamb�m existe no namespace system.io.

que nos permite construir um caminho inteiro com base em fragmentos de caminhos.

Obter apenas a extens�o do arquivo:

```csharp
Path.GetExtension()
```

Alterar a extens�o do arquivo:

```csharp
Path.ChangeExtension()
```