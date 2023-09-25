decimal numero, contagem, soma = 0;

Console.WriteLine("Digite um número inteiro e positivo: ");
numero = Convert.ToDecimal(Console.ReadLine()); ;

for (contagem = 1; contagem <= numero; contagem++)
{
    if (contagem == 1)
    {
        soma = 1;
    }
    else
    {
        soma += 1 / contagem;
    }
    if (contagem == 1)
    {
        Console.Write("S = 1");
    }
    else
    {
        Console.Write(" + 1/" + contagem);
    }
}
Console.WriteLine(" = " + soma);