using System.IO;

string caminhoArquivo = @"d:\dados\poesia_copia.txt";

//FileStream fs = null;
StreamReader leitor = null;

try
{
    //fs = new FileStream(caminhoArquivo, FileMode.Open, FileAccess.Read);
    leitor = File.OpenText(caminhoArquivo);  //new StreamReader(fs);

    // Ler o conteúdo do arquivo enquanto não for o fim do arquivo 
    string? linha;
    while ((linha = leitor.ReadLine()) != null)
    {
        Console.WriteLine(linha);
    }
}
catch (IOException ex)
{
    Console.WriteLine(ex.Message);
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    // Fechar o leitor e o FileStream
    if (leitor != null)
    {
        leitor.Close();
    }
    //if (fs != null)
    //{
    //    fs.Close();
    //}
}