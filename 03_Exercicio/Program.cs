// 3-
string arquivoCriar = @"d:\dados\arquivo1.txt";
if (!File.Exists(arquivoCriar))
{
	try
	{
        File.WriteAllText(arquivoCriar, "Copa Libertadores 2025.\n");


        Console.WriteLine("(Conteúdo do arquivo:)");
        string conteudo = File.ReadAllText(arquivoCriar);
        Console.WriteLine(conteudo);

        Console.WriteLine("\n(Adicionando mais conteudo ao arquivo:)");
        string novoTexto = "Flamengo x Internacional" +
            "\r\n" +
            "Data: 15 de julho de 2025\r\n" +
            "Local: Estádio do Maracanã\r\n";
        File.AppendAllText(arquivoCriar, novoTexto);
        string[] linhas = File.ReadAllLines(arquivoCriar);
        foreach (string linha in linhas)
        {
            Console.WriteLine(linha);
        }
    }
	catch (Exception ex)
	{

        Console.WriteLine(ex.Message);
	}
    
}
Console.ReadKey();