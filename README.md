# DataProcessor
## Working with Files in C# 10 

### 1 - Managing Files and Directories
Verificar se um arquivo existe ou não, utilizando o método estático da classe File:

```csharp
File.Exists()
```



Verificar a existência de um diretório utilizando o método estático da classe Directory:

```csharp
Directory.Exists()
```

> PS: A classe File e Directory existe no namespace system.io. 

Criar um novo diretório:

```csharp
Directory.CreateDirectory()
```

Previnir lançamentos de  exceção se o diretório não existir.

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

Deletar o diretório 

```csharp
Directory.Delete()
```

Obter uma lista de arquivos em um diretório:

```csharp
Directory.GetFiles()
```

Utilidade do `Path.Combine()` da classe `Path` que também existe no namespace system.io.

que nos permite construir um caminho inteiro com base em fragmentos de caminhos.

Obter apenas a extensão do arquivo:

```csharp
Path.GetExtension()
```

Alterar a extensão do arquivo:

```csharp
Path.ChangeExtension()
```