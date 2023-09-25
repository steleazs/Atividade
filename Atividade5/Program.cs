Int32 lado, coluna, linha;

Console.WriteLine("Digite o tamanho do lado de um quadrado: ");
lado = Convert.ToInt32(Console.ReadLine());

for (coluna = 1; coluna <= lado; coluna++)
{
    for (linha = 1; linha <= lado; linha++)
    {
        Console.Write("* ");
    }
    Console.WriteLine();
}