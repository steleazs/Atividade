Int32 horaTrabalho, horasMes, salarioBruto, iR, sindicato, fgts, totalDesconto, salarioLiquido;

Console.WriteLine("Digite o valor da sua hora de trabalho:");
horaTrabalho = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a quantidade de horas trabalhadas no mês:");
horasMes = Convert.ToInt32(Console.ReadLine());

salarioBruto = horaTrabalho * horasMes;

if (salarioBruto > 2500)
{
    iR = salarioBruto * 20 / 100;
}
else if (salarioBruto > 1500)
{
    iR = salarioBruto * 10 / 100;
}
else if (salarioBruto > 900)
{
    iR = salarioBruto * 5 / 100;
}
else
{
    iR = salarioBruto * 0 / 100;
}

sindicato = salarioBruto * 3 / 100;
fgts = salarioBruto * 11 / 100;
totalDesconto = iR + sindicato;
salarioLiquido = salarioBruto - totalDesconto;

Console.WriteLine("Salário Bruto: " + salarioBruto);
Console.WriteLine("Imposto de renda: " + iR);
Console.WriteLine("Sindicato: " + sindicato);
Console.WriteLine("FGTS: " + fgts);
Console.WriteLine("Total de descontos: " + totalDesconto);
Console.WriteLine("Salário Líquido: " + salarioLiquido);