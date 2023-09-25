decimal precoCarro, valorFinal = 0, valorParcela = 0;

Console.WriteLine("Digite o preço do carro: ");
precoCarro = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Digite em quantas parcelas pretende pagar (6, 12, 18, 24, 30, 36, 42, 48, 54 e 60, '1' sendo à vista): ");
int parcela = Convert.ToInt32(Console.ReadLine());

if (parcela == 1)
{
    valorFinal = precoCarro - (precoCarro * 20 / 100);
    valorParcela = valorFinal / parcela;
}
if (parcela == 6)
{
    valorFinal = precoCarro + (precoCarro * 3 / 100);
    valorParcela = valorFinal / parcela;
}
if (parcela == 12)
{
    valorFinal = precoCarro + (precoCarro * 6 / 100);
    valorParcela = valorFinal / parcela;
}
if (parcela == 18)
{
    valorFinal = precoCarro + (precoCarro * 9 / 100);
    valorParcela = valorFinal / parcela;
}
if (parcela == 24)
{
    valorFinal = precoCarro + (precoCarro * 12 / 100);
    valorParcela = valorFinal / parcela;
}
if (parcela == 30)
{
    valorFinal = precoCarro + (precoCarro * 15 / 100);
    valorParcela = valorFinal / parcela;
}
if (parcela == 36)
{
    valorFinal = precoCarro + (precoCarro * 18 / 100);
    valorParcela = valorFinal / parcela;
}
if (parcela == 42)
{
    valorFinal = precoCarro + (precoCarro * 21 / 100);
    valorParcela = valorFinal / parcela;
}
if (parcela == 48)
{
    valorFinal = precoCarro + (precoCarro * 24 / 100);
    valorParcela = valorFinal / parcela;
}
if (parcela == 54)
{
    valorFinal = precoCarro + (precoCarro * 27 / 100);
    valorParcela = valorFinal / parcela;
}
if (parcela == 60)
{
    valorFinal = precoCarro + (precoCarro * 30 / 100);
    valorParcela = valorFinal / parcela;
}

Console.WriteLine("Preço final: " + valorFinal);
Console.WriteLine("Valor da parcela: " + valorParcela);