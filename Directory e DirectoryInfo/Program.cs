var caminhoDiretorio = @"d:\dados\";

Console.WriteLine("\nObtendo os subdiretorios de um diretorio");

try
{
    if (Directory.Exists(caminhoDiretorio))
    {
        string[] arquivos = Directory.GetFiles(caminhoDiretorio);
        foreach (var item in arquivos)
        {
            Console.WriteLine(item);
        }
    }
    else
    {
        Console.WriteLine($"O diretório {caminhoDiretorio} não existe!");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    //Console.WriteLine(ex.StatcTrace);
}

Console.ReadKey();