// 2-
try
{
    Console.WriteLine("\nInforme o caminho do arquivo de origem: ");
    var caminhoOrigem = Console.ReadLine();

    Console.WriteLine("\nInforme a pasta de destino: ");
    var pastaDestino = Console.ReadLine();

    // Pega o nome do arquivo a partir do caminho de origem
    var nomeArquivo = Path.GetFileName(caminhoOrigem);

    // Junta a pasta destino com o nome do arquivo
    var caminhoDestino = Path.Combine(pastaDestino, nomeArquivo);

    // Copia o arquivo
    File.Copy(caminhoOrigem, caminhoDestino, overwrite: true);

    Console.WriteLine($"\nArquivo copiado de {caminhoOrigem} para {caminhoDestino}");
}
catch (Exception ex)
{
    Console.WriteLine($"\nErro: {ex.Message}");
}


