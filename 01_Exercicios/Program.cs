// 1-
Console.WriteLine("Informe um caminho: ");
string caminhoArquivo = Console.ReadLine();

DirectoryInfo caminhoInfo = new DirectoryInfo(caminhoArquivo);

if (!caminhoInfo.Exists)
{
    Console.WriteLine($"\no Arquivo '{caminhoArquivo}' não foi encontrado");
}
else
{
    Console.WriteLine($"Arquivo criado em '{caminhoInfo.CreationTime}'");
}
Console.ReadKey();

