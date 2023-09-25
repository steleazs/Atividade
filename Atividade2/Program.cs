Int32 numero1, numero2, numero3, maiorNumero = 0, numeroMeio = 0, menorNumero = 0;

Console.WriteLine("Digite o primeiro núnmero: ");
numero1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o segundo núnmero: ");
numero2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o terceiro núnmero: ");
numero3 = Convert.ToInt32(Console.ReadLine());

if (numero1 > numero2 && numero1 > numero3)
{
    maiorNumero = numero1;
}
else if (numero2 > numero1 && numero2 > numero3)
{
    maiorNumero = numero2;
}
else if (numero3 > numero1 && numero3 > numero2)
{
    maiorNumero = numero3;
}

if (numero1 < numero2 && numero1 < numero3)
{
    menorNumero = numero1;
}
else if (numero2 < numero1 && numero2 < numero3)
{
    menorNumero = numero2;
}
else if (numero3 < numero1 && numero3 < numero2)
{
    menorNumero = numero3;
}

if (numero1 > numero2 && numero1 < numero3 || numero1 > numero3 && numero1 < numero2)
{
    numeroMeio = numero1;
}
else if (numero2 > numero1 && numero2 < numero3 || numero2 > numero3 && numero2 < numero1)
{
    numeroMeio = numero2;
}
else
{
    numeroMeio = numero3;
}

Console.WriteLine("\n" + maiorNumero + "\n" + numeroMeio + "\n" + menorNumero);