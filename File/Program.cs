string caminhoOrigem = @"d:\dados\arquivo1.txt";
string caminhoDestino = @"d:\dados\arquivo1.txt";

// criar arquivo
//File.Create(caminhoOrigem);
if (!File.Exists(caminhoDestino))
{


    try
    {
        File.WriteAllText(caminhoOrigem, "Fernando Pessoa\r\n");

        string novoTexto = "O Poeta é um fingidor " +
            Environment.NewLine +
            "Finge tão completamente\r\n" +
            "Que chega a fingir que é dor\r\n" +
            "A dor que deveras sente.\r\n";

        //acrescentar texto ao arquivo
        File.AppendAllText(caminhoOrigem, novoTexto);

        //ler o conteúdo do arquivo
        Console.WriteLine("\nConteúdo e informações do arquivo :");
        string conteudo = File.ReadAllText(caminhoOrigem);
        Console.WriteLine(conteudo);

        Console.WriteLine($"Última modificação feita em : {File.GetLastWriteTime(caminhoOrigem)}");
        Console.WriteLine($"Última acesso feito em : {File.GetLastAccessTime(caminhoOrigem)}");

        //outrar maneira de ler o conteúdo do arquivo
        string[] linhas = File.ReadAllLines(caminhoOrigem);
        foreach (string linha in linhas)
        {
            Console.WriteLine(linha);
        }

        // Copiar o arquivo para outro local
        var caminhoCopia = @"d:\dados\arquivo1.txt_copia.txt";
        Console.WriteLine($"\nCopiando de {caminhoOrigem} para {caminhoCopia}");
        File.Copy(caminhoOrigem, caminhoCopia);

        // Mover o arquivo para outro local
        
        Console.WriteLine($"\nMovendo de {caminhoOrigem} para {caminhoDestino}");
        File.Move(caminhoOrigem, caminhoDestino);

        // Excluir o arquivo
        Console.WriteLine($"\nExcluindo o arquivo {caminhoDestino}, {caminhoDestino}, {caminhoCopia}");
        File.Delete(caminhoDestino);
        File.Delete(caminhoCopia);
        File.Delete(caminhoOrigem);
        Console.ReadKey();

    }
    catch (Exception ex)
    {
        Console.WriteLine($"{ex.Message}");
    }
}



