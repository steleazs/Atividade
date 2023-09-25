Int32 numero, contagem, resultado = 1;

Console.WriteLine("Digite um número positivo e inteiro: ");
numero = Convert.ToInt32(Console.ReadLine());

if (numero == 0)
{
    Console.WriteLine("0! = 1: ");
}
else
{
    for (contagem = 1; contagem <= numero; contagem++)
    {
        resultado *= contagem;
    }
    Console.WriteLine(numero + "! = " + resultado);
}