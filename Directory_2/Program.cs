
var caminhoDiretorio = @"d:\dados";

var diretorioOrigem = new DirectoryInfo(caminhoDiretorio);

Console.WriteLine("Nome do diretório: " + diretorioOrigem.Name);
Console.WriteLine("Caminho completo do diretório: " + diretorioOrigem.FullName);
Console.WriteLine("Data de criação: " + diretorioOrigem.CreationTime);
Console.WriteLine("Último acesso: " + diretorioOrigem.LastAccessTime);
Console.WriteLine("Última modificação: " + diretorioOrigem.LastWriteTime);
Console.WriteLine("Atributos: " + diretorioOrigem.Attributes);

Console.WriteLine("\nCriando um novo diretório");
var novoDiretorio = new DirectoryInfo(@"d:\dados\MeuDiretorio");
try
{
    if (!novoDiretorio.Exists)
    {
        novoDiretorio.Create();
        Console.WriteLine($"{novoDiretorio.FullName} criado com sucesso: ");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);	
}

Console.WriteLine("\nExcluindo um diretório:");
try
{
    if (novoDiretorio.Exists)
    {
        novoDiretorio.Delete();
        Console.WriteLine($"{novoDiretorio} excluido com sucesso");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.WriteLine($"\nExibindo os subdiretorios de {caminhoDiretorio}");
try
{
    foreach (var item in diretorioOrigem.GetDirectories())
    {
        Console.WriteLine(item.Name);
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.WriteLine($"\nExibindo os arquivos de {caminhoDiretorio}");
try
{
    foreach (var item in diretorioOrigem.GetFiles())
    {
        Console.WriteLine(item.Name);
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.WriteLine($"\nCriar um subdiretório em {caminhoDiretorio}");
try
{
    diretorioOrigem.CreateSubdirectory("NovoSubdiretorio");
    Console.WriteLine("Subdiretorio criado com sucesso ");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.ReadKey();